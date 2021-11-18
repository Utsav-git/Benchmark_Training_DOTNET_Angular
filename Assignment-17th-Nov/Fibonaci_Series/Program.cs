using System;

namespace Fibonaci_Series
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, a = 0, b = 1;
            Console.WriteLine("Enter value of n: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Fibonacci Series -> ");
            Console.WriteLine(a);
            Console.WriteLine(b);

            for (int i = 1; i < n; i++)
            {
                int sum= a + b;
                Console.WriteLine(sum);

                a = b;
                b = sum;
            }
        }
    }
}
