using System;
using System.Text;
using System.Threading;

namespace PII_Game_Of_Life
{
public class BoardShow
{
    public static void BoardTxtPrint(Board boardInp)
    {
         while (true)
        {
        bool[,] b=boardInp.gameBoard;
        int width =boardInp.boardWidth;//variabe que representa el ancho del tablero
        int height =boardInp.boardHeight;//variabe que representa altura del tablero
       
            //Console.Clear();
            StringBuilder s = new StringBuilder();
            for (int y = 0; y<height;y++)
            {
                for (int x = 0; x<width; x++)
                {
                    if(b[x,y])
                    {
                        s.Append("|X|");
                    }
                    else
                    {
                        s.Append("___");
                    }
                }
                s.Append("\n");
            }
            Console.WriteLine(s.ToString());
            //=================================================
            //Invocar método para calcular siguiente generación
            //=================================================
            
            boardInp= BoardProgram.BoardStart(boardInp);
            Thread.Sleep(300);
        }
    }
}
}
