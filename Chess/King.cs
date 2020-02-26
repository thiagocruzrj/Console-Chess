﻿using ConsoleChess.Board;

namespace ConsoleChess.Chess
{
    class King : Piece
    {
        public King(Color color, BoardGame board) : base(color, board)
        {
        }

        public override string ToString()
        {
            return "R";
        }
    }
}
