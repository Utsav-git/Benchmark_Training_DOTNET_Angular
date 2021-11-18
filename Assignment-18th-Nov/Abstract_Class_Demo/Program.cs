using System;

namespace Abstract_Class_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Herbivorous h = new Herbivorous();
            h.food_habits();

            Carnivores c = new Carnivores();
            c.food_habits();
        }
    }
    
    abstract class Animal {
        public abstract void food_habits();
    }

    class Herbivorous: Animal
    {
        public override void food_habits()
        {
            Console.WriteLine("Herbivores eat plants.");
        }
    }

    class Carnivores: Animal
    {
        public override void food_habits()
        {
            Console.WriteLine("Carnivores eat meat.");
        }
    }
}
