using System;
using System.Collections.Generic;

namespace TextAdventure
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Yo bro welcome to Super Bro Life Simulator 3000 (Deluxe Edition (Pre-Order Edition))! What's your name, bro?");
            PlayerCharacter player = new PlayerCharacter();
            player.Agility = 5;
            player.Strength = 5;
            player.Name = Console.ReadLine();

            Console.WriteLine($"What's good, {player.Name}! Lets get after it." +
                $"\nChoices you can make will be in ALL CAPS." +
                $"\nTo check your stats, type 'STATS'." +
                $"\nLet's get after it. Press any key!");

            Console.ReadLine();

            Console.WriteLine("The sunlight peeking through the blinders hits your face. " +
                "\nYou wake up on your couch, head pounding and stomach churnning. You look at your phone...12:45pm. " +
                "\nFriday beers with Brad, Cody, Maverick, and the rest of the boys did a number on you once again... " +
                "\n...but it's still Gains O'Clock. " +
                "\nYou gotta get to the gym to hit the bench press for the 6th time this week. ");

            Console.WriteLine();

            Console.WriteLine("Agility: 5" +
                "\nStrength: 5");

            Console.ReadLine();

            Console.WriteLine("You gotta get hydrated before your lift. " +
                "\nYou haven't gone to the grocery store in weeks, so your options are:");

            Console.WriteLine("\nWATER" +
                "\nPREWORKOUT " +
                "\nand BEER.");
                
            Console.WriteLine();

            Console.WriteLine("What will you drink before heading to the gym in your beat-up 2007 Mustang?");

            string playerDrink = Console.ReadLine();
            ChooseDrink(playerDrink);

            if (playerDrink == "preworkout")
            {
                player.Agility = 10;
            }
            
            if (playerDrink == "beer")
            {
                player.Strength = 10;
            }

            Console.ReadLine();

            Console.WriteLine("You arrive at the gym and walk in. You see the bench wide open." +
                "\nThis is your moment, bro. It's time to show everyone what you're made of even though nobody asked" +
                "\nand nobody cares.");

            Console.WriteLine();

            Console.WriteLine("But suddenly, emerging from the shadows, you see Brad, your archnemesis. " +
                "\nHe notices you and slowly approches you. 'Hope you're not planning on using that bench, bro,' he says to you." +
                "\nYou think about what you can do:");

            Console.WriteLine("\nFIGHT" +
                "\nTALK him into working in with his sets" +
                "\nCRY and hope he has mercy");

            Console.WriteLine();
        }




        public static void Stats()
        {
            Console.WriteLine();
        }

        public static void GameOver()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("YOU LOSE :(");
            throw new NotImplementedException();
        }

        public static string ChooseDrink(string choice)
        { 
                switch (choice.ToLower())
                {
                    case "water":
                        Console.WriteLine("Are you for real, bro? Get that weak stuff outta here.");
                        GameOver();
                        break;

                    case "preworkout":
                        
                        Console.WriteLine("You slam 7 scoops of PREWORKOUT back to back." +
                            "\n Your Agility increases by 5.");
                        break;

                    case "beer":
                        Console.WriteLine("Hair of the dog!!! You shotgun a Miller Lite and head out the door." +
                            "\n Your strength increases by 5.");
                        break;
                    default:
                        Console.WriteLine("Please choose a drink.");
                        break;
                }
                return choice; 
        }

        public static string BlueText(string text)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            return text;
        }
    }
}