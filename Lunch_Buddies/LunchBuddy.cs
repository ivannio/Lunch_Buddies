using System;
using System.Collections.Generic;
using System.Text;

namespace Lunch_Buddies
{
    class LunchBuddy
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void Eat()
        {
            var restaurant = new Restaurant();
            Console.WriteLine($"{FirstName} {LastName} is eating at {restaurant.Name}");
        }

        public void Eat(string food)
        {
            Console.WriteLine($"{FirstName} {LastName} is eating {food} in their office.");
        }

        public void Eat(List<LunchBuddy> companions)
        {
            var restaurant = new Restaurant();
            var firstNames = new List<string> { };
            foreach (var companion in companions)
            {
                var first = companion.FirstName;
                firstNames.Add(first);
            }
            string buds = string.Join(", ", firstNames);
            Console.WriteLine($"Currently at {restaurant.Name} with {buds}");
        }

        public void Eat(string food, List<LunchBuddy> companions)
        {
            var restaurant = new Restaurant();
            var firstNames = new List<string> { };
            foreach (var companion in companions)
            {
                var first = companion.FirstName;
                firstNames.Add(first);
            }
            string buds = string.Join(", ", firstNames);
            Console.WriteLine($"Just ordered {food} at {restaurant.Name} with {buds}");
        }
    }
}
