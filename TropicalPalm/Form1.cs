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
using System.Diagnostics;

namespace TropicalPalm {

    public partial class Form1:Form {
        PolynomialPair[] polynomialPairs;
        bool nonNegativeField;

        public Form1() {
            InitializeComponent();
            BuildButton.Click += manualInput;
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
            ArraysFiller.XFrom = Convert.ToDouble(xFromTextBox.Text);
            ArraysFiller.F = fRichTextBox.Text;
        }

        public struct PlotStruct {
            Number.Real[] pY;
            public Number.Real[] PY { get => pY; }
            Number.Real[] qY;
            public Number.Real[] QY { get => qY; }
            Number.Real[] pbyqY;
            public Number.Real[] PbyQY { get => pbyqY; }
            Number.Real[] fY;
            public Number.Real[] FY { get => fY; }
            Number.Real[] errY;
            public Number.Real[] ErrY { get => errY; }
            Number.Real[] xArr;
            public Number.Real[] XArr { get => xArr; }

            public PlotStruct(int range) {
                pY = new Number.Real[range];
                qY = new Number.Real[range];
                pbyqY = new Number.Real[range];
                fY = new Number.Real[range];
                errY = new Number.Real[range];
                xArr = new Number.Real[range];
            }
        }

        private void manualInput(object sender, EventArgs e) {
            ErrorCodes errorCode = checkInput();

            if(errorCode != ErrorCodes.ALL_IS_GOOD) {
                showError(errorCode);
                return;
            }

            int range = calculateRange();

            bool onePolynomial = pRichTextBox.Text.Length > 0 ^ qRichTextBox.Text.Length > 0;
            bool isApproximating = fRichTextBox.Text.Length > 0;

            var ps = new PlotStruct(range);

            Number.Real rootMeanSquaredError;

            try {
                if(onePolynomial) {
                    rootMeanSquaredError = ArraysFiller.fillArrays(pRichTextBox.Text+qRichTextBox.Text, ps.PY, ps.FY, ps.ErrY, ps.XArr, range);
                }
                else {
                    rootMeanSquaredError = ArraysFiller.fillArrays(pRichTextBox.Text, qRichTextBox.Text, ps.PY, ps.QY, ps.PbyQY, ps.FY, ps.ErrY, ps.XArr, range);
                }
            }
            catch(NotFiniteNumberException ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            showRmse(rootMeanSquaredError);

            plotArrays(ps);
        }

        private void fromFile(object sender, EventArgs e) {
            if(fRichTextBox.Text.Length == 0) {
                var result = MessageBox.Show("Поле аппроксимируемой функции -- пустое. Продолжить?",
                                             "Внимание",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);

                if(result == DialogResult.No) {
                    return;
                }
            }
            else {
                if(!isConventionalAlgebraExpressionCorrect(fRichTextBox.Text)) {
                    MessageBox.Show("Ошибка в аппроксимируемой функции", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            progressBar.Value = 0;
            selectBestRationalFunction(polynomialPairs);
        }

        private void approximateBuild(object sender, EventArgs e) {
            if(fRichTextBox.Text.Length == 0) {
                MessageBox.Show("Поле аппроксимируемой функции -- пустое. ",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            int mLeft = Convert.ToInt32(mLeftNumericUpDown.Value);
            int mRight;
            if(nonSymmetryPowersCheckBox.Checked) {
                mRight = Convert.ToInt32(mRightNumericUpDown.Value);
                if(mLeft > mRight) {
                    MessageBox.Show("Левое значение должно быть не больше правого.",
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }
            }
            else {
                mRight = mLeft;
                mLeft *= -1;
            }

            Entity.Matrix xs = null;
            
            try {
                xs = (Entity.Matrix)$"[{xsRichTextBox.Text}]";
                if(!xs.IsVector || xs.RowCount < 1) {
                    throw new Exception();
                }
            }
            catch {
                MessageBox.Show("Ошибка в наборе значений x.",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            if(changeBordersCheckBox.Checked) {
                changeBorders(xs);
                ArraysFiller.XFrom = Convert.ToDouble(xFromTextBox.Text);
            }

            int range = calculateRange();
            var ps = new PlotStruct(range);

            Number.Real rootMeanSquaredError;

            int d = Convert.ToInt32(dNumericUpDown.Value);

            Entity P = null;
            var func = fRichTextBox.Text;
            if(polynomialRadioButton.Checked) {
                Task<Entity.Matrix> pol = Task.Run(() => TropApprox.Approx.ApproximateFunctionWithPolynomial(func, xs, mLeft, mRight, d));
                pol.Wait();
                P = TropApprox.TropicalPolynomial.CreatePolynomial(pol.Result, mLeft, mRight);
                rootMeanSquaredError = ArraysFiller.fillArrays(P.ToString(), ps.PY, ps.FY, ps.ErrY, ps.XArr, range);

                pRichTextBoxROA.Text = TrimZeros(P);
            }
            else {
                Entity Q = null;
                Task<Entity> rational = Task.Run(() => TropApprox.Approx.ApproximateFunction(func, xs, mLeft, mRight, out P, out Q, d));
                rational.Wait();
                pRichTextBoxROA.Text = TrimZeros(P);
                qRichTextBoxROA.Text = TrimZeros(Q);

                rootMeanSquaredError = ArraysFiller.fillArrays(P.ToString(), Q.ToString(), ps.PY, ps.QY, ps.PbyQY, ps.FY, ps.ErrY, ps.XArr, range);
            }

            showRmse(rootMeanSquaredError);

            plotArrays(ps);
        }

        void changeBorders(Entity.Matrix vector) {
            double min, max;
            findMinMaxInVector(vector, out min, out max);
            xFromTextBox.Invoke(() => xFromTextBox.Text = min.ToString());
            xToTextBox.Invoke(() => xToTextBox.Text = max.ToString());
        }

        void findMinMaxInVector(Entity.Matrix vector, out double min, out double max) {
            if(vector.RowCount == 0) {
                throw new ArgumentException("Vector must contain values");
            }

            min = double.MaxValue;
            max = double.MinValue;
            for(int i = 0; i < vector.RowCount; i++) {
                double v = (double)(Number.Real)vector[i];
                if(v < min) {
                    min = v;
                }
                if(v > max) {
                    max = v;
                }
            }
        }

        string TrimZeros(Entity entity) {
            string result = "";
            string temp;
            var arr = entity.ToString().Split(" ");
            foreach(var entry in arr) {
                if(entry.Contains('E')) {
                    result += $"({entry})";
                    continue;
                }

                if(!entry.Contains('.')) {
                    result += entry;
                    continue;
                }

                if(entry[^1] == ')') {
                    temp = entry.TrimEnd(')');
                    temp = temp.TrimEnd('0');
                    temp = temp.Length == 0 ? "0" : temp;
                    temp += ')';
                }
                else {
                    temp = entry.TrimEnd('0');
                    temp = temp.Length == 0 ? "0" : temp;
                }
                
                result += temp;
            }

            return result;
        }

        private int calculateRange() {
            double to, from;
            from = Convert.ToDouble(xFromTextBox.Text);
            to = Convert.ToDouble(xToTextBox.Text);

            return (int)Math.Ceiling(Math.Abs(to - from) / (double)ArraysFiller.Step) + 1;
        }

        private void showRmse(Number.Real rootMeanSquaredError) {
            if(rootMeanSquaredError != -1) {
                string RMSE = rootMeanSquaredError.ToString();
                var dotIndex = RMSE.IndexOf('.');
                RMSE = RMSE.Length > dotIndex+3 ? RMSE.Substring(0, dotIndex + 3) : RMSE;
                rootMeanSquaredErrorValueLabel.Text = RMSE;
                rootMeanSquaredErrorValueLabel.Visible = true;
                rootMeanSquaredErrorLabel.Visible = true;
            }
            else {
                rootMeanSquaredErrorValueLabel.Visible = false;
                rootMeanSquaredErrorLabel.Visible = false;
            }
        }

        private void plotArrays(PlotStruct ps) {
            plot.Plot.Clear();
            var dxArr = RealToDouble(ps.XArr);
            var dpY = RealToDouble(ps.PY);
            plot.Plot.AddScatter(dxArr, dpY, label: "P");

            if(ps.QY[0] != null) {
                var dqY = RealToDouble(ps.QY);
                var dpbyqY = RealToDouble(ps.PbyQY);
                plot.Plot.AddScatter(dxArr, dqY, label: "Q");
                plot.Plot.AddScatter(dxArr, dpbyqY, label: "P/Q");
            }

            if(ps.PY[0] != null) {
                var dfY = RealToDouble(ps.FY);
                plot.Plot.AddScatter(dxArr, dfY, label: "f");
                if(errorFuncCheckBox.Checked) {
                    var derrY = RealToDouble(ps.ErrY);
                    plot.Plot.AddScatter(dxArr, derrY, label: "error");
                }
            }

            plot.Plot.Legend();
            plot.Refresh();
        }

        private void plotArrays(Number.Real[] pY, Number.Real[] qY, Number.Real[] pbyqY, Number.Real[] fY, Number.Real[] errY, Number.Real[] xArr) {
            plot.Plot.Clear();
            var dxArr = RealToDouble(xArr);
            var dpY = RealToDouble(pY);
            plot.Plot.AddScatter(dxArr, dpY, label: "P");

            if(qY != null) {
                var dqY = RealToDouble(qY);
                var dpbyqY = RealToDouble(pbyqY);
                plot.Plot.AddScatter(dxArr, dqY, label: "Q");
                plot.Plot.AddScatter(dxArr, dpbyqY, label: "P/Q");
            }

            if(fY != null) {
                var dfY = RealToDouble(fY);
                plot.Plot.AddScatter(dxArr, dfY, label: "f");
                if(errorFuncCheckBox.Checked) {
                    var derrY = RealToDouble(errY);
                    plot.Plot.AddScatter(dxArr, derrY, label: "error");
                }
            }

            plot.Plot.Legend();
            plot.Refresh();
        }

        private double[] RealToDouble(Number.Real[] arr) {
            double[] result = new double[arr.Length];

            for(int i = 0; i < arr.Length; i++) {
                result[i] = (double)arr[i];
            }

            return result;
        }

        private void Form1_Load(object sender, EventArgs e) {
            TropApprox.Current.Algebra = TropApprox.MaxPlus.Instance;
            sumFieldSettings();
        }

        private void minPlusRadioButton_CheckedChanged(object sender, EventArgs e) {
            if(minPlusRadioButton.Checked) {
                TropApprox.Current.Algebra = TropApprox.MinPlus.Instance;
                sumFieldSettings();
            }
        }

        private void maxPlusRadioButton_CheckedChanged(object sender, EventArgs e) {
            if(maxPlusRadioButton.Checked) {
                TropApprox.Current.Algebra = TropApprox.MaxPlus.Instance;
                sumFieldSettings();
            }
        }

        private void maxTimesRadioButton_CheckedChanged(object sender, EventArgs e) {
            if(maxTimesRadioButton.Checked) {
                TropApprox.Current.Algebra = TropApprox.MaxTimes.Instance;
                mulFieldSettings();
            }
        }

        private void minTimesRadioButton_CheckedChanged(object sender, EventArgs e) {
            if(minTimesRadioButton.Checked) {
                TropApprox.Current.Algebra = TropApprox.MinTimes.Instance;
                mulFieldSettings();
            }
        }

        private void sumFieldSettings() {
            ArraysFiller.InftyCheck = false;
            nonNegativeField = false;
            ArraysFiller.Step = (Number.Real)1/100;
        }

        private void mulFieldSettings() {
            ArraysFiller.InftyCheck = true;
            nonNegativeField = true;
            ArraysFiller.Step = (Number.Real)1 /10;

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
            if(pRichTextBox.Text.Length == 0 && qRichTextBox.Text.Length == 0)
                return ErrorCodes.POLYNOMIALS_EMPTY;

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

            string pattern = "[arr-wyzA-WYZа-яА-Я]";
            var m = Regex.Match(pRichTextBox.Text, pattern);
            if(m.Success) 
                return ErrorCodes.P_UNCORRECT;

            m = Regex.Match(qRichTextBox.Text, pattern);
            if(m.Success) 
                return ErrorCodes.Q_UNCORRECT;

            if(pRichTextBox.Text.Length > 0 && !isCurrentAlgebraExpressionCorrect(pRichTextBox.Text)) {
                return ErrorCodes.P_UNCORRECT;
            }

            if(qRichTextBox.Text.Length > 0 && !isCurrentAlgebraExpressionCorrect(qRichTextBox.Text)) {
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
                TropApprox.Current.Algebra.Calculate(expression.Substitute(x,(Number.Real)4/10));
                if(!nonNegativeField) {
                    TropApprox.Current.Algebra.Calculate(expression.Substitute(x, -0.4));
                    TropApprox.Current.Algebra.Calculate(expression.Substitute(x, 0));
                }
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

                case ErrorCodes.POLYNOMIALS_EMPTY:
                    MessageBox.Show("P(x) or Q(x) must be filled in!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            POLYNOMIALS_EMPTY = 10,
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
                string content;

                using(StreamReader sr = new(openFileDialog.FileName)) {
                    content = sr.ReadToEnd();
                }
                polynomialPairs = preProcessFilePolynomials(content);

                if(polynomialPairs != null) {
                    pathLabel.Text = openFileDialog.FileName;
                    pRichTextBoxRO.Text = "";
                    qRichTextBoxRO.Text = "";
                }
            }
        }

        private PolynomialPair[] preProcessFilePolynomials(string content) {
            if(containsInappropriateCharacters(content)) {
                MessageBox.Show("Ошибка в данных!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            content = content.Trim();

            string[] polynomials = content.Split(new[] { $"{Environment.NewLine}{Environment.NewLine}" }, StringSplitOptions.None);

            if(polynomials.Length % 2 == 1) {
                MessageBox.Show("Нечётное количество полиномов!\nИли ошибка в данных!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            return makePolynomialPairs(polynomials);
        }

        private bool containsInappropriateCharacters(string content) {
            return !Regex.Match(content, $"[1-9.{Environment.NewLine}\t]").Success;
        }

        private void selectBestRationalFunction(PolynomialPair[] _polynomialPairs) {
            int range = calculateRange();

            var ps = new PlotStruct(range);

            Number.Real minRmse = Number.Real.PositiveInfinity;
            Number.Real rmse;
            double progress = 0;
            double progressStep = 100 / _polynomialPairs.Length;
            foreach(PolynomialPair polynomialPair in _polynomialPairs) {
                rmse = ArraysFiller.fillArrays(polynomialPair.P, polynomialPair.Q, ps.PY, ps.QY, ps.PbyQY, ps.FY, ps.ErrY, ps.XArr, range);
                if(rmse <= minRmse) {
                    pRichTextBoxRO.Text = polynomialPair.P;
                    qRichTextBoxRO.Text = polynomialPair.Q;
                    plotArrays(ps);
                    showRmse(rmse);
                    minRmse = rmse;
                }
                progress += progressStep;
                progressBar.Value = (int)progress;
            }
            progressBar.Value = 100;
        }

        private PolynomialPair[] makePolynomialPairs(string[] polynomials) {
            PolynomialPair[] _polynomialPairs = new PolynomialPair[polynomials.Length / 2];
            for(int i = 0, j = 0; i < polynomials.Length; i += 2, j++) {
                _polynomialPairs[j].P = stringToPolynomial(polynomials[i]);
                _polynomialPairs[j].Q = stringToPolynomial(polynomials[i + 1]);
            }

            return _polynomialPairs;
        }

        private string stringToPolynomial(string rawPolynomial) {
            string polynomial = "";
            string[] nomials = rawPolynomial.Split($"{Environment.NewLine}");
            foreach(string n in nomials) {
                string[] line = n.Split('\t');
                string coeff = line[0], power = line[1];
                polynomial += $"({coeff})*x^({power})+";
            }
            return polynomial[..^1];
        }

        struct PolynomialPair {
            string p;
            public string P { get; set; }
            string q;
            public string Q { get; set; }
        }

        private void nonSymmetryPowersCheckBox_CheckedChanged(object sender, EventArgs e) {
            mRightNumericUpDown.Visible = nonSymmetryPowersCheckBox.Checked;
            mLeftNumericUpDown.Minimum = nonSymmetryPowersCheckBox.Checked ? -100 : 0;
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e) {
            BuildButton.Click -= manualInput;
            BuildButton.Click -= fromFile;
            BuildButton.Click -= approximateBuild;

            switch(tabControl.SelectedIndex) {
                case 0:
                    BuildButton.Click += manualInput;
                    return;
                case 1:
                    BuildButton.Click += fromFile;
                    return;
                case 2:
                    BuildButton.Click += approximateBuild;
                    return;
            }

        }
    }
}
