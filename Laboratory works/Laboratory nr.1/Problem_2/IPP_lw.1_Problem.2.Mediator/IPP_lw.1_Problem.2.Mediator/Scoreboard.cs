using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IPP_lw._1_Problem._2.Mediator
{
    class Score
    {
        int points;

        public Score()
        {
            points = 0;
        }

        public int GetPoints()
        {
            return this.points;
        }

        public void AddPoint()
        {
            this.points++;
        }
    }

    class Scoreboard
    {
        //the number of entries (players)
        private Score[] scores;

        public Scoreboard()
        {
            scores = null;
        }

        public Scoreboard(int input)
        {
            scores = new Score[input];

            for (int i = 0; i < input; i++)
            {
                scores[i] = new Score();
            }
        }

        public int getScore(int playerNr)
        {
            return scores[playerNr - 1].GetPoints();
        }

        public void AddPoint(int scoreNr)
        {
            scores[scoreNr].AddPoint();
        }

        public int GetScore(int scoreNr)
        {
            return scores[scoreNr - 1].GetPoints();
        }
    }
}
