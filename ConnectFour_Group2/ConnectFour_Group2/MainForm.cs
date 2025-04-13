// ==================================================================================================
// Authors: Nicholas Voigt, Rowan Trame, Todd Coleman
// Date: 04/06/2025
// Desc: Connect Four Program
// ==================================================================================================



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectFour_Group2
{
    public partial class MainForm : Form
    {
        //this will be the welcome form



        List<Player> players = new List<Player>();
        public MainForm()
        {
            InitializeComponent();
            addFromFile();
            //putting a table here for reference
            //0 = player 1, 1 = player 2, 2 = computer
            //Console.WriteLine(players[0].getPlay());
            //Console.WriteLine(players[1].getPlay());
            //Console.WriteLine(players[2].getPlay());
            ////=============================================================
            ////this is testing to make sure it is stored properly
            ////also for if you guys ever need to check when doing something
            ////=============================================================
            //Console.WriteLine(players[0].getScore());
            //Console.WriteLine(players[1].getScore());
            //Console.WriteLine(players[2].getScore());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BoardForm formtoload = new BoardForm();
            loadNewForm(formtoload);
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BoardForm formtoload = new BoardForm();
            loadNewForm(formtoload);
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StatsForm formtoload = new StatsForm();
            loadNewForm(formtoload);
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        public void loadNewForm(Form ftl)
        {
            ftl.Show();
            ftl.BringToFront();
        }

        public void addFromFile()
        {
            StreamReader file = new StreamReader("../../Scores.txt");
            string line = file.ReadLine();

            string player;
            string score;

            int comma;
            char delim = ',';

            Player newPlayer;

            while (line != null)
            {
                comma = line.IndexOf(delim);
                player = line.Substring(0, comma);
                line = line.Substring(comma + 1);
                comma = line.IndexOf(delim);
                score = line;

                newPlayer = new Player(player, score);
                players.Add(newPlayer);

                line = file.ReadLine();
            }
            file.Close();
        }

    }
}
