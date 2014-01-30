using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IPP_lw._1_Problem._2.Mediator
{
    class Player
    {
        //id of the user
        private int UserId; 

        //number of points
        private int UserPoints;

        public Player()
        {
            UserId = 0;
            UserPoints = 0;
        }

        public Player(int id)
        {
            UserId = id;
            UserPoints = 0;
        }

        public void AddPoint()
        {
            this.UserPoints++;
        }

        public int GetUserId()
        {
            return this.UserId;
        }

        public int GetUserPoints()
        {
            return this.UserPoints;
        }
    }
}
