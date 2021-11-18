using System;

namespace _4_Properties_Class_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.employee_Number = 1;
            e.Salary = 12000;

            Console.WriteLine("Employee Number: "+e.employee_Number+"\nEmployee Salary: "+e.Salary);
        }
    }
    class Employee
    {
        int empNo;
        String empName, designation;
        long salary;

        public int employee_Number
        {
            set
            {
                empNo = value;
            }
            get
            {
                return empNo;
            }
        }
        public long Salary
        {
            set
            {
                salary = value;
            }
            get
            {
                return salary;
            }
        }

    }
}
