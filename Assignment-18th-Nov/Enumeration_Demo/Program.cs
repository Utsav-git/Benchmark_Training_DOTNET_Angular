using System;

namespace Enumeration_Demo
{
    enum Days
    {
        Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday
    }
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.display_Day(Days.Tuesday);
            p.display_Day(Days.Saturday);
            p.display_Day(Days.Friday);
        }
        public void display_Day(Days d)
        {
            Console.WriteLine(d);
        }
    }
}
