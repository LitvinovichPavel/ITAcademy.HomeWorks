using System;
using System.Collections.Generic;
using System.Text;

namespace hm_8.Task2
{
    class Employee
    {
        private const byte hoursWeek = 40;          //кол-во рабочих часов в неделе
        public byte day = 22;                       //кол-во рабочих дней в неделе
        private byte salaryHours = 1;               //оплата часа труда
        public byte age;                            //возраст сотрудника
        public string education;                    //образование
        private int salaryBase;                     //базовый оклад
        private byte product;                       //кол-во произведенной продукции сотрудником за день
        private int productPrice;                   //цена за единицу продукта
        private double salary;                      //зароботная плата
        private const double percent = 0.2;        //процент от продаж
        public Employee()
        {
            age = 30;
            education = "higher education";
            salaryBase = 200;
            product = 10;
            productPrice = 20;
        }
        public void Money()
        {
            salary = salaryBase + (hoursWeek * day * salaryHours) + (product * productPrice * percent * day);
            Console.WriteLine($"Возраст: {age} лет, образование: {education}.");
            Console.WriteLine($"Зарплата: {salary}$ в месяц.");
        }
    }
}
