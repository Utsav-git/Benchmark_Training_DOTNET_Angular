using System;

namespace Employee_Array_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] e = new Employee[10];
            Console.WriteLine("Enter Data: ");
            for (int i = 0; i < e.Length; i++)
            {
                e[i] = new Employee();
                e[i].getEmployeeData();

            }

            Console.WriteLine("Display Data: ");
            for (int i = 0; i < e.Length; i++)
            {
                e[i].displayEmployeeData();
            }
        }
    }
    class Employee
    {
        int empNo;
        String empName, designation;
        long salary;

        public void getEmployeeData()
        {
            Console.WriteLine("Enter Employee Number: ");
            empNo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Employee Name: ");
            empName = Console.ReadLine();

            Console.WriteLine("Enter Employee Designation: ");
            designation = Console.ReadLine();

            Console.WriteLine("Enter Employee Salary: ");
            salary = Convert.ToInt64(Console.ReadLine());
        }

        public void displayEmployeeData()
        {
            Console.WriteLine("Employee Number: " + empNo + "\tEmployee Name: " + empName + "\tEmployee Designation: " + designation + "\tSalary: " + salary);
        }

    }
}
