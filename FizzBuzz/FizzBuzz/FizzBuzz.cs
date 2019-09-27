using System;

namespace FizzBuzz
{
    public class FizzBuzzStarter
    {
        public static object FizzBuzz(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
            {
                return "FizzBuzz";
            }

            else if (number % 3 == 0)
            {
                return "Fizz";
            }
            else if (number % 5 == 0)
            {
                return "Buzz";
            }
            else
            {
                return number;
            }
        }

        static void Main(string[] args)
        {
            
        }
    }
}
