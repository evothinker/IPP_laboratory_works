using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IPP_lw._1_Problem._2.Mediator
{
    class Mediator
    {
        //the players
        Player[] players;
        
        //the scoreboard
        Scoreboard scoreboard;

        //the time
        DateTime time;

        //a flag
        bool flag;

        public Mediator()
        {
            players = null;
            scoreboard = null;
            flag = false;
        }

        public Mediator(int nrPlayers)
        {
            players = new Player[nrPlayers];

            flag = false;

            scoreboard = new Scoreboard(nrPlayers);

            for (int i = 0; i < nrPlayers; i++)
            {
                players[i] = new Player(i);
            }

            
        }

        //add a point the playerNr
        public void AddPoint(int playerNr)
        {
            if (flag && (DateTime.Now < time))
            {
                //a little check
                if (playerNr <= players.Length)
                {
                    //update the player score
                    players[playerNr - 1].AddPoint();

                    //update the scoreboard
                    scoreboard.AddPoint(playerNr - 1);
                }
            }
            else 
                flag = false;
        }

        //start the game
        public void StartGame()
        {
            time = DateTime.Now.AddSeconds(10);

            flag = true;

            return;
        }

        //get the points of the user
        public int GetPoints(int userId)
        {
            return scoreboard.GetScore(userId);
        }

    }
}
