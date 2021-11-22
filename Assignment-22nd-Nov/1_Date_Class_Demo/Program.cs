using System;

namespace _1_Date_Class_Demo
{
    class Date {
        int day, month, year;

        public Date(int d, int m, int y) {
            day = d;
            month = m;
            year = y;
        }
        public override string ToString()
        {
            return day + " - " + month + " - " + year;
        }
        public override bool Equals(object obj)
        {
            Date de = null;
            if(obj.GetType() == typeof(Date))
            {
                de = (Date)obj;
            }
            else
            {
                Console.WriteLine("Object is not of Date Class");
            }

            if(day == de.day && month == de.month && year == de.year)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Date de = new Date(13, 10, 2000);
            Date de1 = new Date(3, 10, 2000);
            
            Console.WriteLine("Date : "+de.ToString());
            Console.WriteLine(Object.Equals(de, de1));
            

        }
    }
}
