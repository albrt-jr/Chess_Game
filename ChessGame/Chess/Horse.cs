using ChessGame.Board;

namespace ChessGame.Chess
{
    internal class Horse : Piece
    {
        public Horse (Color color, Boards brd) : base(color, brd)
        {

        }

        public override string ToString()
        {
            return "H";
        }
    }
}
