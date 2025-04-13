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

        public Player(string p, string s)
        {
            play = p;
            score = s;
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
        //=======================Setters=======================
        public void setPlay(string p)
        {
            play = p;
        }
        public void setScore(string s)
        {
            score = s;
        }
    }
}
