using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to FizzBuzz!");
            Console.WriteLine("Type 'play' or 'cheatsheet' to start");
            while (true)
            {
                var userInput = Console.ReadLine();
                FizzBuzzMenu.StartGameOrSheet(userInput);
            }
        }    
    }
}
