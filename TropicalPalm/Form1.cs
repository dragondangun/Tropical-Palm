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
using System.Threading;
using System.IO;

namespace TropicalPalm {

    public partial class Form1:Form {
        bool inftyCheck;
        bool nonNegativeField;
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

            if(ch == 45 && ((sender as TextBox).Text.IndexOf('-') != -1 || nonNegativeField || (sender as TextBox).SelectionStart != 0)) {
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

            int range = calculateRange();

            double[] pY = new double[range];
            double[] qY = new double[range];
            double[] pbyqY = new double[range];
            double[] fY = new double[range];
            double[] errY = new double[range];
            double[] xArr = new double[range];

            double rootMeanSquaredError;
            try {
                rootMeanSquaredError = fillArrays(pRichTextBox.Text, qRichTextBox.Text, pY, qY, pbyqY, fY, errY, xArr, range);
            }
            catch(NotFiniteNumberException ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            showRmse(rootMeanSquaredError);

            plotArrays(pY, qY, pbyqY, fY, errY, xArr);
        }

        private int calculateRange() {
            double to, from;
            from = Convert.ToDouble(xFromTextBox.Text);
            to = Convert.ToDouble(xToTextBox.Text);

            return (int)Math.Ceiling(Math.Abs(to - from) / step) + 1;
        }

        private void showRmse(double rootMeanSquaredError) {
            if(rootMeanSquaredError != -1) {
                rootMeanSquaredErrorValueLabel.Text = rootMeanSquaredError.ToString("F2");
                rootMeanSquaredErrorValueLabel.Visible = true;
                rootMeanSquaredErrorLabel.Visible = true;
            }
            else {
                rootMeanSquaredErrorValueLabel.Visible = false;
                rootMeanSquaredErrorLabel.Visible = false;
            }
        }

        private void plotArrays(double[] pY, double[] qY, double[] pbyqY, double[] fY, double[] errY,double[] xArr) {
            plot.Plot.Clear();
            plot.Plot.AddScatter(xArr, pY, label: "P");
            plot.Plot.AddScatter(xArr, qY, label: "Q");
            plot.Plot.AddScatter(xArr, pbyqY, label: "P/Q");
            if(fRichTextBox.Text.Length > 0) {
                plot.Plot.AddScatter(xArr, fY, label: "f");
                if(errorFuncCheckBox.Checked) {
                    plot.Plot.AddScatter(xArr, errY, label: "error");
                }
            }

            plot.Plot.Legend();
            plot.Refresh();
        }

        private double fillArrays(string P, string Q, double[] pY, double[] qY, double[] pbyqY, double[] fY, double[] errY, double[] xArr, int range) {
            
            double rootMeanSquaredError = -1;

            try {
                if(range < 3) {
                    if(fRichTextBox.Text.Length > 0) {
                        double squaredError = fillWithErrFunc(P, Q, pY, qY, pbyqY, xArr, fY, errY, 0, range);
                        rootMeanSquaredError = Math.Sqrt(squaredError / range);
                    }
                    else {
                        fillOnlyPolynomials(P, Q, pY, qY, pbyqY, xArr, 0, range);
                    }
                }
                else {
                    int oneThirdRange = range / 3;
                    int twoThirdRange = oneThirdRange + oneThirdRange;

                    CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
                    CancellationToken cancellationToken = cancellationTokenSource.Token;

                    if(fRichTextBox.Text.Length == 0) {
                        Task firstPart = Task.Run(() => fillOnlyPolynomials(P, Q, pY, qY, pbyqY, xArr, 0, oneThirdRange, cancellationTokenSource, cancellationToken));
                        Task secondPart = Task.Run(() => fillOnlyPolynomials(P, Q, pY, qY, pbyqY, xArr, oneThirdRange, twoThirdRange, cancellationTokenSource, cancellationToken));
                        Task thirdPart = Task.Run(() => fillOnlyPolynomials(P, Q, pY, qY, pbyqY, xArr, twoThirdRange, range, cancellationTokenSource, cancellationToken));
                        Task.WaitAll(firstPart, secondPart, thirdPart);
                    }
                    else {
                        Task<double> firstPart = Task.Run(() => fillWithErrFunc(P, Q, pY, qY, pbyqY, xArr, fY, errY, 0, oneThirdRange, cancellationTokenSource, cancellationToken));
                        Task<double> secondPart = Task.Run(() => fillWithErrFunc(P, Q, pY, qY, pbyqY, xArr, fY, errY, oneThirdRange, twoThirdRange, cancellationTokenSource, cancellationToken));
                        Task<double> thirdPart = Task.Run(() => fillWithErrFunc(P, Q, pY, qY, pbyqY, xArr, fY, errY, twoThirdRange, range, cancellationTokenSource, cancellationToken));
                        Task.WaitAll(firstPart, secondPart, thirdPart);

                        double squaredError = firstPart.Result + secondPart.Result + thirdPart.Result;
                        rootMeanSquaredError = Math.Sqrt(squaredError / range);
                    }
                }
            }
            catch(AggregateException ae) {
                throw ae.InnerException;
            }

            if(inftyCheck) {
                correctInfty(pY);
                correctInfty(qY);
                correctInfty(pbyqY);
            }

            return rootMeanSquaredError;
        }

        private void fillOnlyPolynomials(string P, string Q, double[] pY, double[] qY, double[] pbyqY, double[] xArr, int indexFrom, int indexTo) {
            double xValue;
            xValue = Convert.ToDouble(xFromTextBox.Text) + indexFrom*step;
            var pbyq = $"({P})/({Q})";
            var xVariable = Var("x");

            bool error = false;
            for(int i = indexFrom; i < indexTo; xValue += step, i++) {
                pY[i] = currAlgebra(P.Substitute(xVariable, xValue));
                error |= double.IsNaN(pY[i]);
                qY[i] = currAlgebra(Q.Substitute(xVariable, xValue));
                error |= double.IsNaN(qY[i]);
                pbyqY[i] = currAlgebra(pbyq.Substitute(xVariable, xValue));
                error |= double.IsNaN(pbyqY[i]);

                if(error) {
                    throw new NotFiniteNumberException($"When x is {xValue}:\npY={pY[i]}\nqY={qY[i]}\npbyqY={pbyqY[i]}");
                }

                xArr[i] = xValue;
            }
        }

        private void fillOnlyPolynomials(string P, string Q, double[] pY, double[] qY, double[] pbyqY, double[] xArr, int indexFrom, int indexTo, CancellationTokenSource cancellationTokenSource, CancellationToken cancellationToken) {
            double xValue;
            xValue = Convert.ToDouble(xFromTextBox.Text) + indexFrom * step;
            var pbyq = $"({P})/({Q})";
            var xVariable = Var("x");

            bool error = false;
            for(int i = indexFrom; i < indexTo; xValue += step, i++) {
                pY[i] = currAlgebra(P.Substitute(xVariable, xValue));
                error |= double.IsNaN(pY[i]);
                qY[i] = currAlgebra(Q.Substitute(xVariable, xValue));
                error |= double.IsNaN(qY[i]);
                pbyqY[i] = currAlgebra(pbyq.Substitute(xVariable, xValue));
                error |= double.IsNaN(pbyqY[i]);

                if(error) {
                    cancellationTokenSource.Cancel();
                    throw new NotFiniteNumberException($"When x is {xValue}:\npY={pY[i]}\nqY={qY[i]}\npbyqY={pbyqY[i]}");
                }

                if(cancellationToken.IsCancellationRequested) {
                    return;
                }

                xArr[i] = xValue;
            }
        }

        private double fillWithErrFunc(string P, string Q, double[] pY, double[] qY, double[] pbyqY, double[] xArr, double[] fY, double[] errY, int indexFrom, int indexTo) {
            double xValue;
            double squaredError = 0;
            xValue = Convert.ToDouble(xFromTextBox.Text) + indexFrom * step;
            var pbyq = $"({P})/({Q})";
            var xVariable = Var("x");

            var F = fRichTextBox.Text;

            bool error = false;
            for(int i = indexFrom; i < indexTo; xValue += step, i++) {
                pY[i] = currAlgebra(P.Substitute(xVariable, xValue));
                error |= double.IsNaN(pY[i]);
                qY[i] = currAlgebra(Q.Substitute(xVariable, xValue));
                error |= double.IsNaN(qY[i]);
                pbyqY[i] = currAlgebra(pbyq.Substitute(xVariable, xValue));
                error |= double.IsNaN(pbyqY[i]);

                fY[i] = ((double)F.Substitute(xVariable, xValue).EvalNumerical().RealPart);
                error |= double.IsNaN(fY[i]);

                if(error) {
                    throw new NotFiniteNumberException($"When x is {xValue}:\npY={pY[i]}\nqY={qY[i]}\npbyqY={pbyqY[i]}\nfY{fY[i]}");
                }

                errY[i] = fY[i] - pbyqY[i];
                squaredError += errY[i] * errY[i];
                xArr[i] = xValue;
            }

            return squaredError;
        }

        private double fillWithErrFunc(string P, string Q, double[] pY, double[] qY, double[] pbyqY, double[] xArr, double[] fY, double[] errY, int indexFrom, int indexTo, CancellationTokenSource cancellationTokenSource, CancellationToken cancellationToken) {
            double xValue;
            double squaredError = 0;
            xValue = Convert.ToDouble(xFromTextBox.Text) + indexFrom * step;
            var pbyq = $"({P})/({Q})";
            var xVariable = Var("x");

            var F = fRichTextBox.Text;

            bool error = false;
            for(int i = indexFrom; i < indexTo; xValue += step, i++) {
                pY[i] = currAlgebra(P.Substitute(xVariable, xValue));
                error |= double.IsNaN(pY[i]);
                qY[i] = currAlgebra(Q.Substitute(xVariable, xValue));
                error |= double.IsNaN(qY[i]);
                pbyqY[i] = currAlgebra(pbyq.Substitute(xVariable, xValue));
                error |= double.IsNaN(pbyqY[i]);

                fY[i] = ((double)F.Substitute(xVariable, xValue).EvalNumerical().RealPart);
                error |= double.IsNaN(fY[i]);

                if(error) {
                    cancellationTokenSource.Cancel();
                    throw new NotFiniteNumberException($"When x is {xValue}:\npY={pY[i]}\nqY={qY[i]}\npbyqY={pbyqY[i]}\nfY{fY[i]}");
                }
                if(cancellationToken.IsCancellationRequested) {
                    return -1;
                }

                errY[i] = fY[i] - pbyqY[i];
                squaredError += errY[i] * errY[i];
                xArr[i] = xValue;
            }

            return squaredError;
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
            sumFieldSettings();
        }

        private void minPlusRadioButton_CheckedChanged(object sender, EventArgs e) {
            if(minPlusRadioButton.Checked) {
                currAlgebra = MinPlus;
                sumFieldSettings();
            }
        }

        private void maxPlusRadioButton_CheckedChanged(object sender, EventArgs e) {
            if(maxPlusRadioButton.Checked) {
                currAlgebra = MaxPlus;
                sumFieldSettings();
            }
        }

        private void maxTimesRadioButton_CheckedChanged(object sender, EventArgs e) {
            if(maxTimesRadioButton.Checked) {
                currAlgebra = MaxTimes;
                mulFieldSettings();
            }
        }

        private void minTimesRadioButton_CheckedChanged(object sender, EventArgs e) {
            if(minTimesRadioButton.Checked) {
                currAlgebra = MinTimes;
                mulFieldSettings();
            }
        }

        private void minDivRadioButton_CheckedChanged(object sender, EventArgs e) {
            if(minDivRadioButton.Checked) {
                currAlgebra = MinDiv;
                mulFieldSettings();
            }
        }

        private void maxDivRadioButton_CheckedChanged(object sender, EventArgs e) {
            if(maxDivRadioButton.Checked) {
                currAlgebra = MaxDiv;
                mulFieldSettings();
            }
        }

        private void sumFieldSettings() {
            inftyCheck = false;
            nonNegativeField = false;
            step = 0.01;
        }

        private void mulFieldSettings() {
            inftyCheck = true;
            nonNegativeField = true;
            step = 0.1;

            double from = Convert.ToDouble(xFromTextBox.Text);
            from = from < 0 ? 0 : from;
            double to = Convert.ToDouble(xToTextBox.Text);
            to = to < from ? from+10 : to;

            xFromTextBox.Text = from.ToString();
            xToTextBox.Text = to.ToString();
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

            string pattern = "[a-wyzA-WYZа-яА-Я]";
            var m = Regex.Match(pRichTextBox.Text, pattern);
            if(m.Success) 
                return ErrorCodes.P_UNCORRECT;

            m = Regex.Match(qRichTextBox.Text, pattern);
            if(m.Success) 
                return ErrorCodes.Q_UNCORRECT;

            if(!isCurrentAlgebraExpressionCorrect(pRichTextBox.Text)) {
                return ErrorCodes.P_UNCORRECT;
            }

            if(!isCurrentAlgebraExpressionCorrect(qRichTextBox.Text)) {
                return ErrorCodes.Q_UNCORRECT;
            }

            if(fRichTextBox.Text.Length > 0 && !isConventionalAlgebraExpressionCorrect(fRichTextBox.Text)) {
                return ErrorCodes.F_UNCORRECT;
            }

            return ErrorCodes.ALL_IS_GOOD;
        }

        bool isCurrentAlgebraExpressionCorrect(string expression) {
            bool result = true;
            var x = Var("x");

            try {
                currAlgebra(expression.Substitute(x, 0.4));
                currAlgebra(expression.Substitute(x, -0.4));
                currAlgebra(expression.Substitute(x, 0.0));
            }
            catch {
                result = false;
            }

            return result;
        }

        bool isConventionalAlgebraExpressionCorrect(string expression) {
            bool result = true;
            var x = Var("x");

            try {
                expression.Substitute(x, 0.4).EvalNumerical();
                expression.Substitute(x, 0.0).EvalNumerical();
                if(!nonNegativeField) {
                    expression.Substitute(x, -0.4).EvalNumerical();
                }
            }
            catch {
                result = false;
            }

            return result;
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

        private void aboutToolStripLabel_Click(object sender, EventArgs e) {
            string version = $"{Properties.Settings.Default["version"]}v";
            string Merzalov = "TropicalPalm названа в честь пальмы Мерцалова.";
            string ico = "Пальма icon by Icons8";
            string message = $"{version}\n\n{Merzalov}\n\n{ico}";
            MessageBox.Show(message, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void openFileButton_Click(object sender, EventArgs e) {
            OpenFileDialog openFileDialog = new() {
                Filter = "Текстовые файлы (*.txt)|*.txt",
                AddExtension = true
            };
            openFileDialog.ShowDialog();

            if(openFileDialog.FileName.Length > 0) {
                preProcessFilePolynomials(openFileDialog.FileName);
            }
        }

        private void preProcessFilePolynomials(string path) {
            string content;

            using(StreamReader sr = new(path)) {
                content = sr.ReadToEnd();
            }

            string pattern = "[a-zA-Zа-яА-Я!@#$%^&*()+=/\\\'\"| ]";
            var m = Regex.Match(content, pattern);
            if(m.Success) {
                MessageBox.Show("Ошибка в данных!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            content = content.Trim();

            string[] polynomials = content.Split(new[] { $"{Environment.NewLine}{Environment.NewLine}" }, StringSplitOptions.None);

            if(polynomials.Length % 2 == 1) {
                MessageBox.Show("Нечётное количество полиномов!\nИли ошибка в данных!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
