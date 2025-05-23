﻿// ==================================================================================================
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



        private List<Player> players = new List<Player>();
        public MainForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            addFromFile();
            Console.WriteLine(players[0].getScore());



            //putting a table here for reference
            //0 = player 1, 1 = computer
            //Console.WriteLine(players[0].getPlay());
            //Console.WriteLine(players[1].getPlay());

            ////=============================================================
            ////this is testing to make sure it is stored properly
            ////also for if you guys ever need to check when doing something
            ////=============================================================
            //Console.WriteLine(players[0].getScore());
            //Console.WriteLine(players[1].getScore());

            //Console.WriteLine(players[0].getTie());
            //Console.WriteLine(players[1].getTie());

        }

        //=====================================================
        //actions
        //=====================================================

        private void btn_1player_Click(object sender, EventArgs e)
        {
            BoardForm formtoload = new BoardForm(this, 0);
            loadNewForm(formtoload);
            this.Hide();
        }

        private void btn_2player_Click(object sender, EventArgs e)
        {
            BoardForm formtoload = new BoardForm(this, 1);
            loadNewForm(formtoload);
            this.Hide();
        }

        private void btn_stats_Click(object sender, EventArgs e)
        {
            StatsForm formtoload = new StatsForm(this);
            loadNewForm(formtoload);
            this.Hide();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //===================================================
        //functions
        //===================================================

        public void loadNewForm(Form ftl)
        {
            ftl.Show();
            ftl.BringToFront();
        }

        public void addFromFile()
        {

            // if file doesn't exist, then create it and add default score crap
            if (!File.Exists("../../Scores.txt"))
            {

                StreamWriter makeFile = File.CreateText("../../Scores.txt");
                makeFile.WriteLine("Player 1,0,0");
                makeFile.WriteLine("Computer,0,0");
                makeFile.Close();

            }
            StreamReader file = new StreamReader("../../Scores.txt");
            string line = file.ReadLine();
            players.Clear();
            string player;
            string score;
            string tie;

            int comma;
            char delim = ',';

            Player newPlayer;

            while (line != null)
            {
                comma = line.IndexOf(delim);
                player = line.Substring(0, comma);
                line = line.Substring(comma + 1);
                comma = line.IndexOf(delim);
                score = line.Substring(0, comma);
                line = line.Substring(comma + 1);
                comma = line.IndexOf(delim);
                tie = line;

                newPlayer = new Player(player, score, tie);
                players.Add(newPlayer);

                line = file.ReadLine();
            }
            file.Close();
        }

        public void fillStatsLabel(Label lblp1, Label lblai, Label lblTotal)
        {
            //this function will only be called in other forms to get stats

            //total number of games = player wins plus computer wins plus tie games
            int numOfGames = int.Parse(players[0].getScore()) + int.Parse(players[1].getScore()) + int.Parse(players[0].getTie());

            //fills out player 1 stats
            lblp1.Text = players[0].getScore() + Environment.NewLine + Environment.NewLine;
            //this if else statement prevents crashing from dividing by zero
            if (players[0].getScore() == "0")
            {
                lblp1.Text += "0.00%";
            }
            else
            {
                //player win rate = player score / total number of games * 100
                //ToString("F2") ensures only two decimal places are shown
                lblp1.Text += ((double.Parse(players[0].getScore()) / numOfGames) * 100).ToString("F2") + "%";
            }
            
            //fills out the computer stats
            lblai.Text = players[1].getScore() + Environment.NewLine + Environment.NewLine;
            if(players[1].getScore() == "0")
            {
                lblai.Text += "0.00%";
            }
            else
            {
                lblai.Text += ((double.Parse(players[1].getScore()) / numOfGames) * 100).ToString("F2") + "%";
            }
            

            //fills out total game stats
            lblTotal.Text = players[0].getTie() + Environment.NewLine + Environment.NewLine;
            lblTotal.Text += numOfGames;
        }
        public void updateScores(string playerName, int newWins, int newTies)
        {
            string filePath = "../../Scores.txt";
            //StreamWriter file = new StreamWriter(filePath);
            

            string line;
            if (playerName == "Player 1")
            {
                int newScore = Int32.Parse(players[0].getScore()) + newWins;
                int newDraws = Int32.Parse(players[0].getTie()) + newTies;

                File.WriteAllText(filePath, String.Empty);

                Console.WriteLine("I am supposed to update the text file");
                line = "Player 1";
                line += ",";
                line += newScore.ToString();
                line += ",";
                line += newDraws.ToString();
                line += "\n";
                //file.WriteLine(line);

                
                line += "Computer";
                line += ",";
                line += players[1].getScore();
                line += ",";
                line += newDraws.ToString();
                File.AppendAllText(filePath, line);
                //file.WriteLine(line);

                //Player 1,0,0
                //Computer,0,0
            }

            if (playerName == "Computer")
            {
                int newScore = Int32.Parse(players[1].getScore()) + newWins;
                int newDraws = Int32.Parse(players[1].getTie()) + newTies;

                File.WriteAllText(filePath, String.Empty);

                Console.WriteLine("I am supposed to update the text file");
                line = "Player 1";
                line += ",";
                line += players[0].getScore();
                line += ",";
                line += newDraws.ToString();
                line += "\n";
                //file.WriteLine(line);


                line += "Computer";
                line += ",";
                line += newScore.ToString();
                line += ",";
                line += newDraws.ToString();
                File.AppendAllText(filePath, line);
                //file.WriteLine(line);

                //Player 1,0,0
                //Computer,0,0
            }










            //string[] lines = File.ReadAllLines(filePath);

            //for (int i = 0; i < lines.Length; i++)
            //{
            //    string[] parts = lines[i].Split(',');

            //    if (parts[0] == playerName)
            //    {
            //        parts[1] = newWins.ToString();
            //        parts[2] = newTies.ToString();
            //        lines[i] = string.Join(",", parts);
            //        break;
            //    }
            //}

            //File.WriteAllLines(filePath, line);
        }
    }
}
