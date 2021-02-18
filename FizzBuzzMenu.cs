using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
{
    class FizzBuzzMenu
    {

        public static void StartGameOrSheet(string userInput)
        {
            try
            {
                if (userInput == "play")
                {
                    while (true)
                    {
                        StartGame();
                    }
                }
                else if (userInput == "cheatsheet")
                {
                    while (true)
                    {
                        StartCheatSheet();
                    }
                }
                else
                {
                    throw new ArgumentException("Invalid input, try again!");
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex);
            }
            catch (NotImplementedException ex)
            {
                Console.WriteLine(ex);
            }

        }

        public static void StartCheatSheet()
        {
            var cheatsheet = new CheatSheet();
            cheatsheet.InitFizzBuzzSheet();

            while (true)
            {
                Console.WriteLine("What number is troubling you?");
                try
                {
                    var numberToCheck = int.Parse(Console.ReadLine());
                    if (numberToCheck <= 0)
                    {
                        throw new FormatException();
                    }

                    Console.WriteLine($"You say: {cheatsheet.Check(numberToCheck)}");
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Only positive integers are allowed as input, try again!");
                }
            }
        }

        private static void StartGame()
        {
            var game = new Game();
            Console.WriteLine("Let's play, I start:");
            while (game.userIsCorrect)
            {
                game.ComputersTurn();

                var input = Console.ReadLine();
                game.TestIfUserIsCorrect(input);
            }
            Console.WriteLine($"You lost! You got to number {game.turn - 1}");
        }
    }
}
