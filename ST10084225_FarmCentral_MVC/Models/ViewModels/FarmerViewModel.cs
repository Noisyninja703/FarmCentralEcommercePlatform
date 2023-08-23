using System.Collections.Generic;

namespace ST10084225_FarmCentral_MVC.Models.ViewModels
{
    //A view model which will allow us to fuse partials together to make a complete view
    public class FarmerViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public Filter Filter { get; set; }

    }
}
