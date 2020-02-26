namespace ConsoleChess.Board
{
    class Piece
    {
        public Piece(Color color, BoardGame board)
        {
            Position = null;
            Color = color;
            BoardGame = board;
            QtMoves = 0;
        }

        public Position Position { get; set; }
        public Color Color { get; protected set; }
        public int QtMoves { get; protected set; }
        public BoardGame BoardGame { get; set; }
    }
}
