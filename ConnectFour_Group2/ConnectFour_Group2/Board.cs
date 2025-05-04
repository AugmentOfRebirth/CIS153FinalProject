using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFour_Group2
{
    internal class Board
    {
        private const int numRows = 6;
        private const int numCols = 7;
        private Cell[,] gameBoard = new Cell[numRows, numCols];


        // =========== getters ============
        public int getNumRows()
        {
            return numRows;
        }
        public int getNumCols()
        {
            return numCols;
        }
        public Cell getCell(int r, int c)
        {
            return gameBoard[r, c];
        }
        public Cell[,] getGameBoard()
        {
            return gameBoard;
        }

        //=========== Setters ===========

        public void setGameBoardCell(Cell cell)
        {
            //doing this so i can set up rows and cols off rip
            gameBoard[cell.getRow(), cell.getCol()] = cell;
        }


    }
}
