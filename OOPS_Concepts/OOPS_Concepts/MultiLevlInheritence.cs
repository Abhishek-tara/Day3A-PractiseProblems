﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concepts
{
    public class MultiLevlInheritence
    {
        public void Method()
        {
            Console.WriteLine("Multilevel inheritence");
        }
    }
    public class ChildOne : MultiLevlInheritence
    {
    }
    public class Sibling : ChildOne
    {
    }
}
