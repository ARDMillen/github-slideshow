using System;

namespace ProjectEuler1
{
    class Program
    {
        static void Main(string[] args)
        {
            int intSum = 0;

            for (int i = 1; i<=1000; i+=3)
            {
                intSum+=i;
            };

            for (int i = 1; i<=1000; i+=5)
            {
                intSum+=i;
            };

            Console.WriteLine("Sum of 3s and 5s = {0}", intSum);

            Console.Write("\nPress any key to exit...");
            Console.ReadKey(true);
        }
    }
}
