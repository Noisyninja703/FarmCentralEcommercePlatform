using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System;

namespace ST10084225_FarmCentral_MVC.Models
{
    public class Product
    {
        //Product table -- Composite Key <ProductID, FarmerID> -- Allows products to be bound to farmers on creation.
        [Key]
        [DataType(DataType.Text)]
        public int ProductID { get; set; }

        [Key, Column(Order = 1)]
        [DataType(DataType.Text)]
        public string FarmerID { get; set; }

        //Product Details
        [DataType(DataType.Text)]
        public string Name { get; set; }
        [DataType(DataType.Text)]
        public decimal Price { get; set; }

        [DataType(DataType.Text)]
        public string Category { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [DataType(DataType.Text)]
        public string Description { get; set; }

        //Product Image Mapping

        //Image ID -- Unique mapping key -- Generated using user uploaded image --> Routes controller too uploaded image  
        [DataType(DataType.Text)]
        public string ImageID { get; set; }

        //User Uploaded Image -- Not saved to DB --> Directly saved to wwwroot during runtime for the purposes of this demo project
        [NotMapped]
        [DisplayName("Upload File")]
        public IFormFile ImageFile { get; set; }

    }
}
