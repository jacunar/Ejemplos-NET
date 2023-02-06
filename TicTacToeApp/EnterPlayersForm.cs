using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeApp {
    public partial class EnterPlayersForm : Form {
        public EnterPlayersForm() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            MainForm.SetPlayersName(P1.Text, P2.Text);
            this.Close();
        }

        private void P2_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar.ToString() == "\n")
                button1.PerformClick();
        }
    }
}
