using ConsoleChess.Board;
using ConsoleChess.Chess;
using System;

namespace ConsoleChess
{
    class Program
    {
        static void Main(string[] args)
        {
            BoardGame bor = new BoardGame(8, 8);

            bor.PutPiece(new Tower(Color.Black, bor), new Position(0, 0));
            bor.PutPiece(new Tower(Color.Black, bor), new Position(1, 3));
            bor.PutPiece(new King(Color.Black, bor), new Position(2, 4));

            Screen.PrintBoard(bor);

            Console.ReadLine();
        }
    }
}
