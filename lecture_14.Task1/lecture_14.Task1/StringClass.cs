using System;
using System.Collections.Generic;
using System.Text;

namespace lecture_14.Task1
{
    class StringClass
    {
        string text = "12345abdfiehfilhief";
        public void TextMethod()
        {
            text = text.Substring(0, 5) + "...";
            Console.WriteLine(text);
        }
    }
}
