using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using proj_studyno_http.core;
using proj_studyno_http.data;
using static proj_studyno_http.core.Res;

namespace proj_studyno_http.Pages.Res
{
    public class editModel : PageModel
    {
        [BindProperty]
        public Restaurant Restaurant { get; set; }

        public IEnumerable<SelectListItem> Colors {get; set;}
        readonly IRestaurantData RestaurantData;
        private readonly IHtmlHelper htmlHelper;

        public editModel(IRestaurantData restaurantData,
            IHtmlHelper htmlHelper)
        {
            this.RestaurantData = restaurantData;
            this.htmlHelper = htmlHelper;
        }
        public IActionResult OnGet(int restaurantId)
        {

            if (restaurantId == 0)
            {
                Restaurant = new Restaurant();
            }
             else
            {
                Restaurant = RestaurantData.GetById(restaurantId);
            }

            if (Restaurant == null)
            {
                return RedirectToPage("./all");
            }

            Colors = htmlHelper.GetEnumSelectList<rescolor>();

            
            return Page();
        }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                Colors = htmlHelper.GetEnumSelectList<rescolor>();
                return Page();

            }
            
            if(Restaurant.Id > 0)
            {
                RestaurantData.Update(Restaurant);

            }
            else
            {
                
                RestaurantData.Add(Restaurant);
            }

            TempData["message"] = "Restaurant saved";
            RestaurantData.commit();
            return RedirectToPage("./detail", new { RestaurantId = Restaurant.Id });
        }
    }
}
