using System;
using System.Collections.Generic;
using System.Text;

namespace hm_10
{
    class Ship
    {
        public int Draft;
        public int Crew;

        public Ship(int draft, int crew)
        {
            Draft = draft;
            Crew = crew;
        }

        public bool IsWorthIt()
        {
            if (Draft - (Crew * 1.5) > 20)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
