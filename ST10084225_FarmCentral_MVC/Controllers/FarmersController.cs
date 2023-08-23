using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ST10084225_FarmCentral_MVC.Data;
using ST10084225_FarmCentral_MVC.Models;
using ST10084225_FarmCentral_MVC.Models.ViewModels;

namespace ST10084225_FarmCentral_MVC.Controllers
{
    public class FarmersController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;
        private readonly IProductRepository _productRepository;

        public FarmersController(ApplicationDbContext context, IProductRepository productRepository, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            _productRepository = productRepository;
            _hostEnvironment = hostEnvironment;
        }

        // GET: FarmerSearch
        public async Task<IActionResult> FarmerSearch(string id)
        {
            //Init the View Model
            var farmerViewModel = new FarmerViewModel();
            farmerViewModel.Filter = new Filter();

            //Save the Farmer ID --> used to route to POST
            farmerViewModel.Filter.Id= id;

            //Find farmers by ID
            farmerViewModel.Products = _productRepository.GetAllFarmersProducts(id);

            return View(farmerViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ViewResult FarmerSearch([Bind("StartDate, EndDate,SearchTerm, Id, Category")] Filter filter)
        {
            //Set a baseline context, which will then be filtered depending on the users filter selection
            var baseContext = _productRepository.GetAllFarmersProducts(filter.Id);

            //Setup a var to hold our formatted context
            var list = baseContext;

            //Init the Product ViewModel
            var farmerViewModel = new FarmerViewModel();
            farmerViewModel.Filter = filter;

            //Variable to check if the dates were edited
            DateTime dt1 = DateTime.Parse("1/1/0001");

            //Check if a search filters are entered --> Date Filter, Price Filter
            if (!(filter.StartDate <= dt1) && !(filter.EndDate <= dt1))
            {

                ViewBag.Date = filter.StartDate + " : " + filter.EndDate + " : " + filter.Id.ToString();

                //Filter the farmers products by date
                baseContext = _productRepository.GetFilterProducts(filter.Id, filter.StartDate, filter.EndDate);
                list = baseContext;
            }

            //Filter by product category
            if (filter.Category != "Select Category")
            {
                baseContext = _productRepository.GetAllCategoryProducts(baseContext, filter.Category);
                list = baseContext;
            }

            if (filter.SearchTerm != null)
            {
                //Search through the baseline context to find any matches with the search terms using LINQ
                list = (from t in baseContext
                        where (t.Name == filter.SearchTerm) || (t.ProductID.ToString() == filter.SearchTerm)
                        select t);
            }

            //set the product view module
            farmerViewModel.Products = list;

            //return the view
            return View(farmerViewModel);
        }


        // GET: Farmers
        public async Task<IActionResult> Index()
        {
            return View(await _context.Farmers.ToListAsync());
        }

        // GET: Farmers/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var farmer = await _context.Farmers
                .FirstOrDefaultAsync(m => m.FarmerID == id);
            if (farmer == null)
            {
                return NotFound();
            }

            return View(farmer);
        }

        // GET: Farmers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Farmers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FarmerID,FarmerName")] Farmer farmer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(farmer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(farmer);
        }

        // GET: Farmers/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var farmer = await _context.Farmers.FindAsync(id);
            if (farmer == null)
            {
                return NotFound();
            }
            return View(farmer);
        }

        // POST: Farmers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("FarmerID,FarmerName")] Farmer farmer)
        {
            if (id != farmer.FarmerID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(farmer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FarmerExists(farmer.FarmerID))
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
            return View(farmer);
        }

        // GET: Farmers/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var farmer = await _context.Farmers
                .FirstOrDefaultAsync(m => m.FarmerID == id);
            if (farmer == null)
            {
                return NotFound();
            }

            return View(farmer);
        }

        // POST: Farmers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var farmer = await _context.Farmers.FindAsync(id);
            _context.Farmers.Remove(farmer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FarmerExists(string id)
        {
            return _context.Farmers.Any(e => e.FarmerID == id);
        }
    }
}
