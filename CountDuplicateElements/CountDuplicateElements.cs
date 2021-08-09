using System;
using System.Collections.Generic;
using System.Linq;

namespace CountDuplicateElements
{
    class CountDuplicateElements
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            if (size >= 3 && size <= 1000)
            {
                Dictionary<int, int> dict = new Dictionary<int, int>();

                for (int i = 0; i < size; i++)
                {
                    int number = int.Parse(Console.ReadLine());
                    if (number >= 1 && number <= 1000)
                    {
                        dict.TryGetValue(number, out int count);
                        dict[number] = count + 1;
                    }
                    else
                    {
                        throw new ArgumentException("Array value must be in the range [1; 1000].");
                    }
                }
                Console.WriteLine(CountDuplicate(dict));
            }
            else
            {
                throw new ArgumentException("Array size must be in the range [3; 1000].");
            }
        }
        static int CountDuplicate(Dictionary<int, int> dict)
        {
            return dict.Count(d => d.Value > 1);
        }
    }

}
