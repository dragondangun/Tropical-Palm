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
using System.Text.RegularExpressions;

namespace TropicalPalm {

    public partial class Form1:Form {
        bool inftyCheck;
        double step = 0.1;

        double MaxPlus(Entity expr)
        => expr switch {
            Number.Real r => (double)r,
            Minusf(var a, var b) => /*MaxPlus(a+MaxPlus(-b))*/(MaxPlus(a) > MaxPlus(-MaxPlus(b))) ? MaxPlus(a) : MaxPlus(-MaxPlus(b)),
            Sumf(var a, var b) => (MaxPlus(a) > MaxPlus(b)) ? MaxPlus(a) : MaxPlus(b),
            Powf(var a, var b) => MaxPlus(a) * (double)b.EvalNumerical().RealPart,
            Mulf(var a, var b) => MaxPlus(a) + MaxPlus(b),
            Divf(var a, var b) => MaxPlus(a) - MaxPlus(b),
        };

        double MinPlus(Entity expr)
        => expr switch {
            Number.Real r => (double)r,
            Sumf(var a, var b) => (MinPlus(a) < MinPlus(b)) ? MinPlus(a) : MinPlus(b),
            Powf(var a, var b) => MinPlus(a) * (double)b.EvalNumerical().RealPart,
            Minusf(var a, var b) => (MinPlus(a) < MinPlus(b)) ? MinPlus(a) : MinPlus(b),
            Mulf(var a, var b) => MinPlus(a) + MinPlus(b),
            Divf(var a, var b) => MinPlus(a) - MinPlus(b),
        };

        double MaxTimes(Entity expr)
        => expr switch {
            Number.Real r => (double)r,
            Sumf(var a, var b) => (MaxTimes(a) > MaxTimes(b)) ? MaxTimes(a) : MaxTimes(b),
            Powf(var a, var b) => (double)Pow(MinTimes(a), (double)b.EvalNumerical().RealPart).RealPart,
            Mulf(var a, var b) => MaxTimes(a) * MaxTimes(b),
            Divf(var a, var b) => MaxTimes(a) / MaxTimes(b),
        };

        double MinTimes(Entity expr)
        => expr switch {
            Number.Real r => (double)r,
            Sumf(var a, var b) => (MinTimes(a) < MinTimes(b)) ? MinTimes(a) : MinTimes(b),
            Powf(var a, var b) => (double)Pow(MinTimes(a), (double)b.EvalNumerical().RealPart).RealPart,
            Mulf(var a, var b) => MinTimes(a) * MinTimes(b),
            Divf(var a, var b) => MinTimes(a) / MinTimes(b),
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
            int errorCode = checkInput();

            if(errorCode != -1) {
                showError(errorCode);
                return;
            }

            double to, from;
            from = Convert.ToDouble(xFromTextBox.Text);
            to = Convert.ToDouble(xToTextBox.Text);

            if(to < from) {
                MessageBox.Show("From must be less than to!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var P = pRichTextBox.Text;
            var Q = qRichTextBox.Text;
            var F = fRichTextBox.Text;

            plot.Plot.Clear();

            pDbyQRichTextBox.Text = $"({P})-({Q})".Simplify().Stringize();

            var pbyq = $"({P})/({Q})";

            int range = (int) Math.Ceiling(Math.Abs(to - from) / step)+1;
            to += step/2;

            var x = Var("x");
            double[] pY = new double[range];
            double[] qY = new double[range];
            double[] pbyqY = new double[range];
            double[] fY = new double[range];
            double[] xArr = new double[range];

            if(F.Length > 0) {
                for(int i = 0; from < to ; from += step, i++) {
                    pY[i] = currAlgebra(P.Substitute(x, from));
                    qY[i] = currAlgebra(Q.Substitute(x, from));
                    pbyqY[i] = currAlgebra(pbyq.Substitute(x, from));
                    fY[i] = ((double)F.Substitute(x, from).EvalNumerical().RealPart);
                    xArr[i] = from;
                }
            }
            else {
                for(int i = 0; from < to; from += step, i++) {
                    pY[i] = currAlgebra(P.Substitute(x, from));
                    qY[i] = currAlgebra(Q.Substitute(x, from));
                    pbyqY[i] = currAlgebra(pbyq.Substitute(x, from));
                    xArr[i] = from;
                }
            }

            if(inftyCheck) {
                correctInfty(pY);
                correctInfty(qY);
                correctInfty(pbyqY);
            }

            plot.Plot.AddScatter(xArr, pY, label : "P");
            plot.Plot.AddScatter(xArr, qY, label : "Q");
            plot.Plot.AddScatter(xArr, pbyqY, label: "P/Q");
            if(F.Length>0)
                plot.Plot.AddScatter(xArr, fY, label: "f");
            
            plot.Plot.Legend();
            plot.Refresh();
        }

        private void correctInfty(double[] arr) {
            for(int i = 0; i < arr.Length; i++) {
                if(double.IsPositiveInfinity(arr[i])) {
                    arr[i] = 9000000d;
                }
                else if(double.IsNegativeInfinity(arr[i])) {
                    arr[i] = -9000000d;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            currAlgebra = MaxPlus;
            inftyCheck = false;
            step = 0.01;
        }

        private void minPlusRadioButton_CheckedChanged(object sender, EventArgs e) {
            currAlgebra = MinPlus;
            inftyCheck = false;
            step = 0.01;
        }

        private void maxPlusRadioButton_CheckedChanged(object sender, EventArgs e) {
            currAlgebra = MaxPlus;
            inftyCheck = false;
            step = 0.01;
        }

        private void maxTimesRadioButton_CheckedChanged(object sender, EventArgs e) {
            currAlgebra = MaxTimes;
            inftyCheck = true;
            step = 0.1;
        }

        private void minTimesRadioButton_CheckedChanged(object sender, EventArgs e) {
            currAlgebra = MinTimes;
            inftyCheck = true;
            step = 0.1;
        }

        private void pRichTextBox_MouseHover(object sender, EventArgs e) {
            //ToolTip
            //toolTip1.SetToolTip(this, "Enter polynomial. Example:\n3*x^3+2x2+x+1"); 
            //toolTip1.AutoPopDelay = 1000;
        }

        int checkInput() {
            if(pRichTextBox.Text.Length == 0) 
                return 10;
            if(qRichTextBox.Text.Length == 0) 
                return 20;

            if(xFromTextBox.Text.Length == 0)
                return 40;
            if(xToTextBox.Text.Length == 0)
                return 50;


            string pattern = "[a-wyzA-WYZ]";
            var m = Regex.Match(pRichTextBox.Text, pattern);
            if(m.Success) 
                return 1;

            m = Regex.Match(qRichTextBox.Text, pattern);
            if(m.Success) 
                return 2;

            var x = Var("x");
            int r = 1;
            try {
                pRichTextBox.Text.Substitute(x, 0.4).EvalNumerical();
                r++;
                qRichTextBox.Text.Substitute(x, 0.4).EvalNumerical();
                if(fRichTextBox.Text.Length != 0) {
                    r++;
                    fRichTextBox.Text.Substitute(x, 0.4).EvalNumerical();
                }
            }
            catch {
                return r;
            }

            return -1;
        }

        void showError(int errorCode) {
            switch(errorCode) {
                case 1:
                    MessageBox.Show("There's an error in P!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                case 2:
                    MessageBox.Show("There's an error in Q!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                case 3:
                    MessageBox.Show("There's an error in F!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                case 10: case 20:
                    MessageBox.Show("P(x) and Q(x) must be filled in!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                case 40:
                    MessageBox.Show("From must be filled in!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                case 50:
                    MessageBox.Show("To must be filled in!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }
        }

    }
}
