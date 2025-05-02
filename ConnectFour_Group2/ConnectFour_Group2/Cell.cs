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
        char filled;
        PictureBox Pbox;

        public Cell()
        {

        }

        public Cell(int r, int c, PictureBox p, char f)
        {
            row = r;
            col = c;
            Pbox = p;
            filled = f;
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
        public char getFilled()
        {
            return filled;
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
        public void setFilled(char f)
        {
            filled = f;
        }
        public void setBox(PictureBox p)
        {
            Pbox = p;
        }
    }
}
