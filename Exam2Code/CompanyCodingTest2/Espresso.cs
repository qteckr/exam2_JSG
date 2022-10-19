using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompanyCodingTest2
{
    class Espresso : Coffee
    {
        public Espresso()
        {
            nPrice = 4000;
            nCoffee = 100;
            nWater = 30;
        }

        public bool MakeEspreso(ref int coffee, ref int water)
        {
            bool bRet = false;

            if (coffee >= 100 && water >= 30)
            {
                coffee -= 100;
                water -= 30;
                bRet = true;
            }

            return bRet;
        }
    }
}
