using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectFour_Group2
{
    public partial class StatsForm : Form
    {
        //this will be the statistics form



        private MainForm mform;
        private BoardForm bform;
        private int gameType;
        
        //int gametype;

        public StatsForm()
        {
            InitializeComponent();         
        }
        //overloaded constructor
        public StatsForm(MainForm mf)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            mform = mf;
            mform.fillStatsLabel(lbl_player1, lbl_computer, lbl_total);
        }
        public StatsForm(MainForm mf,BoardForm bf, int gt, int winner)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            mform = mf;
            bform = bf;
            gameType = gt;
            //gametype = gt;
            btn_review.Visible = true;
            btn_playAgain.Visible = true;

            visible(true);
            lbl_2playerWarning.Visible = false;

            if (gt == 1)
            {
                visible(false);
                lbl_2playerWarning.Visible = true;
                lbl_title.Visible = true;
                lbl_2playerWarning.Text = "Statistics not available for 2 Player Mode!";

                //lbl_playerHeader.Text = "";
                //lbl_computerHeader.Text = "";
                //lbl_player1Static.Text = "";
                //lbl_player1.Text = "";
                //lbl_computerStatic.Text = "";




            }
            else
            {
                mform.fillStatsLabel(lbl_player1, lbl_computer, lbl_total);
            }

            if (winner == 1)
            {
                lbl_title.Text = "Player 1 is the winner";
            }
            else if (winner == 2)
            {
                lbl_title.Text = "Player 2 is the winner";
            }
            else if (winner == 3)
            {
                lbl_title.Text = "Tie Game! No Winner!";
            }
        }

        //==========================================
        //actions
        //==========================================

        private void btn_return_Click(object sender, EventArgs e)
        {
            mform.Show();
            this.Hide();
        }

        private void StatsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //this makes sure that clicking the x in the top right closes the whole program and not just the extra window
            Application.Exit();
        }
        private void btn_review_Click(object sender, EventArgs e)
        {
            bform.SetStatsForm(this);

            bform.Show();
            this.Hide();
        }
        private void btn_playAgain_Click(object sender, EventArgs e)
        {
            if(gameType == 0)
            {
                BoardForm formtoload = new BoardForm(mform, 0);
                mform.loadNewForm(formtoload);
                this.Hide();
            }
            else
            {
                BoardForm formtoload = new BoardForm(mform, 1);
                mform.loadNewForm(formtoload);
                this.Hide();
            }
        }
        //=================================================
        //functions
        //=================================================

        public void visible(bool visible)
        {
            if (visible)
            {
                foreach (Control control in this.Controls)
                {
                    if (control is Label)
                    {
                        control.Visible = true;
                    }
                }
            }
            else
            {
                foreach (Control control in this.Controls)
                {
                    if (control is Label)
                    {
                        control.Visible = false;
                    }
                }
            }
        }

        
    }
}
