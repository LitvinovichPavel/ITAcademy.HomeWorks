using System;
using System.Collections.Generic;
using System.Text;

namespace hm_10
{
    public class Person
    {
        public string Name;
        public int Age;
        public string Info;

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            Info = $"{Name}s age is {Age}";
        }
    }
}
