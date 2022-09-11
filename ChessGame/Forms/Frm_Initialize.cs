using ChessGame.Board;
using ChessGame.Chess;
using System;
using System.Windows.Forms;


namespace ChessGame.Forms
{
    public partial class Frm_Initialize : Form
    {
        public Frm_Initialize()
        {
            InitializeComponent();
        }

        private void btn_NewGame_Click(object sender, EventArgs e)
        {
            Frm_Board frm_Board = new Frm_Board();
            frm_Board.ShowDialog();
        }
    }
}
