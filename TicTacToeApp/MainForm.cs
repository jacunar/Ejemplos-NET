using System.ComponentModel;

namespace TicTacToeApp {
    public partial class MainForm : Form {
        bool _turn = true; //true = X turn; false = O turn
        int _turn_count = 0;

        public MainForm() {
            InitializeComponent();
        }

        private void A1_Click(object sender, EventArgs e) {
            Button b = (Button)sender;
            if (_turn)
                b.Text = "X";
            else
                b.Text = "O";

            _turn = !_turn;
            b.Enabled = false;
            _turn_count++;
            CheckForWinner();
        }

        private void CheckForWinner() {
            bool _there_is_a_winner = false;

            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
                _there_is_a_winner = true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                _there_is_a_winner = true;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                _there_is_a_winner = true;
            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                _there_is_a_winner = true;
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
                _there_is_a_winner = true;
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
                _there_is_a_winner = true;
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
                _there_is_a_winner = true;
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
                _there_is_a_winner = true;

            if (_there_is_a_winner) {
                DisableButtons();
                String _winner = "";
                if (_turn) {
                    _winner = "O";
                    o_win_count.Text = (Int32.Parse(o_win_count.Text) + 1).ToString();
                } else {
                    _winner = "X";
                    x_win_count.Text = (Int32.Parse(x_win_count.Text) + 1).ToString();
                }

                MessageBox.Show(_winner + " Gana!", "Yay!");
            } else {
                if (_turn_count == 9) {
                    draw_count.Text = (Int32.Parse(draw_count.Text) + 1).ToString();
                    MessageBox.Show("Draw!", "Bummer!");
                }
            }
        }

        private void DisableButtons() {
            try {
                foreach (Control c in Controls) {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            } catch { }
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("By jacuna", Text);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void nuevoJuegoToolStripMenuItem_Click(object sender, EventArgs e) {
            _turn = true;
            _turn_count = 0;

            foreach (Control c in Controls) {
                try {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                } catch { }
            }           
        }

        private void button_enter(object sender, EventArgs e) {
            Button b = (Button)sender;
            if (b.Enabled) {
                if (_turn)
                    b.Text = "X";
                else
                    b.Text = "O";
            }
        }

        private void button_leave(object sender, EventArgs e) {
            Button b = (Button)sender;
            if (b.Enabled)
                b.Text = "";
        }

        private void reiniciarContadoresToolStripMenuItem_Click(object sender, EventArgs e) {
            o_win_count.Text = "0";
            x_win_count.Text = "0";
            draw_count.Text = "0";
        }
    }
}