using System;

namespace Inheritance_Employee_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Permanent_Employee e1 = new Permanent_Employee(1, "John", "Developer", 10000);
            Waged_Employee e2 = new Waged_Employee(2, "Shawn", "SalesPerson", 20, 500);

            Console.WriteLine("Permanent Employee: ");
            e1.printData();
            
            Console.WriteLine("Waged Employee: ");
            e2.printData();
        }
    }
    class Employee
    {
        private int empNo;
        private String empName, designation;
        public Employee(int empNo, String empName, String designation)
        {
            this.empNo = empNo;
            this.empName = empName;
            this.designation = designation;
        }
        public void printData()
        {
            Console.WriteLine(empNo+" "+empName+" "+designation);
        }

    }
    class Permanent_Employee : Employee 
    {
        double base_salary, hra, da;
        public Permanent_Employee(int empNo, String empName, String designation, double base_salary):base(empNo, empName, designation)
        {
            this.base_salary = base_salary;
        }
        public void printData()
        {
            base.printData();
            Console.WriteLine(base_salary);

            hra = 0.5 * base_salary;
            da = 0.3 * base_salary;

            Console.WriteLine("Permanent Employee Gross Salary: "+(base_salary + hra + da));
        }

    }
    class Waged_Employee : Employee
    {
        double noOfHours, hourlyAmount;
        public Waged_Employee(int empNo, String empName, String designation, double noOfHours, double hourlyAmount) : base(empNo, empName, designation)
        {
            this.noOfHours= noOfHours;
            this.hourlyAmount = hourlyAmount;
        }
        public void printData()
        {
            base.printData();
            Console.WriteLine(noOfHours);
            Console.WriteLine(hourlyAmount);
            Console.WriteLine("Waged Employee Gross Salary: "+(noOfHours * hourlyAmount));
            
        }

    }
}
