using System;
using System.Collections.Generic;

namespace _2_Generic_Collection_Employee_Demo
{
    class Employee
    {
        public int emp_Id;
        public string emp_Name;

        public Employee(int em_id, string em_nm)
        {
            this.emp_Id = em_id;
            this.emp_Name = em_nm;
        }

    }
    class Program
    {
       
        static void Main(string[] args)
        {
            List<Employee> e = new List<Employee>();

            

            Console.WriteLine("******* Enter Details *******");
            for(int i = 0; i < 5; i++) {
                Console.WriteLine("Enter ID and Name: ");
                int id = Convert.ToInt32(Console.ReadLine());
                string nm = Console.ReadLine();

                Employee e1 = new Employee(id, nm);
                e.Add(e1);
            }


            Console.WriteLine("******* Employee Details *******");
            Console.WriteLine("Employee ID "+" Employee Name");
            for(int i = 0; i < e.Count; i++)
            {
                Employee e1 =  e[i];
                Console.WriteLine(e1.emp_Id+"\t\t"+e1.emp_Name);
            }
        }
    }
}
