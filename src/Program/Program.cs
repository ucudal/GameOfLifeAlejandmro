using System;
//using Library;

namespace PII_Game_Of_Life
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Que empiese!!");
            Board int1 =new Board(BoardFromTXT.generateBoard(@"C:\Users\aleja\OneDrive\Desktop\Proyectos\GameOfLifeAlejandmro\assets\board.txt"));
            BoardShow.BoardTxtPrint(int1);
        }
    }
}
