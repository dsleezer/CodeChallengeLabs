using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges2
{
    internal class TenDigitFibonacci
    {
        static void Main(string[] args)
        {
            int one = 1;
            int two = 1;
            int three = 1;

            List<int> numbers = new List<int>();
            numbers.Add(one);
            numbers.Add(two);
            do
            {
                //three = one + two;
                //one = two;
                //two = three;

                Console.WriteLine(three);
                three = one + two;
                one = two;
                two = three;
                numbers.Add(three);

            } while (three.ToString().Length < 10);
            Console.WriteLine(numbers.Count - 1);
            Console.WriteLine(numbers[44]);
            Console.WriteLine(numbers.IndexOf(three));
        }
    }
}
