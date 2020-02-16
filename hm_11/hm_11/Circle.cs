using System;
using System.Collections.Generic;
using System.Text;

namespace hm_11
{
    class Circle : BaseClass
    {
        private double Radius { get; set; }
        public Circle(string name, double radius) : base(name)
        {
            Radius = radius;
        }
        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
