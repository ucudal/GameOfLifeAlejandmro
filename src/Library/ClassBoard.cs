using System;

namespace PII_Game_Of_Life
{
    public class Board
    {
        public bool[,] gameBoard;
        public int boardWidth;
        public int boardHeight;

        public Board(bool[,] boardImport)
        {
            this.gameBoard=boardImport;
            this.boardWidth=this.gameBoard.GetLength(0);
            this.boardHeight=this.gameBoard.GetLength(1);

        }
        public bool getValue(int x,int y)
        {
            return this.gameBoard[x,y];
        }
    }
}
