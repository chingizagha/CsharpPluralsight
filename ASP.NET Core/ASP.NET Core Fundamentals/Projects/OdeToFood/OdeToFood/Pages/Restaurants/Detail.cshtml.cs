using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OdeToFood.Core;
using OdeToFood.Data;
using System.Collections.Generic;

namespace OdeToFood.Pages.Restaurants
{
    public class DetailModel : PageModel
    {
        [TempData]
        public string Message { get; set; }

        public Restaurant Restaurant { get; set; }
        public IEnumerable<Restaurant> Restaurants;
        private readonly IRestaurantData restaurantData;


        public DetailModel(IRestaurantData restaurantData)
        {
            this.restaurantData = restaurantData;
        }



        public IActionResult OnGet(int restaurantId)
        {
            Restaurant = restaurantData.GetById(restaurantId);
            if (Restaurant == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }
    }
}
