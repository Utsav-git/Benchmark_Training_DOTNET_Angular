using System;

namespace Employee_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.getEmployeeData();
            e.displayEmployeeData();
            
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
            Console.WriteLine("\nEmployee Number: "+empNo+"\nEmployee Name: "+empName+"\nEmployee Designation: "+designation+"\nSalary: "+salary);
        }

    }
}
