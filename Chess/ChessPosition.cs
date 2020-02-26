namespace ConsoleChess.Chess
{
    class ChessPosition
    {
        public ChessPosition(char column, int line)
        {
            Column = column;
            Line = line;
        }

        public char Column { get; set; }
        public int Line { get; set; }

        public override string ToString()
        {
            return "" + Column + Line;
        }
    }
}
