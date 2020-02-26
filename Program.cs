using ConsoleChess.Board;
using ConsoleChess.Chess;
using System;

namespace ConsoleChess
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                ChessGame match = new ChessGame();
                Screen.PrintBoard(match.bor);
            } catch (BoardException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
