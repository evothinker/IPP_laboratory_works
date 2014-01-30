using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Adriano
{
    class Order
    {
        //get new id for the user
        public int GetId()
        {
            Random rand = new Random();
            return rand.Next(100, 999);
        }
    }
}
