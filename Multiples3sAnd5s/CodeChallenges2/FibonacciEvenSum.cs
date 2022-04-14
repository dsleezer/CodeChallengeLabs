namespace CodeChallenges2
{
    class FibonacciEvenSum
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Fibonacci Even Sum");

            int count = 2;



            int one = 1;
            int two = 1;
            int three = 0;

            while (three <= 4000000)
            {
                //three = one + two;
                //one = two;
                //two = three;

                Console.WriteLine(three);
                if (three % 2 == 0)
                {
                    count = three + count;
                }
                three = one + two;
                one = two;
                two = three;

            }; 

            Console.WriteLine();
            Console.WriteLine(count);



        }
    }
}