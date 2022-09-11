using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChessGame.Board;

namespace ChessGame.Forms
{
    public partial class Frm_Board : Form
    {
        List<Button> buttons = new List<Button>();

        public Frm_Board()
        {
            InitializeComponent();
        }

        private void Frm_Board_Load(object sender, EventArgs e)
        {
            Boards brd = new Boards(8, 8);
            addButtons();
            PrintBoard(brd);

        }

        private void addButtons()
        {
            buttons.Add(btn_a1);
            buttons.Add(btn_a2);
            buttons.Add(btn_a3);
            buttons.Add(btn_a4);
            buttons.Add(btn_a5);
            buttons.Add(btn_a6);
            buttons.Add(btn_a7);
            buttons.Add(btn_a8);
            buttons.Add(btn_b1);
            buttons.Add(btn_b2);
            buttons.Add(btn_b3);
            buttons.Add(btn_b4);
            buttons.Add(btn_b5);
            buttons.Add(btn_b6);
            buttons.Add(btn_b7);
            buttons.Add(btn_b8);
            buttons.Add(btn_c1);
            buttons.Add(btn_c2);
            buttons.Add(btn_c3);
            buttons.Add(btn_c4);
            buttons.Add(btn_c5);
            buttons.Add(btn_c6);
            buttons.Add(btn_c7);
            buttons.Add(btn_c8);
            buttons.Add(btn_d1);
            buttons.Add(btn_d2);
            buttons.Add(btn_d3);
            buttons.Add(btn_d4);
            buttons.Add(btn_d5);
            buttons.Add(btn_d6);
            buttons.Add(btn_d7);
            buttons.Add(btn_d8);
            buttons.Add(btn_e1);
            buttons.Add(btn_e2);
            buttons.Add(btn_e3);
            buttons.Add(btn_e4);
            buttons.Add(btn_e5);
            buttons.Add(btn_e6);
            buttons.Add(btn_e7);
            buttons.Add(btn_e8);
            buttons.Add(btn_f1);
            buttons.Add(btn_f2);
            buttons.Add(btn_f3);
            buttons.Add(btn_f4);
            buttons.Add(btn_f5);
            buttons.Add(btn_f6);
            buttons.Add(btn_f7);
            buttons.Add(btn_f8);
            buttons.Add(btn_g1);
            buttons.Add(btn_g2);
            buttons.Add(btn_g3);
            buttons.Add(btn_g4);
            buttons.Add(btn_g5);
            buttons.Add(btn_g6);
            buttons.Add(btn_g7);
            buttons.Add(btn_g8);
            buttons.Add(btn_h1);
            buttons.Add(btn_h2);
            buttons.Add(btn_h3);
            buttons.Add(btn_h4);
            buttons.Add(btn_h5);
            buttons.Add(btn_h6);
            buttons.Add(btn_h7);
            buttons.Add(btn_h8);
        }

        private void PrintBoard (Boards brd)
        {
            int index = 0;
            for (int i = 0; i < brd.Lines; i++)
            {
                for (int j = 0; j < brd.Columns; j++)
                {
                    buttons[index].Image = null;
                    index++;
                }

            }
            
        }
    }
}
