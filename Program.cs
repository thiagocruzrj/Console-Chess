using ConsoleChess.Board;
using System;

namespace ConsoleChess
{
    class Program
    {
        static void Main(string[] args)
        {
            BoardGame bor = new BoardGame(8, 8);
            bor.SetPiece(???, new Position(0, 0));
            bor.SetPiece(???, new Position(1, 3));
            bor.SetPiece(???, new Position(2, 4));

            Screen.printBoard(bor);

            Console.ReadLine();
        }
    }
}
