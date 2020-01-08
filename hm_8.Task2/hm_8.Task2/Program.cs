using System;

namespace AssemblyTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Man man = new Man();
            man.ManMethod();

            Boy boy = new Boy();
            boy.BoyMethod();

            Women women = new Women();
            women.WomenMethod();

            Girl girl = new Girl();
            girl.GirlMethod();
        }
    }
    class Women
    {
        protected int ageWomen = 50;
        public void WomenMethod()
        {
            Console.WriteLine($"{ageWomen} years old women");
        }
    }
    class Man
    {
        protected byte ageMan = 50;
        public void ManMethod()
        {
            Console.WriteLine($"{ageMan} years old man");
        }
    }
    class Girl : Women
    {
        public void GirlMethod()
        {
            int ageGirl;
            ageGirl = ageWomen - 40;
            Console.WriteLine($"{ageGirl} years old girl");
        }
    }
    class Boy : Man
    {
        public void BoyMethod()
        {
            int ageBoy;
            ageBoy = ageMan - 40;
            Console.WriteLine($"{ageBoy} years old boy");
        }
    }
}