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

        //public static int opStr()
        //{
        //    if (a == 17 && b == 4)
        //    {
        //        return stringNum;
        //    }
        //}

    }
}

//int a = 17;
//int b = 4;
//int quotient = b;
//int remainder = a % b;
