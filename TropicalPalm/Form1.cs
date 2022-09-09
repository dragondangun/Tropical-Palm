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

        double MaxDiv(Entity expr)
        => expr switch {
            Number.Real r => (double)r,
            Sumf(var a, var b) => (MaxDiv(a) > MaxDiv(b)) ? MaxDiv(a) : MaxDiv(b),
            Powf(var a, var b) => (double)Pow(MinTimes(a), (double)b.EvalNumerical().RealPart).RealPart,
            Mulf(var a, var b) => MaxDiv(a) / MaxDiv(b),
            Divf(var a, var b) => MaxDiv(a) * MaxDiv(b),
        };

        double MinDiv(Entity expr)
        => expr switch {
            Number.Real r => (double)r,
            Sumf(var a, var b) => (MinDiv(a) < MinDiv(b)) ? MinDiv(a) : MinDiv(b),
            Powf(var a, var b) => (double)Pow(MinDiv(a), (double)b.EvalNumerical().RealPart).RealPart,
            Mulf(var a, var b) => MinDiv(a) / MinDiv(b),
            Divf(var a, var b) => MinDiv(a) * MinDiv(b),
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
            ErrorCodes errorCode = checkInput();

            if(errorCode != ErrorCodes.ALL_IS_GOOD) {
                showError(errorCode);
                return;
            }

            var F = fRichTextBox.Text;

            plot.Plot.Clear();

            fillArrays(out double[] pY, out double[] qY, out double[] pbyqY, out double[] fY, out double[] errY, out double[] xArr);

            plot.Plot.AddScatter(xArr, pY, label : "P");
            plot.Plot.AddScatter(xArr, qY, label : "Q");
            plot.Plot.AddScatter(xArr, pbyqY, label: "P/Q");
            if(F.Length > 0) {
                plot.Plot.AddScatter(xArr, fY, label: "f");
                if(errorFuncCheckBox.Checked) {
                    plot.Plot.AddScatter(xArr, errY, label: "error");
                }
            }

            plot.Plot.Legend();
            plot.Refresh();
        }

        private void fillArrays(out double[] pY, out double[] qY, out double[] pbyqY, out double[] fY, out double[] errY, out double[] xArr) {
            double to, from;
            from = Convert.ToDouble(xFromTextBox.Text);
            to = Convert.ToDouble(xToTextBox.Text);

            int range = (int) Math.Ceiling(Math.Abs(to - from) / step)+1;

            pY = new double[range];
            qY = new double[range];
            pbyqY = new double[range];
            fY = new double[range];
            errY = new double[range];
            xArr = new double[range];

            if(fRichTextBox.Text.Length > 0) {
                if(errorFuncCheckBox.Checked) {
                    fillWithErrFunc(pY, qY, pbyqY, xArr, fY, errY);
                }
                else {
                    fillWithApproxFunc(pY, qY, pbyqY, xArr, fY);
                }
            }
            else {
                fillOnlyPolynomials(pY, qY, pbyqY, xArr);
            }

            if(inftyCheck) {
                correctInfty(pY);
                correctInfty(qY);
                correctInfty(pbyqY);
            }
        }

        private void fillOnlyPolynomials(double[] pY, double[] qY, double[] pbyqY, double[] xArr) {
            double to, from;
            from = Convert.ToDouble(xFromTextBox.Text);
            to = Convert.ToDouble(xToTextBox.Text);
            var P = pRichTextBox.Text;
            var Q = qRichTextBox.Text;
            var pbyq = $"({P})/({Q})";
            var x = Var("x");

            for(int i = 0; from < to; from += step, i++) {
                pY[i] = currAlgebra(P.Substitute(x, from));
                qY[i] = currAlgebra(Q.Substitute(x, from));
                pbyqY[i] = currAlgebra(pbyq.Substitute(x, from));
                xArr[i] = from;
            }
        }

        private void fillWithApproxFunc(double[] pY, double[] qY, double[] pbyqY, double[] xArr, double[] fY) {
            double to, from;
            from = Convert.ToDouble(xFromTextBox.Text);
            to = Convert.ToDouble(xToTextBox.Text);
            var P = pRichTextBox.Text;
            var Q = qRichTextBox.Text;
            var pbyq = $"({P})/({Q})";
            var x = Var("x");

            var F = fRichTextBox.Text;

            for(int i = 0; from < to; from += step, i++) {
                pY[i] = currAlgebra(P.Substitute(x, from));
                qY[i] = currAlgebra(Q.Substitute(x, from));
                pbyqY[i] = currAlgebra(pbyq.Substitute(x, from));
                fY[i] = ((double)F.Substitute(x, from).EvalNumerical().RealPart);
                xArr[i] = from;
            }
        }

        private void fillWithErrFunc(double[] pY, double[] qY, double[] pbyqY, double[] xArr, double[] fY, double[] errY) {
            double to, from;
            from = Convert.ToDouble(xFromTextBox.Text);
            to = Convert.ToDouble(xToTextBox.Text);
            var P = pRichTextBox.Text;
            var Q = qRichTextBox.Text;
            var pbyq = $"({P})/({Q})";
            var x = Var("x");

            var F = fRichTextBox.Text;

            for(int i = 0; from < to; from += step, i++) {
                pY[i] = currAlgebra(P.Substitute(x, from));
                qY[i] = currAlgebra(Q.Substitute(x, from));
                pbyqY[i] = currAlgebra(pbyq.Substitute(x, from));
                fY[i] = ((double)F.Substitute(x, from).EvalNumerical().RealPart);
                errY[i] = fY[i] - pbyqY[i];
                xArr[i] = from;
            }
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

        private void minDivRadioButton_CheckedChanged(object sender, EventArgs e) {
            currAlgebra = MinDiv;
            inftyCheck = true;
            step = 0.1;
        }

        private void maxDivRadioButton_CheckedChanged(object sender, EventArgs e) {
            currAlgebra = MaxDiv;
            inftyCheck = true;
            step = 0.1;
        }

        private void pRichTextBox_MouseHover(object sender, EventArgs e) {
            //ToolTip
            //toolTip1.SetToolTip(this, "Enter polynomial. Example:\n3*x^3+2x2+x+1"); 
            //toolTip1.AutoPopDelay = 1000;
        }

        ErrorCodes checkInput() {
            if(pRichTextBox.Text.Length == 0) 
                return ErrorCodes.P_EMPTY;
            if(qRichTextBox.Text.Length == 0) 
                return ErrorCodes.Q_EMPTY;

            if(xFromTextBox.Text.Length == 0)
                return ErrorCodes.FROM_EMPTY;
            if(xToTextBox.Text.Length == 0)
                return ErrorCodes.TO_EMPTY;

            double to, from;
            from = Convert.ToDouble(xFromTextBox.Text);
            to = Convert.ToDouble(xToTextBox.Text);

            if(to < from) {
                return ErrorCodes.UNCORRECT_BORDERS;
            }

            string pattern = "[a-wyzA-WYZ]";
            var m = Regex.Match(pRichTextBox.Text, pattern);
            if(m.Success) 
                return ErrorCodes.P_UNCORRECT;

            m = Regex.Match(qRichTextBox.Text, pattern);
            if(m.Success) 
                return ErrorCodes.Q_UNCORRECT;

            var x = Var("x");
            int r = 1;
            try {
                pRichTextBox.Text.Substitute(x, 0.4).EvalNumerical();
                pRichTextBox.Text.Substitute(x, -0.4).EvalNumerical();
                pRichTextBox.Text.Substitute(x, 0.0).EvalNumerical();
                r++;
                qRichTextBox.Text.Substitute(x, 0.4).EvalNumerical();
                qRichTextBox.Text.Substitute(x, -0.4).EvalNumerical();
                qRichTextBox.Text.Substitute(x, 0.0).EvalNumerical();
                if(fRichTextBox.Text.Length != 0) {
                    r++;
                    fRichTextBox.Text.Substitute(x, 0.4).EvalNumerical();
                    fRichTextBox.Text.Substitute(x, -0.4).EvalNumerical();
                    fRichTextBox.Text.Substitute(x, 0.0).EvalNumerical();
                }
            }
            catch {
                return (ErrorCodes)r;
            }

            return ErrorCodes.ALL_IS_GOOD;
        }

        void showError(ErrorCodes errorCode) {
            switch(errorCode) {
                case ErrorCodes.P_UNCORRECT:
                    MessageBox.Show("There's an error in P!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                case ErrorCodes.Q_UNCORRECT:
                    MessageBox.Show("There's an error in Q!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                case ErrorCodes.F_UNCORRECT:
                    MessageBox.Show("There's an error in F!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                case ErrorCodes.P_EMPTY: case ErrorCodes.Q_EMPTY:
                    MessageBox.Show("P(x) and Q(x) must be filled in!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                case ErrorCodes.FROM_EMPTY:
                    MessageBox.Show("From must be filled in!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                case ErrorCodes.TO_EMPTY:
                    MessageBox.Show("To must be filled in!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                case ErrorCodes.UNCORRECT_BORDERS:
                    MessageBox.Show("From must be less than to!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }
        }

        enum ErrorCodes {
            ALL_IS_GOOD = 0,
            P_UNCORRECT = 1,
            Q_UNCORRECT = 2,
            F_UNCORRECT = 3,
            P_EMPTY = 10,
            Q_EMPTY = 20,
            FROM_EMPTY = 40,
            TO_EMPTY = 50,
            UNCORRECT_BORDERS = 60,
        };
    }
}
