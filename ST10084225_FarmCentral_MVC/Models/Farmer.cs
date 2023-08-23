using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ST10084225_FarmCentral_MVC.Models
{
    public class Farmer
    {
        [Key]
        [DataType(DataType.Text)]
        public string FarmerID { get; set; }

        [Key, Column(Order = 1)]
        [DataType(DataType.Text)]
        public string FarmerName { get; set; }
    }
}
