using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz.Linq
{
    public static class MyLinq
    {
        public static bool IsFizz<T>(this int number)
        {
            bool result = false;
            if (number % 3 == 0)
            {
                result = true;
            }
            return result;
        }
        public static bool IsBuzz<T>(this int number)
        {
            bool result = false;
            if (number % 5 == 0)
            {
                result = true;
            }
            return result;
        }
    }
}
