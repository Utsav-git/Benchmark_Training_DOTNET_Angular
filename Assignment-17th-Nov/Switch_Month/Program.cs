using System;

namespace Switch_Month
{
    class Program
    {
        static void Main(string[] args)
        {
            int month_number;
            Console.WriteLine("Enter number: ");
            month_number = Convert.ToInt32(Console.ReadLine());

            switch (month_number) {
                case 1:
                    Console.WriteLine("January -> 31 days");
                    break;
                case 2:
                    Console.WriteLine("February-> 28 / 29 days");
                    break;
                case 3:
                    Console.WriteLine("March -> 31 days");
                    break;
                case 4:
                    Console.WriteLine("April -> 30 days");
                    break;
                case 5:
                    Console.WriteLine("May -> 31 days");
                    break;
                case 6:
                    Console.WriteLine("June -> 30 days");
                    break;
                case 7:
                    Console.WriteLine("July -> 31 days");
                    break;
                case 8:
                    Console.WriteLine("August-> 31 days");
                    break;
                case 9:
                    Console.WriteLine("September -> 30 days");
                    break;
                case 10:
                    Console.WriteLine("October -> 31 days");
                    break;
                case 11:
                    Console.WriteLine("November -> 30 days");
                    break;
                case 12:
                    Console.WriteLine("December -> 31 days");
                    break;
                default:
                    Console.WriteLine("Invalid...Enter number between 1 to 12");
                    break;
            }
        }
    }
}
