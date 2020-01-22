using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    public class Pitcher
    {
        public int cupsLeftInPitcher;
        //Single responsibility Principle (cupsLeftInPitcher)
        public Pitcher()
        {
            cupsLeftInPitcher = 10;
        }
    }


}
