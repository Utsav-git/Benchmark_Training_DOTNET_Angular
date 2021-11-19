using System;

namespace _3_Interface
{
    interface IPrintable
    {
        void print();
    }
    class Account: IPrintable
    {
        public void print() {
            Console.WriteLine("Accounts prints.");
        }
    }
    class Employee: IPrintable
    {
        public void print()
        {
            Console.WriteLine("Employee Prints");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Account a = new Account();
            a.print();

            Employee e = new Employee();
            e.print();
        }
    }
}
