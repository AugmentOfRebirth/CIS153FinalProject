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
        bool buttonWasClicked = false;
        public int gameType;
        public bool player1Turn = true;

        public BoardForm(int gameType)
        {
            InitializeComponent();
            gm.InitGame(this);

            initPictures();

            gameType = this.gameType;

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
            ////this action handles the turn preview for all top buttons
            //if (Object.ReferenceEquals(sender, pb_0_0))
            //{
            //    pbEnterExit(0, 'x');
            //}
            //else if (Object.ReferenceEquals(sender, pb_0_1))
            //{
            //    pbEnterExit(1, 'x');
            //}
            //else if (Object.ReferenceEquals(sender, pb_0_2))
            //{
            //    pbEnterExit(2, 'x');
            //}
            //else if (Object.ReferenceEquals(sender, pb_0_3))
            //{
            //    pbEnterExit(3, 'x');
            //}
            //else if (Object.ReferenceEquals(sender, pb_0_4))
            //{
            //    pbEnterExit(4, 'x');
            //}
            //else if (Object.ReferenceEquals(sender, pb_0_5))
            //{
            //    pbEnterExit(5, 'x');
            //}
            //else if (Object.ReferenceEquals(sender, pb_0_6))
            //{
            //    pbEnterExit(6, 'x');
            //}

            if (sender is PictureBox pb)
            {
                if(player1Turn)
                {
                    string[] parts = pb.Name.Split('_');
                    if (parts.Length == 3 && int.TryParse(parts[2], out int col))
                    {
                        pbEnterExit(col, 'x');
                    }
                }
                else
                {
                    string[] parts = pb.Name.Split('_');
                    if (parts.Length == 3 && int.TryParse(parts[2], out int col))
                    {
                        pbEnterExit(col, 'y');
                    }
                }               
            }


            
            


        }
        private void pb_MouseLeave(object sender, EventArgs e)
        {
            ////this action makes sure the turn preview goes away after moving the mouse off
            //if (Object.ReferenceEquals(sender, pb_0_0))
            //{
            //    pbEnterExit(0, 'z');
            //}
            //else if (Object.ReferenceEquals(sender, pb_0_1))
            //{
            //    pbEnterExit(1, 'z');
            //}
            //else if (Object.ReferenceEquals(sender, pb_0_2))
            //{
            //    pbEnterExit(2, 'z');
            //}
            //else if (Object.ReferenceEquals(sender, pb_0_3))
            //{
            //    pbEnterExit(3, 'z');
            //}
            //else if (Object.ReferenceEquals(sender, pb_0_4))
            //{
            //    pbEnterExit(4, 'z');
            //}
            //else if (Object.ReferenceEquals(sender, pb_0_5))
            //{
            //    pbEnterExit(5, 'z');
            //}
            //else if (Object.ReferenceEquals(sender, pb_0_6))
            //{
            //    pbEnterExit(6, 'z');
            //}
            if (buttonWasClicked)
            {
                buttonWasClicked = false;
                return;
            }

            if (sender is PictureBox pb)
            {
                string[] parts = pb.Name.Split('_');
                if (parts.Length == 3 && int.TryParse(parts[2], out int col))
                {
                    pbEnterExit(col, 'z');
                }
            }
        }
        private void pb_Click(object sender, EventArgs e)
        {
            buttonWasClicked = true;
            if (sender is PictureBox pb)
            {
                string[] parts = pb.Name.Split('_');
                if (parts.Length == 3 && int.TryParse(parts[2], out int col))
                {
                    if(player1Turn)
                    {
                        pbEnterExit(col, 'x');
                        player1Turn = false;
                        //Console.WriteLine("first if statement");

                        lbl_Turn.Text = "Player 2's Turn";
                        lbl_Turn.ForeColor = Color.Red;
                    }
                    else if(!player1Turn)
                    {
                        pbEnterExit(col, 'y');
                        player1Turn= true;
                        //Console.WriteLine("second if statement");

                        lbl_Turn.Text = "Player 1's Turn";
                        lbl_Turn.ForeColor = Color.Blue;
                    }

                }
            }
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

            //condensed the else if chain
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
                //gm.getBoard().getCell(r, c).setFilled('x');
                gm.getBoard().getCell(r, c).getBox().Image = Properties.Resources.blue;
                
            }
            else if (f == 'y')
            {
                //gm.getBoard().getCell(r, c).setFilled('y');
                gm.getBoard().getCell(r, c).getBox().Image = Properties.Resources.red;

            }
            else if (f == 'z')
            {
                //gm.getBoard().getCell(r, c).setFilled('z');
                gm.getBoard().getCell(r, c).getBox().Image = Properties.Resources.black;

            }

            if (buttonWasClicked)
            {
                gm.getBoard().getCell(r, c).setFilled(f);

                //this is where checkForWin probably should go
                checkForWin(r, c, f);
            }
        }
        public void checkForWin(int r, int c, char f)
        {
         
            //checking if its a win and which player gets that win

            if(winVertical(r,c,f))
            {
                if(player1Turn)
                {
                    lbl_win.Visible = true;
                }
                else
                {
                    lbl_win.Text = "Player 2 Wins!!!";
                    lbl_win.ForeColor = Color.Red;
                    lbl_win.Visible = true;

                }

            }
            else if(winHorizontal(r,c,f))
            {
                if (player1Turn)
                {
                    lbl_win.Visible = true;
                }
                else
                {
                    lbl_win.Text = "Player 2 Wins!!!";
                    lbl_win.ForeColor = Color.Red;
                    lbl_win.Visible = true;

                }
            }
            else if(winDiagonalAscend(r,c,f))
            {
                if (player1Turn)
                {
                    lbl_win.Visible = true;
                }
                else
                {
                    lbl_win.Text = "Player 2 Wins!!!";
                    lbl_win.ForeColor = Color.Red;
                    lbl_win.Visible = true;

                }
            }
            else if (winDiagonalDescend(r, c, f))
            {
                if (player1Turn)
                {
                    lbl_win.Visible = true;
                }
                else
                {
                    lbl_win.Text = "Player 2 Wins!!!";
                    lbl_win.ForeColor = Color.Red;
                    lbl_win.Visible = true;

                }
            }


        }
        public bool winVertical(int r, int c, int f)
        {
            if (r <= 2)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (gm.getBoard().getCell(r + i, c).getFilled() != f)
                    {
                        //Console.WriteLine("this is not a win");
                        return false;
                    }

                    if (i == 3)
                    {
                        Console.WriteLine("vertical win");
                        return true;
                    }
                }
            }
            return false;
        }
        public bool winHorizontal(int r, int c, int f)
        {
            // Horizontal check (both sides)
            int count = 1;

            // Left
            int col = c - 1;
            while (col >= 0 && gm.getBoard().getCell(r, col).getFilled() == f)
            {
                count++;
                col--;
            }

            // Right
            col = c + 1;
            while (col <= 6 && gm.getBoard().getCell(r, col).getFilled() == f)
            {
                count++;
                col++;
            }

            if (count >= 4)
            {
                Console.WriteLine("horizontal win");
                return true;
            }
            return false;
        }
        public bool winDiagonalAscend(int r, int c, int f)
        {
            // Horizontal check (both sides)
            int count = 1;

            // Left
            int col = c - 1;
            int row = r + 1;
            while ((col >= 0 && row <= 5) && gm.getBoard().getCell(row, col).getFilled() == f)
            {
                count++;
                col--;
                row++;
            }

            // Right
            col = c + 1;
            row = r - 1;
            while ((col <= 6 && row >= 0) && gm.getBoard().getCell(row, col).getFilled() == f)
            {
                count++;
                col++;
                row--;
            }

            if (count >= 4)
            {
                Console.WriteLine("Diagonal Ascended win");
                return true;
            }
            return false;
        }
        public bool winDiagonalDescend(int r, int c, int f)
        {
            // Horizontal check (both sides)
            int count = 1;

            // Left
            int col = c - 1;
            int row = r - 1;
            while ((col >= 0 && row >= 0) && gm.getBoard().getCell(row, col).getFilled() == f)
            {
                count++;
                col--;
                row--;
            }

            // Right
            col = c + 1;
            row = r + 1;
            while ((col <= 6 && row <= 5) && gm.getBoard().getCell(row, col).getFilled() == f)
            {
                count++;
                col++;
                row++;
            }

            if (count >= 4)
            {
                Console.WriteLine("Diagonal Descended win");
                return true;
            }
            return false;
        }
    }
}
