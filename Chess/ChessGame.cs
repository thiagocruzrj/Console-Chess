using ConsoleChess.Board;
using System;

namespace ConsoleChess.Chess
{
    class ChessGame
    {
        public BoardGame bor { get; private set; }
        private readonly int turn;
        private readonly Color CurrentPlayer;

        public ChessGame()
        {
            bor = new BoardGame(8, 8);
            turn = 1;
            CurrentPlayer = Color.White;
            PutPieces();
        }

        private void PutPieces()
        {
            bor.PutPiece(new Tower(Color.White, bor), new ChessPosition('c', 1).ToPosition());
            bor.PutPiece(new Tower(Color.White, bor), new ChessPosition('c', 2).ToPosition());
            bor.PutPiece(new Tower(Color.White, bor), new ChessPosition('d', 2).ToPosition());
            bor.PutPiece(new King(Color.White, bor), new ChessPosition('d', 1).ToPosition());
            bor.PutPiece(new Tower(Color.White, bor), new ChessPosition('e', 1).ToPosition());
            bor.PutPiece(new Tower(Color.White, bor), new ChessPosition('e', 2).ToPosition());
        }

        public void ExecuteMoviment(Position origin, Position destiny)
        {
            Piece p = bor.RemovePiece(origin);
            p.IncreaseMoveQuantity();
            Piece pieceCatched = bor.RemovePiece(destiny);
            bor.PutPiece(p, destiny);
        }
    }
}
