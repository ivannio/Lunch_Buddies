using System;
using System.Collections.Generic;
using System.Text;

namespace Lunch_Buddies
{
    class Restaurant
    {
        private List<string> RestaurantNames = new List<string> { "Fish and Barrel", "Nachoz Tres", "Squalor and Fink" };
        public string Name { get; set; }


        Random _random = new Random();
        public Restaurant()
        {
            Name = RestaurantNames[_random.Next(0, 3)];
        }

    }
}
