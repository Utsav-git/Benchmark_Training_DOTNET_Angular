using System;

namespace _3_UserDefined_GenericClass_Demo
{
    class Program
    {
        public static void swap<T>(ref T a, ref T b) {
            T temp;
            temp = a;
            a = b;
            b = temp;
        }
        static void Main(string[] args)
        {
            int a = 10, b = 20;
            char c1 = 'a', c2 = 'b';
            double d1 = 1.23, d2 = 2.223;

            Console.WriteLine("Before Swapping: \n"+ a+ " "+b);

            Console.WriteLine("After Swapping: ");
            swap(ref a, ref b);
            Console.WriteLine(a + " " + b);
            Console.WriteLine("-----------------------------------");

            Console.WriteLine("Before Swapping: \n" + c1 + " " + c2);

            Console.WriteLine("After Swapping: ");
            swap(ref c1, ref c2);
            Console.WriteLine(c1 + " " + c2);
            Console.WriteLine("-----------------------------------");

            Console.WriteLine("Before Swapping: \n" + d1 + " " + d2);

            Console.WriteLine("After Swapping: ");
            swap(ref d1, ref d2);
            Console.WriteLine(d1 + " " + d2);
            Console.WriteLine("-----------------------------------");
        }
    }
}
