﻿using System;
using System.Text.Json;
using Newtonsoft.Json;

namespace PilotProject
{
    class Program
    {
        static void Main(string[] args)
        {
            BeveragesAll beveragesAll = new BeveragesAll();
            beveragesAll.PriceProduct();
        }
    }
}
