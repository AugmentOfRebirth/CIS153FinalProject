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
        private GameMaster gm = new GameMaster();
        private bool buttonWasClicked = false;
        private int gameType;
        private bool player1Turn = true;
        private MainForm mform;
        private StatsForm sForm;
        private int turnCount = 0;

        
        public BoardForm(MainForm mf, int gt)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            gm.InitGame(this);
            mform = mf;
            initPictures();

            gameType = gt;
            Console.WriteLine(gameType);
            //Console.WriteLine(gm.getBoard().getGameBoard().Length);
            //Console.WriteLine(gm.getBoard().getCell(0, 3));
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



            if (sender is PictureBox pb)
            {
                if (player1Turn)
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
                    bool colFillCheck = pbEnterCheck(col);

                    if(player1Turn && colFillCheck)
                    {
                        pbEnterExit(col, 'x');
                        player1Turn = false;
                        //Console.WriteLine("first if statement");

                        lbl_Turn.Text = "Player 2's Turn";
                        lbl_Turn.ForeColor = Color.Red;

                        turnCount++;

                        buttonWasClicked = false;
                        pbEnterExit(col, 'y');


                    }
                    else if(!player1Turn && colFillCheck)
                    {
                        pbEnterExit(col, 'y');
                        player1Turn= true;
                        //Console.WriteLine("second if statement");

                        lbl_Turn.Text = "Player 1's Turn";
                        lbl_Turn.ForeColor = Color.Blue;

                        turnCount++;

                        buttonWasClicked = false;
                        pbEnterExit(col, 'x');

                    }

                }
            }

            

            if (turnCount == 42)
            {
                //tie games
                whoWon(3);
            }


        }
        private void btn_statsReturn_Click(object sender, EventArgs e)
        {
            sForm.Show();
            this.Hide();
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
        public bool pbEnterCheck(int c)
        {
            //checks before pbEnterExit to prevent issues
            for (int r = 5; r >= 0; r--)
            {
                Cell cell = gm.getBoard().getCell(r, c);
                if (cell != null && cell.getFilled() == 'z')
                {
                    return true;                   
                }
            }

            return false;
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
                //permafill if buttonWasClicked
                gm.getBoard().getCell(r, c).setFilled(f);
               
                checkForWin(r, c, f);
            }
        }
        public void checkForWin(int r, int c, char f)
        {

            //checking if its a win and which player gets that win
            bool won = false;
            bool p1win = false;

            if(winVertical(r,c,f))
            {
                won = true;
                if(player1Turn)
                {
                    lbl_win.Visible = true;
                    p1win = true;
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
                won = true;
                if (player1Turn)
                {
                    lbl_win.Visible = true;
                    p1win = true;
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
                won = true;
                if (player1Turn)
                {
                    lbl_win.Visible = true;
                    p1win = true;
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
                won = true;
                if (player1Turn)
                {
                    lbl_win.Visible = true;
                    p1win = true;
                }
                else
                {
                    lbl_win.Text = "Player 2 Wins!!!";
                    lbl_win.ForeColor = Color.Red;
                    lbl_win.Visible = true;

                }
            }

            if(won && p1win)
            {
                whoWon(1);
            }
            else if(won && !p1win)
            {
                whoWon(2);
            }

        }
        public bool winVertical(int r, int c, int f)
        {
            //vertical win check
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
            // Horizontal win check
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
            // Diagonal Ascending win check
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
            // Diagonal Descending win check
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
        public void enableReviewMode()
        {
            foreach (Control control in this.Controls)
            {
                control.Enabled = false;
            }
            lbl_Turn.Visible = false;
            btn_statsReturn.Visible = true;
            btn_statsReturn.Enabled = true;
        }
        public void whoWon(int whoWon)
        {
            //who won determines statform functionality. 1 is player 1, 2 is player 2, 3 is tie
            StatsForm formtoload = new StatsForm(mform, this, gameType, whoWon);
            mform.loadNewForm(formtoload);
            this.Hide();
            enableReviewMode();
        }

        //setter just in case zmoore doesn't like public form varaibles
        public void SetStatsForm(StatsForm stats)
        {
            //just in case zmoore cares about private form variables
            sForm = stats;
        }


    }
}
