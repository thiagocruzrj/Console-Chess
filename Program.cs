﻿using ConsoleChess.Board;
using ConsoleChess.Chess;
using System;

namespace ConsoleChess
{
    class Program
    {
        static void Main(string[] args)
        {
            ChessPosition pos = new ChessPosition('a', 1);
            Console.WriteLine(pos);
            Console.ReadLine();
        }
    }
}
