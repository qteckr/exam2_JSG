using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompanyCodingTest2
{
    class clsVendingMachine
    {
        List<string> lst 


        public enum COFFEE_MENU
         {
            AMERICANO = 0,
            ESPRESO = 1,
            LATTE = 2
         }

        static int nProceeds = 0;

        int nCoffee = 10000;
        int nWater = 10000;
        int nMilk = 5000;
        Coffee clsCoff = new Coffee();

        public clsVendingMachine()
        {



        }

        public bool SellCoffee(COFFEE_MENU CM)
        {
            bool bRet = false;

            switch (CM)
            {
                case COFFEE_MENU.AMERICANO:
                    bRet = clsCoff.MakeAmericano(ref nCoffee, ref nWater);
                    break;
                case COFFEE_MENU.ESPRESO:
                    bRet = clsCoff.MakeLatte(ref nCoffee, ref nWater, ref nMilk);
                    break;
                case COFFEE_MENU.LATTE:
                    bRet = clsCoff.MakeEspreso(ref nCoffee, ref nWater);
                    break;
            }

            return bRet;
        }



    }
}
