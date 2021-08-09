using System;
using System.Text;

namespace FizzBuzz
{
    class FizzBuzz
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            if (number > 0 && number < 200000)
            {
                for (int i = 1; i <= number; i++)
                {
                    Console.WriteLine(IsFizzBuzz(i));
                }
            }
            else
            {
                throw new ArgumentException("Input must be in the range (0; 200 000).");
            }
        }
        static string IsFizzBuzz(int number)
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

            return $"{number}";

        }

    }
}
