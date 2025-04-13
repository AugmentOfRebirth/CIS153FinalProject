using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFour_Group2
{
    internal class Player
    {
        private string play;
        private string score;
        private string tie;

        public Player(string p, string s, string t)
        {
            play = p;
            score = s;
            tie = t;
        }
        //=======================Getters=======================
        public string getPlay()
        {
            return play;
        }
        public string getScore()
        {
            return score;
        }
        public string getTie()
        {
            return tie;
        }
        //=======================Setters=======================
        public void setPlay(string p)
        {
            play = p;
        }
        public void setScore(string s)
        {
            score = s;
        }
        public void setTie(string t)
        {
            tie = t;
        }
    }
}
