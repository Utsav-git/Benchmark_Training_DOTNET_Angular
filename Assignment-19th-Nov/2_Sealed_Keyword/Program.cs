using System;

namespace _2_Sealed_Keyword
{
   class Parent
   {
        public virtual void parent_method() {
            Console.WriteLine("Parent Class Sealed Method");
        }
   }
    class Child: Parent
    {
        public sealed override void parent_method()
        {
            base.parent_method();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
