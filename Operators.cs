using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorExercise
{
    internal class Operators
    {

        public static int OperatorStringAdd(int a, int b)
        {
            //Exercise 1:
            return a += b;

        }
        public static int OperatorStringSubstarct(int a, int b)
        {
            return a -= b;

        }
        public static int OperatorStringDivide(int a, int b)
        {
            return a /= b;

        }

        public static int OperatorStringMultiply(int a, int b)
        {
            return a *= b;

        }
        public static int OperatorStringModulus(int a, int b)
        {
            return a %= b;
        }


        //Exercise 2:
        public static void AreaOfCircle()
        {
            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());
            double area =  Math.PI * radius * radius;
            Console.WriteLine($"THe area of circle with radius of {radius} is {area}");
        }

  

    }

   
}

