using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessGame.Board;

namespace ChessGame.Chess
{
    internal class ChessMatch
    {
        public Boards brd { get; private set; }
        private int turn;
        private Color actualPlayer;

        public ChessMatch()
        {
            brd = new Boards(8, 8);
            turn = 1;
            actualPlayer = Color.White;
        }

        public void doMovement(Position origin, Position destination)
        {
            Piece p = brd.removePiece(origin);
            p.addQntMovements();
            Piece capturedPiece = brd.removePiece(destination);
            brd.insertPiece(p, destination);

        }

    }
}
