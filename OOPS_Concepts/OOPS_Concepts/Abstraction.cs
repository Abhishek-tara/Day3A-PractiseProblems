using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concepts
{
    public abstract class Abstractionclass
    {
        public abstract void AbstractMethod();
        public void NormalMethod()
        {
            Console.WriteLine("Normal Method");
        }
    }
    public class Child : Abstractionclass
    {
        public override void AbstractMethod()
        {
            Console.WriteLine("This is a abstract method");
        }
    }
}
