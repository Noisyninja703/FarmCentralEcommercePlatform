using System;
using System.Collections.Generic;

namespace ST10084225_FarmCentral_MVC.Models
{
    public interface IProductRepository
    {
        //get all products currently on site
        IEnumerable<Product> GetAllProducts { get; }

        //get all of a farmers products currently on site
        IEnumerable<Product> GetAllFarmersProducts(string id);

        //get all products of a specific category currently on site
        IEnumerable<Product> GetAllCategoryProducts(IEnumerable<Product> products, string id);

        //get all products with a specific name currently on site
        IEnumerable<Product> GetAllNamedProducts(string id);

        //get all products in a specific date range
        IEnumerable<Product> GetFilterProducts(string id, DateTime startDate, DateTime endDate);

        //get all products below a certain price
        IEnumerable<Product> GetPricedProducts(IEnumerable<Product> products, decimal maxPrice);


        //Search by Name
        Product GetProductById(string productName);
    }
}
