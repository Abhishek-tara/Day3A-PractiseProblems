using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concepts
{
    public class MethodOverRide
    {
        public virtual void Method()
        {
            int numOne = 20;
            int numTwo = 30;
            Console.WriteLine($"The sum of {numOne} + {numTwo} is: {numOne + numTwo}");
        }
    }
    public class Derived : MethodOverRide
    {
        public override void Method()
        {
            int numOne = 20;
            int numTwo = 30;
            Console.WriteLine($"The product of {numOne} * {numTwo} is: {numOne * numTwo}");
        }
    }
}
