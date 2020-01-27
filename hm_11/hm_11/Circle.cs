using System;
using System.Collections.Generic;
using System.Text;

namespace hm_11
{
    class Circle : BaseClass
    {
        public void CircleArea(double radius)
        {
            area = PI * Math.Pow(radius, 2);
            Console.WriteLine($"This is circle. CLR type is circle. Square is {area}");
        }
    }
}
