using System;
using System.Collections.Generic;
using System.Text;

namespace hm_11
{
    class BaseClass
    {
        internal const double PI = 3.14159;
        internal double area;
        internal double side;
        internal double bisector;
        internal double radius;
        public double Side { get; set; }   //properties
        public double Bisector
        {
            get
            {
                if (bisector < side)
                {
                    return bisector;
                }
                else
                    return 0;
            }
            set
            {
                bisector = value;
            }
        }          //properties
        public double Radius { get; set; } //properties

        public object[] Figures()
        {
            Square square = new Square();
            square.SquareArea(10);

            Triangle triangle = new Triangle();
            triangle.TriangleArea(7, 10);

            Circle circle = new Circle();
            circle.CircleArea(10);

            object[] figure = { square, triangle, circle };
            return figure;
        }
    }
}
