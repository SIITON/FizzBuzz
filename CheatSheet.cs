using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
{
    public class CheatSheet
    {
        protected Dictionary<int, string> _cheatsheet = new Dictionary<int, string>();

        int _capacity;
        public CheatSheet()
        {
            Console.WriteLine("Cheatsheet initiated");
        }
        public void InitFizzBuzzSheet(int capacity = 100)
        {
            _capacity += capacity;
            AddFizzBuzzToSheet();
        }

        public void AddFizzBuzzToSheet()
        {
            for (int i = 1; i < _capacity; i++)
            {
                if (!_cheatsheet.ContainsKey(i))
                {
                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        _cheatsheet.Add(i, "FizzBuzz");
                    }
                    else if (i % 3 == 0)
                    {
                        _cheatsheet.Add(i, "Fizz");
                    }
                    else if (i % 5 == 0)
                    {
                        _cheatsheet.Add(i, "Buzz");
                    }
                    else
                    {
                        _cheatsheet.Add(i, $"{i}");
                    }
                }
            }
        }
        public string Check(int input)
        {
            IncreaseCapacityToInclude(input);
            return _cheatsheet[input];
        }

        public bool Check(string input, int key)
        {
            IncreaseCapacityToInclude(key);
            var correctAnswer = _cheatsheet[key];
            return input == correctAnswer;
        }
        public int GetCountOfValues()
        {
            return _cheatsheet.Values.Count;        
        }
        public void IncreaseCapacityToInclude(int key)
        {
            if (key >= _capacity)
            {
                _capacity += key;
                AddFizzBuzzToSheet();
            }
        }
    }
}
