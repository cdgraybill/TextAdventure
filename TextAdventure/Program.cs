using System;

namespace TextAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Text Adventure! What's your characters name?");
            PlayerCharacter player = new PlayerCharacter();
            player.Name = Console.ReadLine();


            Console.WriteLine($"Hey, {player.Name}! Press any key to start!");
            Console.ReadLine();


        }
    }
}
