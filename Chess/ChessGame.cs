using ConsoleChess.Board;
using System;

namespace ConsoleChess.Chess
{
    class ChessGame
    {
        private BoardGame bor;
        private int turn;
        private Color CurrentPlayer;

        public ChessGame()
        {
            bor = new BoardGame(8, 8);
            turn = 1;
            CurrentPlayer = Color.White;
        }

        public void ExecuteMoviment(Position origin, Position destiny)
        {
            Piece p = bor.RemovePiece(origin);
            p.IncreaseMoveQuantity();
            Piece pieceCatched = bor.RemovePiece(destiny);
        }
    }
}
