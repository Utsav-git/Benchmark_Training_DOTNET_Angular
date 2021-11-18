using System;

namespace Operator_Overloading_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(80);
            Student s2 = new Student(80);

            Student add = s1 + s2;
            add.printMarks();

            Student sub = s1 - s2;
            sub.printMarks();

            Student mult = s1 * s2;
            mult.printMarks();
            
            Student div = s1 / s2;
            div.printMarks();

            if (s1 == s2)
            {
                Console.WriteLine("Marks are same.");
            }
            else
            {
                Console.WriteLine("Marks are not same.");
            }

        }
    }
    class Student
    {
        int marks;

        public Student(int m)
        {
            marks = m;
        }

        public static Student operator +(Student a, Student b)
        {
            Student res = new Student(0);
            res.marks = a.marks + b.marks;
            return res;
        }

        public static Student operator -(Student a, Student b) {
            Student res = new Student(0);
            res.marks = a.marks - b.marks;
            return res;
        }

        public static Student operator *(Student a, Student b)
        {
            Student res = new Student(0);
            res.marks = a.marks * b.marks;
            return res;
        }

        public static Student operator /(Student a, Student b) 
        {
            Student res = new Student(0);
            res.marks = a.marks / b.marks;
            return res;
        }
        public static bool operator ==(Student a, Student b) 
        { 
            if(a.marks == b.marks)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Student a, Student b) 
        { 
            if(a.marks != b.marks)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void printMarks()
        {
            Console.WriteLine(marks);
        }
    }

}
