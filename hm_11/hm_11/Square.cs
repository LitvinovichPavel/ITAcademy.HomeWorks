using System;
using System.Collections.Generic;
using System.Text;

namespace hm_11
{
    class Square : BaseClass
    {
        public void SquareArea(double side)
        {
            area = Math.Pow(side, 2);
            Console.WriteLine($"This is square. CLR type is square. Square is {area}");
        }
    }
}
