using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concepts
{
    public class ValueAndReferenceType
    {
        //Value Type
        public void Method(int first, int second)
        {
            Console.WriteLine($"Sum : {first + second}");
        }

        //Reference Type  
        public void Method_One(ref int first,ref int second)
        {
            Console.WriteLine($"Reference Sum : {first + second}");
        }
    }
}
