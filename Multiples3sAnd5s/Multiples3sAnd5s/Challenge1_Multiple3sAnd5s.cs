namespace Multiple3And5s
{
    class Challenge1_Multiple3sAnd5s
    {
        static void Main(string[] args)
        {

            int count3 = 0;
            int count5 = 0;

            for (int i = 0; i < 10; i += 3)
            {
                Console.WriteLine(i);
                count3 += i;
            }
            Console.WriteLine(count3);
            for (int i = 0; i < 10; i += 5)
            {
                Console.WriteLine(i);
                count5 += i;
            }
            Console.WriteLine(count5);
            Console.WriteLine(count3 + count5);

            int count31k = 0;
            int count51k = 0;
            for (int i = 0; i < 1000; i += 3)
            {
                count31k += i;
            }
            for (int i = 0; i < 1000; i += 5)
            {
                count51k += i;
            }
            Console.WriteLine(count31k + count51k);
        }
    }
}