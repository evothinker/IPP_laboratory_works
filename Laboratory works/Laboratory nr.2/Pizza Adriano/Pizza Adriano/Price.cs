using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Adriano
{
    class Price
    {
        //compute the price for the pizza
        public int ComputePrice(List<int> arg1, List<int> arg2, List<int> arg3)
        {
            int price = 0;

            for (int i = 0; i < arg1.Count; i++)
            {
                price += MonetizeCheeses(arg1[i]);
            }

            for (int i = 0; i < arg2.Count; i++)
            {
                price += MonetizeVegetables(arg2[i]);
            }

            for (int i = 0; i < arg3.Count; i++)
            {
                price += MonetizeMeat(arg3[i]);
            }

            return price;
        }

        //compute the price for one item of pizza
        private int MonetizeCheeses(int input)
        {
            int retVal = 0;

            switch(input)
            {
                case 0: retVal = 10; break;
                case 1: retVal = 9;  break;
                case 2: retVal = 14; break;
                case 3: retVal = 17; break;
                case 4: retVal = 11; break;
                case 5: retVal = 15; break;
            }
            return retVal;
        }

        //compute the price for one item of vegetables
        private int MonetizeVegetables(int input)
        {
            int retVal = 0;

            switch (input)
            {
                case 0: retVal = 5; break;
                case 1: retVal = 6; break;
                case 2: retVal = 7; break;
                case 3: retVal = 8; break;
                case 4: retVal = 9; break;
                case 5: retVal = 10; break;
                case 6: retVal = 11; break;
                case 7: retVal = 12; break;
                case 8: retVal = 13; break;
                case 9: retVal = 14; break;
            }
            return retVal;
        }

        //compute the price for one item of meat
        private int MonetizeMeat(int input)
        {
            int retVal = 0;

            switch (input)
            {
                case 0: retVal = 15; break;
                case 1: retVal = 16; break;
                case 2: retVal = 17; break;
                case 3: retVal = 18; break;
                case 4: retVal = 19; break;
            }
            return retVal;
        }


    }
}
