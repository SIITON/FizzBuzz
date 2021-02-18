using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
{
    public class Game
    {
        CheatSheet cheatsheet = new CheatSheet();
        public int turn;
        public bool userIsCorrect;
        public Game()
        {
            turn = 1;
            userIsCorrect = true;
            cheatsheet.InitFizzBuzzSheet();
        }
        
        public void ComputersTurn()
        {
            Console.WriteLine($"\t{cheatsheet.Check(turn)}");
            turn++;
        }

        public void TestIfUserIsCorrect(string input)
        {
            
            try
            {
                userIsCorrect = cheatsheet.Check(input, turn);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex);
                userIsCorrect = false;
            }
            finally
            {
                turn++;
            }
        }
    }
}
