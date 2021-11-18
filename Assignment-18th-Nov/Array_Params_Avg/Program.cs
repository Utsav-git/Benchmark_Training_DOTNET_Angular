using System;

namespace Array_Params_Avg
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine(p.Average(1,2,3,4));
        }
        public double Average(params double[] marks) {
            double sum = 0;
            double avg = 0;

            foreach(double m in marks)
            {
                sum = sum + m;    
            }
            avg = sum / marks.Length;
            return avg;

        }
    }
}
