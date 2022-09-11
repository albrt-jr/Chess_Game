using System;
using ChessGame.Board;

namespace ChessGame.Chess
{
    internal class ChessPosition
    {
        public char Column { get; set; }
        public int Line { get; set; }

        public ChessPosition (char column, int line)
        {
            this.Column = column;
            this.Line = line;
        }   

        public Position toPosition()
        {
            return new Position (Column, Line);
        }
    }
}
