using System;
using System.Collections.Generic;

namespace TextAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yo bro welcome to Super Bro Life Text Adventure 3000 (Deluxe Edition (Pre-Order Edition))! What's ur name, chief");
            PlayerCharacter player = new PlayerCharacter();
            player.Name = Console.ReadLine();


            Console.WriteLine($"What's good, {player.Name}! Lets get after it. Press a key, my dude");
            Console.ReadLine();

            Console.WriteLine("The sunlight peeking through the blinders hits your face. " +
                "You wake up on your couch, head pounding and stomach churnning. You look at your phone...12:45pm. " +
                "Friday beers with Brad, Cody, Maverick, and the rest of the boys did a number on you once again, but it's still Gains O'Clock. " +
                "You gotta get to the gym to hit arms for the 4th time this week. Press any key.");

            Console.ReadLine();

            Console.WriteLine("You gotta get hydrated before your lift. " +
                $"You haven't gone to the grocery store in weeks, so your options are {ChooseDrink("WATER", "PREWORKOUT", "BEER")} "+
                "What will you drink?");

            Console.ReadLine();
        }

        static string ChooseDrink(string drink1, string drink2, string drink3)
        {
            return "";
        }
    }
}