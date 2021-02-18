using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
{
    public static class Extensions
    {

        public static bool IsFizz<T>(int number)
        {
            bool result = false;
            if (number % 3 == 0)
            {
                result = true;
            }
            return result;
        }
        public static bool IsBuzz<T>(int number)
        {
            bool result = false;
            if (number % 5 == 0)
            {
                result = true;
            }
            return result;
        }
        public static T WithRetry<T>(this Func<T> action)
        {
            var result = default(T);
            int retryCount = 0;

            bool succesful = false;
            do
            {
                try
                {
                    result = action();
                    succesful = true;
                }
                catch (ArgumentException ex)
                {
                    retryCount++;
                }
            } while (retryCount < 3 && !succesful);

            return result;
        }

        // Partial application
        public static Func<TResult> Partial<TParam1, TResult>(
            this Func<TParam1, TResult> func, TParam1 parameter)
        {
            return () => func(parameter);
        }

        // Currying
        //Func<string, Func<string>> functionName = thing.Curry();
        public static Func<TParam1, Func<TResult>> Curry<TParam1, TResult>
            (this Func<TParam1, TResult> func)
        {
            return parameter => () => func(parameter);
        }
    }
}
