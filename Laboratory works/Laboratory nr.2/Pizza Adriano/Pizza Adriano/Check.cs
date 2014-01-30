using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Adriano
{
    class Check
    {
        //check if the components are not exceeded
        public int CheckComponents(List<int> arg1,List<int> arg2,List<int> arg3)
        {
            if (CheckCheeses(arg1.Count) == true)
            {
                if (CheckVegetables(arg2.Count) == true)
                {
                    if (CheckMeat(arg3.Count) == true)
                    {
                        return 0;
                    }
                    else
                        return -1;
                }
                else
                    return -2;
            }
            else
                return -3;
        }

        //check if the chees is not exceeded
        private bool CheckCheeses(int input)
        {
            if (input <= 3)
                return true;
            else
                return false;
        }

        //check if the vegetables is not in excess
        private bool CheckVegetables(int input)
        {
            if (input <= 5)
                return true;
            else
                return false;
        }

        //check if the meat is not in excess
        private bool CheckMeat(int input)
        {
            if (input <= 2)
                return true;
            else
                return false;
        }
    }
}
