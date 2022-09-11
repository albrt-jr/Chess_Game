using ChessGame.Board;

namespace ChessGame.Chess
{
    internal class Bishop : Piece
    {
        public Bishop (Color color, Boards brd) : base(color, brd)
        {

        }

        public override string ToString()
        {
            return "B";
        }
    }
}
