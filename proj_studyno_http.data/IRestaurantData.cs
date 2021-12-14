using System;
using System.Collections.Generic;
using proj_studyno_http.core;
using System.Text;
using System.Linq;

namespace proj_studyno_http.data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetByName(string name);
        Restaurant GetById(int id);
        Restaurant Update(Restaurant nRestaurant);
        Restaurant Add(Restaurant restaurant);
        int commit();
    }

    public class InMemoryRestaurantData : IRestaurantData
    {
        readonly List<Restaurant> restaurants;

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant {Id = 1, Name = "res num 1", Color = Res.rescolor.blue, Address = "312 r lane"},
                new Restaurant {Id = 3, Name = "res num 3", Color = Res.rescolor.red, Address = "313 r lane"},
                new Restaurant {Id = 2, Name = "res num 2", Color = Res.rescolor.white, Address = "314 r lane"},
                new Restaurant {Id = 4, Name = "res num 4", Color = Res.rescolor.green, Address = "315 r lane"}
            };
        }

        public Restaurant Update(Restaurant nRestaurant)
        {
            var Restaurant = restaurants.SingleOrDefault(r => r.Id == nRestaurant.Id);
            if(Restaurant != null)
            {
                Restaurant.Name = nRestaurant.Name;
                Restaurant.Address = nRestaurant.Address;
                Restaurant.Color = nRestaurant.Color;
            }
            return Restaurant;
        }

        public int commit ()
        {
            return 0;
        }

        public Restaurant GetById(int id)
        {
            return restaurants.SingleOrDefault(r => r.Id == id);
        }

        public IEnumerable<Restaurant> GetByName(string name = "")
        {
            return from r in restaurants
                   where String.IsNullOrEmpty(name) || r.Name.StartsWith(name)
                   orderby r.Id
                   select r; 
        }

        public Restaurant Add(Restaurant nRestaurant)
        {
            
            restaurants.Add(nRestaurant);
            nRestaurant.Id = restaurants.Max(r => r.Id) + 1;
            return nRestaurant;
        }
    }
}
