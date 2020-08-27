 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_JoakimMalmstrom
{
    class Program
    {
        static MovieDesk desk = new MovieDesk();

        static bool runMenu = true;

        static void Main(string[] args)
        {
            do
            {
                MainMenu();

            } while (runMenu);
        }

        private static void MainMenu()
        {
            // Menu
            Console.Clear();
            Console.WriteLine("Main Menu\n");

            Console.WriteLine("1: Movie Night");
            Console.WriteLine("2: Loop Your Words");
            Console.WriteLine("3: Third Word Play");
            Console.WriteLine("¤¤¤¤¤¤¤¤¤¤");
            Console.WriteLine("0: Quit\n");

            switch (Console.ReadLine())
            {
                case "0":
                    Environment.Exit(0);
                    break;
                case "1":
                    MovieNight();
                    break;
                case "2":
                    WordLooping();
                    break;
                case "3":
                    ThirdWord();
                    break;
                default:
                    ErrorMessage();
                    break;
            }
            Console.ReadLine();
        }

        private static void ThirdWord()
        {
            // Info
            Console.Clear();
            Console.WriteLine("Third Word Play");
            Console.WriteLine("Type a sentence with at least 3 words");
            Console.WriteLine("The computer will print the third word of the sentence");

            // string input stores the user's sentence
            // Stores a list of all the words in the array and splits the spaces
            string input = Console.ReadLine();
            string[] list = input.Split(' ');

            // Prints the third word
            Console.WriteLine(list[2]);

            GoBackToMenu();
        }

        private static void MovieNight()
        {
            // Info
            Console.Clear();
            Console.WriteLine("Movie Night\n");

            // Stores the user's input in int amount
            Console.Write("How many are you? ");
            int amount = int.Parse(Console.ReadLine());

            // For every amount we ask how old that person is
            // Adds a visitor with age to the MovieDesk class
            for (int i = 0; i < amount; i++)
            {
                Console.Write($"What is person {(i + 1)} age? ");
                desk.AddVisitor(int.Parse(Console.ReadLine()));
            }

            // Prints amounts
            // Calculates the price with CalculatePrice-function in MovieDesk class
            Console.WriteLine($"\nYou are {amount} in your company");
            Console.WriteLine($"Total Price is: {desk.CalculatePrice()}");

            GoBackToMenu();
        }

        private static void WordLooping()
        {
            // Info
            Console.Clear();
            Console.WriteLine("Loop Your Words");
            Console.WriteLine("Type a sentence that gets repeated 10 times!\n");

            // Stores user input in string input
            // Create variable for number of repeats
            string input = Console.ReadLine();
            int numOfRepeats = 10;

            // Repeats the user's input
            for (int i = 0; i < numOfRepeats; i++)
            {
                // Output: Number || User Input
                Console.Write($"{(i + 1)}. {input} ");
            }

            GoBackToMenu();
        }

        private static void GoBackToMenu()
        {
            Console.WriteLine($"\n¤¤ Press ENTER to return to Menu ¤¤");
        }

        private static void ErrorMessage()
        {
            Console.WriteLine("Invalid data!");
        }


    }
}
