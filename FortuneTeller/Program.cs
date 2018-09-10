using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
    //Tim Horta 9/8/2018
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");
            string name = Console.ReadLine();

            Console.WriteLine("What is your surname?");
            string surname = Console.ReadLine();

            Console.WriteLine("What is your age?");
            int age = int.Parse(Console.ReadLine());
            if (age % 2 == 0)
            {
                age = 10;
            }
            else
            {
                age = 13;
            }


            Console.WriteLine("What is your birth month?");
            int month = int.Parse(Console.ReadLine());
            var money = "$0.00";

            if (month < 1)
            {
                money = "$0.00";
            }
            else if ((month == 1) || (month == 2) || (month == 3) || (month == 4))
            {
                money = "$25,000.00";
            }
            else if ((month == 5) || (month == 6) || (month == 7) || (month == 8))
            {
                money = "$50,000.00";
            }
            else if ((month == 9) || (month == 10) || (month == 11) || (month == 12))
            {
                money = "$100,000.00";
            }
            else
            {
                money = "$0.00";
            }


            Console.WriteLine("Select your favorite color from the ROYGBIV spectrum. Type \"Help\" if you do not understand the acronym.");
            string color = Console.ReadLine().ToLower();

            switch (color)
            {
                case "help":
                    Console.WriteLine("ROYGBIV:");
                    Console.WriteLine("Red");
                    Console.WriteLine("Orange");
                    Console.WriteLine("Yellow");
                    Console.WriteLine("Green");
                    Console.WriteLine("Blue");
                    Console.WriteLine("Indigo");
                    Console.WriteLine("Violet");
                    Console.WriteLine("Please exit the application and start again.");
                    break;
                case "red":
                    color = "Ferarri 488";
                    break;
                case "orange":
                    color = "Dodge Charger";
                    break;
                case "yellow":
                    color = "Lamborghini Diablo";
                    break;
                case "green":
                    color = "Toyota Hilux";
                    break;
                case "blue":
                    color = "Plymouth Roadrunner";
                    break;
                case "indigo":
                    color = "Chevy Corvette";
                    break;
                case "violet":
                    color = "Ford Mustang";
                    break;
            }


            Console.WriteLine("How many siblings do you have?");
            int siblings = int.Parse(Console.ReadLine());

            var location = "Detroit";


            if (siblings < 0)
            {
                location = "Detroit";
            }
            else if (siblings == 0)
            {
                location = "Paris";
            }
            else if (siblings == 1)
            {
                location = "Rome";
            }
            else if (siblings == 2)
            {
                location = "Maui";
            }
            else if (siblings == 3)
            {
                location = "Tahiti";
            }
            else
            {
                location = "Barcelona";
            }

            Console.WriteLine("{0} " + "{1} " + "will retire in " + "{2} years " + "with " + "{3} " + "in the bank, a vacation home in " + "{4}, " + "and a {5}.", name, surname, age, money, location, color);
        }
    }
}
