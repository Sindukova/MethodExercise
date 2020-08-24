using System;
using System.Reflection.Metadata.Ecma335;

namespace OperatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
             int a;
             int b;
             int quotient;
             int remainder;

            a = 17;
            b = 4;

            quotient = a / b;
            remainder = a % b;

            Console.WriteLine($"Quotient is : {quotient}");
            Console.WriteLine($"Remainder is: {remainder}");

            Console.WriteLine("What is the radius of the circle?");
            var radius = double.Parse(Console.ReadLine());
            var result = AreaOfCicle(radius);
            Console.WriteLine($"The area of the circle with the radius of {radius} is {result}");

        }
        public static double AreaOfCicle(double radius)
        {
            var pi = 3.14159265359;
            double r;
            r = radius;
            double area = pi * r *r;
            return area;

        }
        
    }
}
