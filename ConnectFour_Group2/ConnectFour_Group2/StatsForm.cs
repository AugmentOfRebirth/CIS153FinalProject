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



        MainForm mform;

        public StatsForm()
        {
            InitializeComponent();         
        }
        //overloaded constructor
        public StatsForm(MainForm mf)
        {
            InitializeComponent();
            mform = mf;
            mform.fillStatsLabel(lbl_player1, lbl_computer, lbl_total);
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
    }
}
