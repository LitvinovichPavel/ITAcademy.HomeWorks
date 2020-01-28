using System;
using System.Collections.Generic;
using System.Text;

namespace hm_10
{
    class Ball
    {
        public string ballType { get; set; }
        public Ball(string ballType = "regular")
        {
            this.ballType = ballType;
        }
    }
}
