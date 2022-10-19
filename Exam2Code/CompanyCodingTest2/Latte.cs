using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompanyCodingTest2
{
    class Latte : Coffee
    {
        int nMilk{get;set;}
       
         public Latte()
        {
             nPrice = 5000;
             nCoffee = 100;
             nWater = 70;
             nMilk = 30;
        }


         public bool MakeLatte(ref int coffee, ref int water, ref int Milk)
         {
             bool bRet = false;

             if (coffee >= 100 && water >= 70 && Milk >= 30)
             {
                 coffee -= 100;
                 water -= 70;
                 Milk -= 30;

                 bRet = true;
             }

             return bRet;
         }
    }

}
