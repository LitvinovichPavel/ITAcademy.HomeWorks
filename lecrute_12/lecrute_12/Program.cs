using System;

namespace lecrute_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle();
            Circle circle = new Circle();
            Square square = new Square();

            Console.WriteLine($"This is triabgle. CLR Type is {}. Square is {triangle.TriangleArea()}");
            Console.WriteLine($"This is circle. CLR Type is {}. Square is {circle.SircleArea}");
            Console.WriteLine($"This is {}. CLR Type is {}. Square is {}");
        }
    }
}
