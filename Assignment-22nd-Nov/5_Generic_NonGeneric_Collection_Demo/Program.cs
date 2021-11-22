using System;
using System.Collections;

namespace _5_Generic_NonGeneric_Collection_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable h = new Hashtable();
            h.Add(1,"A");
            h.Add(2, "B");

            foreach (DictionaryEntry d in h) {
                Console.WriteLine("Student Roll: "+d.Key+ " Student Name: "+d.Value);
            }
        }
    }
}
