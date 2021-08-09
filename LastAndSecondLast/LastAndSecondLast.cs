using System;
using System.Linq;

namespace LastAndSecondLast
{
    class LastAndSecondLast
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            if (word.Length >= 2 && word.Length <= 100)
            {
                Console.WriteLine(LastLetters(word));
            }
            else
            {
                throw new ArgumentException("Word must be with length in the range [2; 100].");
            }
        }
        static string LastLetters(string word)
        {
            char[] lastLetters = word.ToCharArray().TakeLast(2).Reverse().ToArray();

            return string.Join(" ", lastLetters);
        }
    }
}
