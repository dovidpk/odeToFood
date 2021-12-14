using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using proj_studyno_http.core;
using proj_studyno_http.data;

namespace proj_studyno_http.Pages.Res
{
    public class res1Model : PageModel
    {
        private readonly IConfiguration config;
        private readonly IRestaurantData restaurantData;

        public string Message { get; set; }
        public IEnumerable<Restaurant> restaurants { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchParms { get; set; }

        public res1Model(IConfiguration config, IRestaurantData restaurantData)
        {
            this.config = config;
            this.restaurantData = restaurantData;
        }

        public void OnGet()
        {
            restaurants = restaurantData.GetByName(SearchParms);
            Message = config["Message"];
        }
    }
}
