using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TropicalPalm {
    public partial class Form1:Form {
        public Form1() {
            InitializeComponent();
        }

        private void TextBoxInputHandler(object sender, KeyPressEventArgs e) {
            char ch = e.KeyChar;

            if(ch == 44 && (sender as TextBox).Text.IndexOf(',') != -1) {
                e.Handled = true;
                return;
            }

            if(ch == 46 && (sender as TextBox).Text.IndexOf(',') == -1) {
                e.KeyChar = (char)44;
                return;
            }

            if(ch == 45 && ((sender as TextBox).Text.IndexOf('-') != -1 || (sender as TextBox).SelectionStart != 0)) {
                e.Handled = true;
                return;
            }

            if(!Char.IsDigit(ch) && ch != 8 && ch != 44 && ch != 45) {
                e.Handled = true;
            }
        }
    }
}
