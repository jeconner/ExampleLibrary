using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleLibrary
{
    public class MathClass
    {
        public static int Factorial(int num)
        {
            if (num < 2) return num;
            return num * Factorial(num - 1);
        }
    }
}

