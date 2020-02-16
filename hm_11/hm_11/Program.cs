using System;

namespace hm_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            BaseClass[] arrayBase = new BaseClass[3];

            arrayBase[0] = new Square("Square", random.Next(1, 10));
            arrayBase[1] = new Triangle("Triangle", random.Next(1, 10), random.Next(1, 10));
            arrayBase[2] = new Circle("Circle", random.Next(1, 10));

            Info(arrayBase);
        }
        public static void Info(BaseClass[] arrayBase)
        {
            foreach (var item in arrayBase)
            {
                Console.WriteLine($"This is {item.Name}. CLR Type is {item.GetType()}. " +
                                  $"Square is {item.Area()}");
            }
        }
    }
}
