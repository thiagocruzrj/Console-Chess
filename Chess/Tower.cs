using ConsoleChess.Board;

namespace ConsoleChess.Chess
{
    class Tower : Piece
    {
        public Tower(Color color, BoardGame board) : base(color, board)
        {
        }

        public override string ToString()
        {
            return "T";
        }
    }
}
