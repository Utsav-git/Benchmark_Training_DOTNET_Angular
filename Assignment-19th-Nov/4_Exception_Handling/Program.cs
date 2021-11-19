using System;

namespace _4_Exception_Handling
{

    class Program
    {
        public void divide()
        {
            int a, b;
            Console.WriteLine("Enter 2 numbers: ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            try
            {
                Console.WriteLine(a / b);
            }
            catch (DivideByZeroException e) {
                Console.WriteLine("Exception: " + e.Message);
            }
            
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.divide();
        }
    }
}
