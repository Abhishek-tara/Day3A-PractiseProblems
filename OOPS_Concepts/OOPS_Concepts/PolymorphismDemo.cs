using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concepts
{
    public class PolymorphismDemo
    {
        public void SnakeSound()
        {
            Console.WriteLine("sssssssshh");
        }
    }

    public class Dog : PolymorphismDemo
    {
        public void SnakeSound()
        {
            Console.WriteLine("Bow Bow");
        }
    }
}
