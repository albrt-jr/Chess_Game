using ChessGame.Board;
using System.Windows.Forms;

namespace ChessGame.Chess
{
    internal class King : Piece
    {
        public King(Color color, Boards brd) : base (color, brd)
        {

        }

        public override string ToString()
        {
            return "K";
        }

    }
}
