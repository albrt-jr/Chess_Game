
namespace ChessGame.Board
{
    internal class Piece
    {
        public Position Position { get; set; }
        public Color Color { get; protected set; }
        public int QntMovements { get; protected set; }
        public Boards Brd { get; protected set; }

        public Piece (Color color, Boards brd)
        {
            this.Position = null;
            this.Color = color;
            this.QntMovements = 0;
            this.Brd = brd;
        }

        public void addQntMovements()
        {
            QntMovements++;
        }
    }
}
