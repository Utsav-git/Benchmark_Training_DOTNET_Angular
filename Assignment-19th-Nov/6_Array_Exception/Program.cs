using System;

namespace _6_Array_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];

            try {
                arr[6] = 10;
            }
            catch (IndexOutOfRangeException e) {
                Console.WriteLine("Exception: " + e.Message);
            }

        }
    }
}
