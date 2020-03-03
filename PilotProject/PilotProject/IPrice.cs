using System;
using System.Collections.Generic;
using System.Text;

namespace PilotProject
{
    public interface IPrice
    {
        public void Question();         //метод для перечисляем продукции, емкости (массы) и цены.
        public double PriceProduct();   //расчет цены продукта по категориям (напитки, сеты, маки)
    }
}
