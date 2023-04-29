using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concepts
{
    public class Object
    {
        public string name { get; set; }
        public int age;
        public void Display()
        {
            Console.WriteLine(name);
            Console.WriteLine(age);
        }
    }
}
