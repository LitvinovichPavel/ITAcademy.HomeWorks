using System;
using System.Collections.Generic;
using System.Text;

namespace hm_11
{
    abstract class BaseClass
    {
        public string Name { get; set; }
        public BaseClass(string name)
        {
            Name = name;
        }
        public abstract double Area();
    }
}
