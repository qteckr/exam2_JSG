using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompanyCodingTest2
{
    class Americano : Coffee
    {
        public Americano()
        {
            nPrice = 4500;
            nCoffee = 100;
            nWater = 100;
        }

        public bool MakeAmericano(ref int coffee, ref int water)
        {
            bool bRet = false;

            if (coffee >= 100 && water >= 100)
            {
                coffee -= 100;
                water -= 100;
                bRet = true;
            }

            return bRet;
        }
    }
}
