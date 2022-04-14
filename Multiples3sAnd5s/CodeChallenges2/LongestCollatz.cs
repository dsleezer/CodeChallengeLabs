using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges2
{
    internal class LongestCollatz
    {
        static void Main(string[] args)
        {
            int n = 1;
            int number = 1;

            int highestCount = 0;
            int longestNumber = 0;
            do
            {
                List<int> numbers = new List<int>();
                Console.WriteLine("Starting at " + n);
                numbers.Add(n);
                while (numbers.Last() > 1)
                {
                    if (n % 2 == 0)
                    {
                        n /= 2;
                        numbers.Add(n);
                    }
                    else
                    {
                        n = 3 * n + 1;
                        numbers.Add(n);
                    }
                }
                if (numbers.Count > highestCount)
                {
                    highestCount = numbers.Count;
                    longestNumber = number;
                }
                Console.WriteLine("Total numbers in chain: " + highestCount);
                Console.WriteLine("starting number " + longestNumber);
                number++;
                n = number;
            } while (n < 1000);
            Console.WriteLine($"The number {longestNumber} has the highest collatz at {highestCount}");
        }
    }
}
