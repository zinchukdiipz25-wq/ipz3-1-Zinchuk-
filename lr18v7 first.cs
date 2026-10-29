using System;

namespace Lab18
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 1.5, y = 0.1, z = 0.5;

            double a = Math.Log10(Math.Abs(Math.Sin(x) + y)) / 87;
            double b = 234 / Math.Log10(Math.Abs(Math.Sin(x * y) + 3));
            double c = Math.Log10(Math.Abs(Math.Sin(3.1) + x * x * y)) / z;

            double S = a + b + c;

            Console.WriteLine("x = " + x + ", y = " + y + ", z = " + z);
            Console.WriteLine("S = " + S);

            Console.ReadKey();
        }
    }
}
