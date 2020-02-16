using System;
using System.Collections.Generic;
using System.Text;

namespace hm_11
{
    class Triangle : BaseClass
    {
        private double Side { get; set; }
        private double Height { get; set; }
        public Triangle(string name, double side, double height) : base(name)
        {
            Side = side;
            Height = height;
        }
        public override double Area()
        {
            return (Side * Height) / 2;
        }
    }
}
