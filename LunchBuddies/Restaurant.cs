using System;
using System.Collections.Generic;
using System.Text;

namespace LunchBuddies
{
    class Restaurant
    {
        private List<string> RestaurantNames = new List<string> { "The Creamery", "La Serre", "Zanzibar", "Cafe Matisse" };
        public string Name { get; }

        public Restaurant()
        {
            var Random = new Random();
            int RestaurantIndex = Random.Next(RestaurantNames.Count);

            Name = RestaurantNames[RestaurantIndex];
        }
    }
}
