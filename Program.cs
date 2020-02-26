using ConsoleChess.Board;
using ConsoleChess.Chess;
using System;

namespace ConsoleChess
{
    class Program
    {
        static void Main(string[] args)
        {
            ChessPosition pos = new ChessPosition('c', 7);
            Console.WriteLine(pos);
            Console.WriteLine(pos.ToPosition());
            Console.ReadLine();
        }
    }
}
