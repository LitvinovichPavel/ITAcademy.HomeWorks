using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PilotProject
{
    class TestBeverages
    {
        public string Title { get; set; }
        public double Price { get; set; }
        public double Volume { get; set; }
        public TestBeverages(double price)
        {
            Price = price;
        }
        public TestBeverages(string title, double price, double volume)
        {
            Title = title;
            Price = price;
            Volume = volume;
        }
    }
    class ClassClassich
    {
        public void MethodClassClassich()
        {
            List<TestBeverages> tovari = new List<TestBeverages> { };
            tovari.Add(new TestBeverages(2.0));
            tovari.Add(new TestBeverages(2.0));
            tovari.Add(new TestBeverages(0.5));

            foreach (TestBeverages i in tovari)
            {
                Console.WriteLine($"PRICE: {i}");
            }
        }
    }
}
