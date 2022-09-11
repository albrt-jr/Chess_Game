
namespace ChessGame.Board
{
    internal class Boards
    {
        public int Lines { get; set; }
        public int Columns { get; set; }
        private Piece[,] _pieces;

        public Boards(int lines, int columns)
        {
            this.Lines = lines;
            this.Columns = columns;
            _pieces = new Piece[lines, columns];
        }

        public Piece Piece (int line, int column)
        {
            return _pieces[line, column];
        }

        public Piece Piece(Position pos)
        {
            return _pieces[pos.Line, pos.Column];
        }

        public bool isTherePiece (Position pos)
        {
            testPosition (pos);
            return Piece(pos) != null;
        }

        public void insertPiece (Piece p, Position pos)
        {
            if (isTherePiece(pos))
            {
                throw new BoardException("Já existe uma peça nessa posição!");
            }
            _pieces[pos.Line, pos.Column] = p;
            p.Position = pos;
        }

        public Piece removePiece (Position pos)
        {
            if (Piece (pos) == null)
            {
                return null;
            }
            Piece aux = Piece(pos);
            aux.Position = pos;
            _pieces[pos.Line, pos.Column] = null;
            return aux;
        }

        public bool validPosition (Position pos)
        {
            if (pos.Line < 0 || pos.Line >= Lines || pos.Column < 0 || pos.Column >= Columns)
            {
                return false;
            }
            return true;
        }

        public void testPosition(Position pos)
        {
            if (!validPosition(pos))
            {
                throw new BoardException("Posição Inválida!");
            }
        }
    }
}
