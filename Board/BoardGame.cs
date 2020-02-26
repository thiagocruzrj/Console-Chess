﻿namespace ConsoleChess.Board
{
    class BoardGame
    {
        public int Lines { get; set; }
        public int Columns { get; set; }
        private readonly Piece[,] Pieces;

        public BoardGame(int lines, int columns)
        {
            Lines = lines;
            Columns = columns;
            Pieces = new Piece[Lines, Columns];
        }

        public Piece Piece(int line, int column)
        {
            return Pieces[line, column];
        }

        public Piece Piece(Position pos)
        {
            return Pieces[pos.Line, pos.Column];
        }

        public void PutPiece(Piece p, Position pos)
        {
            Pieces[pos.Line, pos.Column] = p;
            p.Position = pos;
        }

        public Piece RemovePiece(Position pos)
        {
            if(Piece(pos) == null)
            {
                return null;
            }

            Piece aux = Piece(pos);
            aux.Position = null;
            Pieces[pos.Line, pos.Column] = null;
            return aux;
        }

        public bool PieceExistent(Position pos)
        {
            if (PieceExistent(pos))
            {
                throw new BoardException("There's a piece in this position!");
            }
            ValidadePostion(pos);
            return Piece(pos) != null;
        }

        public bool ValidPostion(Position pos)
        {
            if (pos.Line < 0 || pos.Line >= Columns || pos.Column < 0 || pos.Column >= Columns)
            {
                return false;
            }
            return true;
        }

        public void ValidadePostion(Position pos)
        {
            if(!ValidPostion(pos))
            {
                throw new BoardException("Invalid Position!");
            }
        }
    }
}
