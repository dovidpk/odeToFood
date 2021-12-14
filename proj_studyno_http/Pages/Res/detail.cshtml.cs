using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using proj_studyno_http.core;
using proj_studyno_http.data;

namespace proj_studyno_http.Pages.Res
{
    public class detailModel : PageModel
    {
        private IRestaurantData RestaurantData;

        [TempData]
        public string message { get; set; }

        public Restaurant Restaurant { get; set; }

        public detailModel(IRestaurantData restaurantData)
        {
            this.RestaurantData = restaurantData;
        }

        public IActionResult OnGet(int restaurantId)
        {
           
            Restaurant = RestaurantData.GetById(restaurantId);
            if (Restaurant == null)
            {
                return RedirectToPage("./all");
            }
            return Page();
    }
    }
}
