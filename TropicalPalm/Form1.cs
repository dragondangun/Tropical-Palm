using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AngouriMath.Extensions;
using static AngouriMath.MathS;
using AngouriMath;
using static AngouriMath.Entity.Number;
using static AngouriMath.Entity;

    namespace TropicalPalm {

    public partial class Form1:Form {
        double MaxPlus(Entity expr)
        => expr switch {
            Number.Real r => (double)r,
            Sumf(var a, var b) => (MaxPlus(a) > MaxPlus(b)) ? MaxPlus(a) : MaxPlus(b),
            Powf(var a, var b) => MaxPlus(a) * MaxPlus(b),
            Minusf(var a, var b) => (MaxPlus(a) > MaxPlus(b)) ? MaxPlus(a) : MaxPlus(b),
            Mulf(var a, var b) => MaxPlus(a) + MaxPlus(b),
            Divf(var a, var b) => MaxPlus(a) - MaxPlus(b),
        };

        double MinPlus(Entity expr)
        => expr switch {
            Number.Real r => (double)r,
            Sumf(var a, var b) => (MinPlus(a) < MinPlus(b)) ? MinPlus(a) : MinPlus(b),
            Powf(var a, var b) => MinPlus(a) * MinPlus(b),
            Minusf(var a, var b) => (MinPlus(a) < MinPlus(b)) ? MinPlus(a) : MinPlus(b),
            Mulf(var a, var b) => MinPlus(a) + MinPlus(b),
            Divf(var a, var b) => MinPlus(a) - MinPlus(b),
        };

        delegate double Algebra(Entity expr);
        Algebra currAlgebra;

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

        private void BuildButton_Click(object sender, EventArgs e) {
            if(pRichTextBox.Text.Length == 0 || qRichTextBox.Text.Length == 0) {
                MessageBox.Show("P(x) and Q(x) must be filled in!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double to, from;
            if(xFromTextBox.Text.Length != 0)
                from = Convert.ToDouble(xFromTextBox.Text);
            else
                return;

            if(xToTextBox.Text.Length != 0)
                to = Convert.ToDouble(xToTextBox.Text);
            else
                return;

            if(to < from) {
                MessageBox.Show("From must be less than to!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            plot.Plot.Clear();

            double step = 0.1;

            var P = pRichTextBox.Text;
            var Q = qRichTextBox.Text;
            var F = fRichTextBox.Text;
            var pbyq = ("(" + P + ")-(" + Q + ")").Simplify();

            pDbyQRichTextBox.Text = pbyq.Stringize();

            int range = (int) (Math.Abs(to - from) / step)+1;

            double[] pY = new double[range];
            double[] qY = new double[range];
            double[] pbyqY = new double[range];
            double[] fY = new double[range];
            double[] xArr = new double[range];

            if(F.Length > 0) {
                for(int i = 0; from < to; from += step, i++) {
                    var x = Var("x");
                    pY[i] = currAlgebra(P.Substitute(x, from));
                    qY[i] = currAlgebra(Q.Substitute(x, from));
                    pbyqY[i] = currAlgebra(pbyq.Substitute(x, from));
                    fY[i] = ((double)F.Substitute(x, from).EvalNumerical().RealPart);
                    xArr[i] = from;
                }

                if(xArr[xArr.Length - 1] == 0) {
                    fY = fY.SkipLast(1).ToArray();
                    xArr = xArr.SkipLast(1).ToArray();
                }
            }
            else {
                for(int i = 0; from < to; from += step, i++) {
                    var x = Var("x");
                    pY[i] = currAlgebra(P.Substitute(x, from));
                    qY[i] = currAlgebra(Q.Substitute(x, from));
                    pbyqY[i] = currAlgebra(pbyq.Substitute(x, from));
                    xArr[i] = from;
                }
            }

            if(xArr[xArr.Length - 1] == 0) {
                pY = pY.SkipLast(1).ToArray();
                qY = qY.SkipLast(1).ToArray();
                xArr = xArr.SkipLast(1).ToArray();
                pbyqY = pbyqY.SkipLast(1).ToArray();
            }

            plot.Plot.AddScatter(xArr, pY, label : "P");
            plot.Plot.AddScatter(xArr, qY, label : "Q");
            plot.Plot.AddScatter(xArr, pbyqY, label: "P/Q");
            if(F.Length>0)
                plot.Plot.AddScatter(xArr, fY, label: "f");
            
            plot.Plot.Legend();
            plot.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e) {
            currAlgebra = MaxPlus;
        }

        private void minPlusRadioButton_CheckedChanged(object sender, EventArgs e) {
            currAlgebra = MinPlus;
        }

        private void maxPlusRadioButton_CheckedChanged(object sender, EventArgs e) {
            currAlgebra = MaxPlus;
        }

        private void pRichTextBox_MouseHover(object sender, EventArgs e) {
            //ToolTip
            //toolTip1.SetToolTip(this, "Enter polynomial. Example:\n3*x^3+2x2+x+1"); 
            //toolTip1.AutoPopDelay = 1000;
        }

    }
}
