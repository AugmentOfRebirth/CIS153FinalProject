using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectFour_Group2
{
    internal class Cell
    {
        int row;
        int col;
        PictureBox Pbox;

        public Cell()
        {

        }

        public Cell(int r, int c, PictureBox p)
        {
            row = r;
            col = c;
            Pbox = p;
        }

        // ============= Getters ============
        public int getRow()
        {
            return row;
        }
        public int getCol()
        {
            return col;
        }

        public PictureBox getBox()
        {
            return Pbox;
        }



        // ============= Setters ============

        public void setRow(int r)
        {
            row = r;
        }

        public void setCol(int c)
        {
            col = c;
        }

        public void setBox(PictureBox p)
        {
            Pbox = p;
        }
    }
}
