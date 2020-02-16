using System;
using System.Collections.Generic;
using System.Text;

namespace hm_11
{
    class Square : BaseClass
    {
        private double Side { get; set; }
        public Square(string name, double side) : base(name)
        {
            Side = side;
        }
        public override double Area()
        {
            return Math.Pow(Side, 2);
        }
    }
}
