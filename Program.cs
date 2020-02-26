using ConsoleChess.Board;
using System;

namespace ConsoleChess
{
    class Program
    {
        static void Main(string[] args)
        {
            BoardGame bor = new BoardGame(8, 8);

            Screen.printBoard(bor);

            Console.ReadLine();
        }
    }
}
