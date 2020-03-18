using System;
using System.Collections.Generic;
using System.Text;

namespace LunchBuddies
{
    class LunchBuddy
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public LunchBuddy(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string Eat()
        {
            var restaurant = new Restaurant();
            Console.WriteLine($"{FirstName} {LastName} is at {restaurant.Name}.");
            return restaurant.Name;
        }

        public void Eat(string food)
        {
            Console.WriteLine($"{FirstName} ate {food} at the office.");
            Console.WriteLine($"Wait, what is {FirstName} doing at the office?! There's a pandemic on!");
        }

        public void Eat(List<LunchBuddy> companions)
        {
            var restaurant = new Restaurant();
            Console.WriteLine($"{FirstName} {LastName} is at {restaurant.Name} with...");
            foreach (LunchBuddy companion in companions)
            {
                Console.WriteLine($"{companion.FirstName}");
            }
        }

        public void Eat(string food, List<LunchBuddy> companions)
        {
            var restaurant = new Restaurant();
            Console.WriteLine($"{FirstName} {LastName} is at {restaurant.Name} with...");
            foreach (LunchBuddy companion in companions)
            {
                Console.WriteLine($"{companion.FirstName}");
            }
            Console.WriteLine($"{FirstName} ordered {food} at this gathering to which you weren't invited.\nMaybe they think you have COVID-19.");
        }
    }
}
