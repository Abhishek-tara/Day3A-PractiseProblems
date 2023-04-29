using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concepts
{
    public class MethodOverloading
    {
        public void Method()
        {
            int numOne = 20;
            int numTwo = 30;
            Console.WriteLine($"The sum of {numOne} + {numTwo} is: {numOne + numTwo}");
        }
        public void Method(int a, int b)
        {
            Console.WriteLine($"The product of {a} * {b} is: {a * b}");
        }

    }
}
