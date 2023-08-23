using ST10084225_FarmCentral_MVC.Data;
using ST10084225_FarmCentral_MVC.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using System.Globalization;

namespace ST10084225_FarmCentral_MVC.Models
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context)
        {
            this._context = context;
        }

        //Implementations of IProductRepository abstract methods
        public IEnumerable<Product> GetAllProducts => _context.Products;

        public IEnumerable<Product> GetAllCategoryProducts(IEnumerable<Product> products, string id)
        {
            var categoryProducts = from t in products
                                   where t.Category == id
                                   select t;

            return categoryProducts;
        }

        public IEnumerable<Product> GetAllFarmersProducts(string id)
        {
            var FarmerProducts = from t in _context.Products
                                 where t.FarmerID == id
                                 select t;

            return FarmerProducts;
        }

        public IEnumerable<Product> GetAllNamedProducts(string id)
        {
            var namedProducts = from t in _context.Products
                                   where t.Name == id
                                   select t;

            return namedProducts;
        }

        public IEnumerable<Product> GetFilterProducts(string id, DateTime startDate, DateTime endDate)
        {

            var FarmerFilterProducts = (from t in _context.Products
                                       where t.FarmerID ==id && t.Date >= startDate && t.Date <= endDate
                                       select t);

            return FarmerFilterProducts;
        }

        public IEnumerable<Product> GetPricedProducts(IEnumerable<Product> products, decimal maxPrice)
        {
            var PricedProducts = from t in products
                                       where t.Price <= maxPrice
                                       select t;

            return PricedProducts;
        }

        public Product GetProductById(string productName)
        {
            throw new System.NotImplementedException();
        }
    }
}
