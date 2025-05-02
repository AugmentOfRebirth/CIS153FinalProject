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
            Console.WriteLine(gm.getBoard().getGameBoard().Length);
            Console.WriteLine(gm.getBoard().getCell(0,0));
        }
        // bitch
        // no u - Madz :)

        //==================
        //x = player 1
        //y = player 2/AI
        //z = empty
        //==================
        private void BoardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
      
        private void pb_0_0_MouseEnter(object sender, EventArgs e)
        {

        }

        //====================functions below====================
        public void SetFilled(int r, int c, char f)
        {

            //for ( int i = 5; i > -1; i-- )
            //{
            //    gm.getBoard().getCell(i, 0).getFilled();
            //}
            if(f == 'x')
            {
                gm.getBoard().getCell(5, 0).setFilled('x');
                gm.getBoard().getCell(r, c).getBox().Image = Properties.Resources.blue;

            }
            else if (f == 'y')
            {
                gm.getBoard().getCell(5, 0).setFilled('y');
                gm.getBoard().getCell(r, c).getBox().Image = Properties.Resources.red;

            }
            else if (f == 'z')
            {
                gm.getBoard().getCell(5, 0).setFilled('z');
                gm.getBoard().getCell(r, c).getBox().Image = Properties.Resources.red;

            }

        }

    }
}
