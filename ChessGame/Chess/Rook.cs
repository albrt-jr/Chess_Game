using ChessGame.Board;

namespace ChessGame.Chess
{
    internal class Rook : Piece
    {
        public Rook (Color color, Boards brd) : base(color, brd)
        {

        }

        public override string ToString()
        {
            return "R";
        }
    }
}
