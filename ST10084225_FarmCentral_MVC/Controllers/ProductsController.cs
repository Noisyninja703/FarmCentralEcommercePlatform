using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using ST10084225_FarmCentral_MVC.Data;
using ST10084225_FarmCentral_MVC.Models;
using ST10084225_FarmCentral_MVC.Models.ViewModels;
using static System.Net.WebRequestMethods;

namespace ST10084225_FarmCentral_MVC.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly IProductRepository _productRepository;

        public ProductsController(ApplicationDbContext context, IWebHostEnvironment hostEnvironment, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, IProductRepository productRepository)
        {
            _context = context;
            _hostEnvironment = hostEnvironment;
            _userManager = userManager;
            _signInManager = signInManager;
            _productRepository = productRepository;
        }

        // GET: Products
        public async Task<IActionResult> Index()
        {
            //Init the View Model
            var productViewModel = new ProductViewModel();
            productViewModel.Product = new Product();
            productViewModel.Filter = new Filter();

            //If a farmer is signed in --> Only display that specific farmer's products
            if (_signInManager.IsSignedIn(User) && User.IsInRole("Farmer"))
                {
                //Get the farmer's account ID
                var findFarmer = User.FindFirstValue(ClaimTypes.NameIdentifier);

                //Use the farmer's account ID to call the GetAllFarmersProducts method from the IRepo 
                productViewModel.Products = _productRepository.GetAllFarmersProducts(findFarmer);
                         
                    //Return the farmers products
                    return View(productViewModel);
                }

            //If anyone but a farmer is signed in --> display all available products in the database.
            productViewModel.Products = _productRepository.GetAllProducts;
            return View(productViewModel);           
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ViewResult Index([Bind("StartDate, EndDate, MaxPrice, SearchTerm, Category")] Filter filter)
        {
            //Set a baseline context, which will then be filtered depending on the users filter selection
            var baseContext = _productRepository.GetAllProducts;
       
            //Init the Product ViewModel
            var productViewModel = new ProductViewModel();
            productViewModel.Product = new Product();

            //Check if price filter has value-- > filter list
            if (!filter.MaxPrice.Equals(null) && filter.MaxPrice != 0)
            {
                baseContext = _productRepository.GetPricedProducts(baseContext, filter.MaxPrice);
            }

            //Filter by product category
            if (filter.Category != "Select Category")
            {
                baseContext = _productRepository.GetAllCategoryProducts(baseContext, filter.Category);
            }

            //Get the FarmerID of an entered search term, if applicable
            var findFarmerName = (from t in _context.Farmers
                                 where t.FarmerName == filter.SearchTerm
                                 select t.FarmerID).FirstOrDefault();

            //Search through the baseline context to find any matches with the search terms using LINQ
            var list = (from t in baseContext
                        where (t.Name == filter.SearchTerm) || (t.ProductID.ToString() == filter.SearchTerm)
                        || (t.FarmerID == findFarmerName) || (t.FarmerID == filter.SearchTerm)
                        select t);                       

            //If a farmer is signed in --> filter the search results to only include that farmer's products
            if ((_signInManager.IsSignedIn(User) && User.IsInRole("Farmer")) && filter.SearchTerm != null)
            {
                list = (from t in list
                        where t.FarmerID == User.FindFirstValue(ClaimTypes.NameIdentifier)
                        select t);
                //set the product view module
                productViewModel.Products = list;
            }          

            //else If the search bar is left empty while a farmer is logged in
            if ((_signInManager.IsSignedIn(User) && User.IsInRole("Farmer")) && filter.SearchTerm == null)
            {

                //Use the farmer's account ID to filter the searched list to only display that farmer's products 
                list = (from t in baseContext
                        where t.FarmerID == User.FindFirstValue(ClaimTypes.NameIdentifier)
                        select t);

                //set the product view module
                productViewModel.Products = list;
            }

            //set the product view module
            productViewModel.Products = list;

            //If the search bar is left empty while anyone but a farmer is logged in
            if (!User.IsInRole("Farmer") && (filter.SearchTerm == null)) { productViewModel.Products = baseContext; }

            //return the view
            return View(productViewModel);
        }

        // GET: Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .FirstOrDefaultAsync(m => m.ProductID == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Products/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProductID,FarmerID,Name,Price,Category,Date,Description,ImageID, ImageFile")] Product product)
        {
            if (ModelState.IsValid)
            {
                //Setup the root path for the uploaded image
                string wwwRootPath = _hostEnvironment.WebRootPath;

                //Get the file name and extension
                string fileName = Path.GetFileNameWithoutExtension(product.ImageFile.FileName);
                string fileExtension = Path.GetExtension(product.ImageFile.FileName);

                //Concat them into a unique key
                fileName = fileName + DateTime.Now.ToString("yymmssfff") + fileExtension;

                //Set the product model Attributes
                product.ProductID = (_context.Products.OrderBy(x => x.ProductID).LastOrDefault().ProductID) + 1;
                product.FarmerID = User.FindFirstValue(ClaimTypes.NameIdentifier);
                product.Date = DateTime.Today.Date;
                //DateTime newDate = DateTime.ParseExact((DateTime.Today.ToShortDateString()), "M/dd/yyyy", null);
                //product.Date = newDate;
                product.ImageID = fileName;

                //Create the image save path to the root folder
                string savePath = Path.Combine(wwwRootPath + "/Images/UserImages", fileName);

                //Save the image --> wwwRoot /Images/UserImages --> using FileStream
                using (var fileStream = new FileStream(savePath, FileMode.Create))
                {
                    await product.ImageFile.CopyToAsync(fileStream);
                }

                _context.Products.Add(product);
                await _context.SaveChangesAsync();

                //Return to index if successful
                return RedirectToAction(nameof(Index));
            }

            //Return view if creation fails
            return View(product);
        }

        // GET: Products/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProductID,FarmerID,Name,Price,Category,Date,Description,ImageID, ImageFile")] Product product)
        {
            if (id != product.ProductID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.ProductID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        // GET: Products/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .FirstOrDefaultAsync(m => m.ProductID == id);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Products.FirstOrDefaultAsync(m => m.ProductID == id);
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.ProductID == id);
        }
    }
}