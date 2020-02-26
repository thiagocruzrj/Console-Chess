using System;

namespace ConsoleChess.Board
{
    class BoardException : Exception
    {
        public BoardException(string msg) : base(msg)
        {

        }
    }
}
