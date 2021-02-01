using System;
using System.Collections.Generic;

namespace Ninja_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("THE ADVENTURES OF NINJA AND THE WANDERER!");
            Console.ForegroundColor = ConsoleColor.Gray;


            Console.WriteLine("You are in a dark room.");

            bool isLightOn = false;
            int coins = 50;
            int health = 75;
            List<string> inventory = new List<string>();

            while (true)
            {
                string input = Console.ReadLine();
                string lowerInput = input.ToLower();

                switch (lowerInput)
                {
                    case "turn on light":
                    case "turn on the light":
                        Console.WriteLine("The room lights up and you see a ninja cat");
                        Console.WriteLine("Ninja shows her wares");
                        isLightOn = true;
                        break;

                    case "inventory":
                    case "search pockets":
                        Console.WriteLine("You have " + health + "/100 HP");
                        Console.WriteLine("You have " + coins + " coins");

                        foreach (string item in inventory)
                        {
                            Console.WriteLine(item);
                        }
                        break;

                    case "browse wares":
                        if (isLightOn)
                        {
                            Console.WriteLine("Ninja shows you her wares: ");
                            Console.WriteLine("1. Dreamies (10 coins)");
                            Console.WriteLine("2. Murder Mittens (15 coins)");
                            Console.WriteLine("3. Catnip (5 coins)");
                            Console.WriteLine("4. Toebeans in the air like you just don't care (60 coins)");
                        }
                        else
                        {
                            Console.WriteLine("You can't browse wares in the dark, turn that damn light on!");
                        }
                        break;

                    case "buy dreamies":
                    case "buy 1":
                        if (coins >= 10)
                        {
                            coins = coins - 10;
                            inventory.Add("Dreamies");
                            Console.WriteLine("You bought Dreamies for 10 coins");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("You don't have enough coins!");
                            Console.ResetColor();
                        }

                        break;

                    case "buy murder mittens":
                    case "buy 2":
                        if (coins >= 15)
                        {
                            coins = coins - 15;
                            inventory.Add("Murder Mittens");
                            Console.WriteLine("You bought Murder Mittens for 15 coins");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("You don't have enough coins!");
                            Console.ResetColor();
                        }

                        break;

                    case "buy catnip":
                    case "buy 3":
                        if (coins >= 5)
                        {
                            coins = coins - 5;
                            inventory.Add("Catnip");
                            Console.WriteLine("You bought Catnip for 5 coins");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("You don't have enough coins!");
                            Console.ResetColor();
                        }

                        break;

                    case "buy toebeans in the air like you just don't care":
                    case "buy toebeans":
                    case "buy 4":
                        if (coins >= 60)
                        {
                            coins = coins - 60;
                            Console.WriteLine("Ninja raises the toebean of justice, promtly smacking you on the head");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("You don't have enough coins!");
                            Console.ResetColor();
                        }

                        break;
                    case "stroke ninja":
                    case "stroke cat":
                    case "stroke":
                        if (isLightOn == true)
                        {
                            Console.WriteLine("You stroke the Ninja and she rewarded you with a coin");
                            coins = coins + 1;
                        } else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("You reach your hand forward to feel something furry, suddenly you yelp in pain and withdraw your hand.");
                            Console.WriteLine("It throbs. You lose 5 HP");
                            Console.ResetColor();

                            health = health - 5;
                        }
                        
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Nope.");
                        Console.ResetColor();
                        break;
                }
            }
        }
    }
}
