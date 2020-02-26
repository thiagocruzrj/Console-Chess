namespace ConsoleChess.Board
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

        public void SetPiece(Piece p, Position pos)
        {
            Pieces[pos.Line, pos.Column] = p;
            p.Position = pos;
        }
    }
}
