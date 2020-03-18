using System;
using System.Collections.Generic;

namespace LunchBuddies
{
    class Program
    {
        static void Main(string[] args)
        {
            List<LunchBuddy> companions = new List<LunchBuddy> { };

            var beedineet1 = new LunchBuddy("Beth", "Thielman");
            var beedineet2 = new LunchBuddy("Nick", "Davis");
            var beedineet3 = new LunchBuddy("Kayla", "Davis");
            var beedineet4 = new LunchBuddy("Sophie", "Seage");

            companions.Add(beedineet1);
            companions.Add(beedineet2);
            companions.Add(beedineet3);

            beedineet4.Eat("coq au vin", companions);

            beedineet1.Eat();

            beedineet2.Eat("baked Alaska");

            companions.Add(beedineet4);
            companions.Remove(beedineet3);

            beedineet3.Eat(companions);

            Console.ReadLine();
        }
    }
}
