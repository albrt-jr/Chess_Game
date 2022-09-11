using ChessGame.Board;
using System.Windows.Forms;

namespace ChessGame.Chess
{
    internal class Pinion : Piece
    {
        public Pinion (Color color, Boards brd) : base(color, brd)
        {

        }

        public override string ToString()
        {
            return "P";
        }

    }
}
