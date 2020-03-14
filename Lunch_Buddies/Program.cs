using System;
using System.Collections.Generic;

namespace Lunch_Buddies
{
    class Program
    {
        static void Main(string[] args)
        {
            var bud1 = new LunchBuddy()
            { 
                FirstName = "Budd",
                LastName = "Dunn"
            };
            var bud2 = new LunchBuddy()
            {
                FirstName = "Gabe",
                LastName = "Brosephene"
            };
            var bud3 = new LunchBuddy()
            {
                FirstName = "Jacob",
                LastName = "Grabenstein"
            };
            var bud4 = new LunchBuddy()
            {
                FirstName = "George",
                LastName = "Jones"
            };
            var bud5 = new LunchBuddy()
            {
                FirstName = "Jessica",
                LastName = "Jess"
            };
            var bud6 = new LunchBuddy()
            {
                FirstName = "Peter",
                LastName = "Pot"
            };
            var bud7 = new LunchBuddy()
            {
                FirstName = "Marsha",
                LastName = "Swamp"
            };

            var companions = new List<LunchBuddy> { };
            companions.Add(bud1);
            companions.Add(bud2);
            companions.Add(bud3);
            companions.Add(bud4);
            companions.Add(bud5);
            companions.Add(bud6);
            companions.Add(bud7);

            bud1.Eat();
            bud2.Eat("Burritos");
            bud3.Eat(companions);
            bud4.Eat("Tacos", companions);
            Console.ReadLine();
        }
    }
}
