using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concepts
{
    public class TypesOFMethod
    {
        //Method Without Parameter.
        public void Method()
        {
            string firstName = "Bruce";
            string secondName = "Wayne";
            Console.WriteLine($"Full Name : {firstName + " " + secondName}");
        }
        //Method With Parameter.
        public void Method_One(string firstName, string secondName)
        {
            Console.WriteLine($"Full Name : {firstName} {secondName}");
        }
        //Method With Return Type.
        public string Method_Two(string firstName, string secondName)
        {
            return "Full Name : " + firstName + " " + secondName;
        }
    }
}
