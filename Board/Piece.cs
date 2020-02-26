namespace ConsoleChess.Board
{
    class Piece
    {
        public Piece(Position position, Color color, BoardGame board)
        {
            Position = position;
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
