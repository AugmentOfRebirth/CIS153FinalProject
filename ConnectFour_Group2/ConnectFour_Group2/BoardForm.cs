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
    public partial class BoardForm : Form
    {
        GameMaster gm = new GameMaster();
        public BoardForm()
        {
            InitializeComponent();
            gm.InitGame(this);

            initPictures();

            Console.WriteLine(gm.getBoard().getGameBoard().Length);
            Console.WriteLine(gm.getBoard().getCell(0, 3));
        }
        // bitch
        // no u - Madz :)

        //==================
        //x = player 1
        //y = player 2/AI
        //z = empty
        //==================


        //===========================actions======================================
        private void BoardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void pb_MouseEnter(object sender, EventArgs e)
        {
            //this action handles the turn preview for all top buttons
            if (Object.ReferenceEquals(sender, pb_0_0))
            {
                pbEnterExit(0, 'x');
            }
            else if (Object.ReferenceEquals(sender, pb_0_1))
            {
                pbEnterExit(1, 'x');
            }
            else if (Object.ReferenceEquals(sender, pb_0_2))
            {
                pbEnterExit(2, 'x');
            }
            else if (Object.ReferenceEquals(sender, pb_0_3))
            {
                pbEnterExit(3, 'x');
            }
            else if (Object.ReferenceEquals(sender, pb_0_4))
            {
                pbEnterExit(4, 'x');
            }
            else if (Object.ReferenceEquals(sender, pb_0_5))
            {
                pbEnterExit(5, 'x');
            }
            else if (Object.ReferenceEquals(sender, pb_0_6))
            {
                pbEnterExit(6, 'x');
            }
        }
        private void pb_MouseLeave(object sender, EventArgs e)
        {
            //this action makes sure the turn preview goes away after moving the mouse off
            if (Object.ReferenceEquals(sender, pb_0_0))
            {
                pbEnterExit(0, 'z');
            }
            else if (Object.ReferenceEquals(sender, pb_0_1))
            {
                pbEnterExit(1, 'z');
            }
            else if (Object.ReferenceEquals(sender, pb_0_2))
            {
                pbEnterExit(2, 'z');
            }
            else if (Object.ReferenceEquals(sender, pb_0_3))
            {
                pbEnterExit(3, 'z');
            }
            else if (Object.ReferenceEquals(sender, pb_0_4))
            {
                pbEnterExit(4, 'z');
            }
            else if (Object.ReferenceEquals(sender, pb_0_5))
            {
                pbEnterExit(5, 'z');
            }
            else if (Object.ReferenceEquals(sender, pb_0_6))
            {
                pbEnterExit(6, 'z');
            }
        }
        private void pb_Click(object sender, EventArgs e)
        {

        }

        //=========================functions=================================
        public void initPictures()
        {
            //sets board to all black circles at start of game
            foreach (var pb in this.Controls.OfType<PictureBox>())
            {
                if (pb.Name.StartsWith("pb_"))
                {
                    pb.Image = Properties.Resources.black; // or YellowDisc, or null
                }
            }
        }
        public void pbEnterExit(int c, char f)
        {
            //this function will handle the turn preview for the player 
            //by checking each picture box row by row for the given column

            //the char is being passed so this function can be used on 2 player mode
            //if (gm.getBoard().getCell(5, c).getFilled() == 'z')
            //{
            //    tempFilled(5, c, f);
            //}
            //else if (gm.getBoard().getCell(4, c).getFilled() == 'z')
            //{
            //    tempFilled(4, c, f);
            //}
            //else if (gm.getBoard().getCell(3, c).getFilled() == 'z')
            //{
            //    tempFilled(3, c, f);
            //}
            //else if (gm.getBoard().getCell(2, c).getFilled() == 'z')
            //{
            //    tempFilled(2, c, f);
            //}
            //else if (gm.getBoard().getCell(1, c).getFilled() == 'z')
            //{
            //    tempFilled(1, c, f);
            //}
            //else if (gm.getBoard().getCell(0, c).getFilled() == 'z')
            //{
            //    tempFilled(0, c, f);
            //}

            for (int r = 5; r >= 0; r--)
            {
                Cell cell = gm.getBoard().getCell(r, c);
                if (cell != null && cell.getFilled() == 'z')
                {
                    tempFilled(r, c, f);
                    break;
                }
            }
        }
        public void tempFilled(int r, int c, char f)
        {
            //will probably only be used inside of pbEnterExit, temporarily changes picture

            if (f == 'x')
            {
                gm.getBoard().getCell(r, c).setFilled('x');
                gm.getBoard().getCell(r, c).getBox().Image = Properties.Resources.blue;

            }
            else if (f == 'y')
            {
                gm.getBoard().getCell(r, c).setFilled('y');
                gm.getBoard().getCell(r, c).getBox().Image = Properties.Resources.red;

            }
            else if (f == 'z')
            {
                gm.getBoard().getCell(r, c).setFilled('z');
                gm.getBoard().getCell(r, c).getBox().Image = Properties.Resources.black;

            }

        }
        public void permaFilled(int r, int c, char f)
        {

        }

    }
}
