using ChessGame.Board;

namespace ChessGame.Chess
{
    internal class Queen : Piece
    {
        public Queen(Color color, Boards brd) : base(color, brd)
        {

        }

        public override string ToString()
        {
            return "Q";
        }
    }
}
