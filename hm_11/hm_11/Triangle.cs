using System;
using System.Collections.Generic;
using System.Text;

namespace hm_11
{
    class Triangle : BaseClass
    {
        public void TriangleArea(double bisector, double side)
        {
            area = (side * bisector) / 2;
            Console.WriteLine($"This is triangle. CLR type is triangle. Square is {area}");
        }
    }
}
