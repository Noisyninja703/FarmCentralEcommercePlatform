using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace ST10084225_FarmCentral_MVC.Models
{
    public class Filter
    {
        [AllowNull]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [AllowNull]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        [AllowNull]
        public decimal MaxPrice { get; set; }

        [AllowNull]
        public string SearchTerm { get; set; }

        [AllowNull]
        public string Id { get; set; }

        [AllowNull]
        public string Category { get; set; }
    }
}
