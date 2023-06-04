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
using TropicalPalm.Forms;

namespace TropicalPalm {

    public partial class Form1:Form {
        struct PolynomialPair {
            string p;
            public string P { get; set; }
            string q;
            public string Q { get; set; }
        }

        PolynomialPair[] polynomialPairs;

        static bool nonNegativeField;
        public static bool NonNegativeField {
            get => nonNegativeField;
            set => nonNegativeField = value;
        }

        public Form1() {
            InitializeComponent();
            BuildButton.Click += manualInput;
        }

        private void Form1_Load(object sender, EventArgs e) {
            TropApprox.Current.Algebra = TropApprox.MaxPlus.Instance;
            sumFieldSettings();
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

        private void showRmse(Number.Real rootMeanSquaredError) {
            if(rootMeanSquaredError != -1) {
                string RMSE = rootMeanSquaredError.ToString();
                var dotIndex = RMSE.IndexOf('.');
                RMSE = RMSE.Length > dotIndex + 3 ? RMSE.Substring(0, dotIndex + 3) : RMSE;
                rootMeanSquaredErrorValueLabel.Text = RMSE;
                rootMeanSquaredErrorValueLabel.Visible = true;
                rootMeanSquaredErrorLabel.Visible = true;
            }
            else {
                rootMeanSquaredErrorValueLabel.Visible = false;
                rootMeanSquaredErrorLabel.Visible = false;
            }
        }

        private void plotArrays(Tools.PlotStruct ps) {
            plot.Plot.Clear();
            var dxArr = Tools.RealToDouble(ps.XArr);
            var dpY = Tools.RealToDouble(ps.PY);
            plot.Plot.AddScatter(dxArr, dpY, label: "P");

            if(ps.QY[0] != null) {
                var dqY = Tools.RealToDouble(ps.QY);
                var dpbyqY = Tools.RealToDouble(ps.PbyQY);
                plot.Plot.AddScatter(dxArr, dqY, label: "Q");
                plot.Plot.AddScatter(dxArr, dpbyqY, label: "P/Q");
            }

            if(ps.FY[0] != null) {
                var dfY = Tools.RealToDouble(ps.FY);
                plot.Plot.AddScatter(dxArr, dfY, label: "f");
                if(errorFuncCheckBox.Checked) {
                    var derrY = Tools.RealToDouble(ps.ErrY);
                    plot.Plot.AddScatter(dxArr, derrY, label: "error");
                }
            }

            plot.Plot.Legend();
            plot.Refresh();
        }

        private void plotArrays(Number.Real[] pY, Number.Real[] qY, Number.Real[] pbyqY, Number.Real[] fY, Number.Real[] errY, Number.Real[] xArr)
            => plotArrays(new Tools.PlotStruct(pY, qY, pbyqY, fY, errY, xArr));

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
            ArraysFiller.Step = (Number.Real)1 / 100;
        }

        private void mulFieldSettings() {
            ArraysFiller.InftyCheck = true;
            nonNegativeField = true;
            ArraysFiller.Step = (Number.Real)1 / 10;

            double from = Convert.ToDouble(xFromTextBox.Text);
            from = from < 0 ? 0 : from;
            double to = Convert.ToDouble(xToTextBox.Text);
            to = to < from ? from + 10 : to;

            xFromTextBox.Text = from.ToString();
            xToTextBox.Text = to.ToString();
        }

        private void aboutToolStripLabel_Click(object sender, EventArgs e) {
            string version = $"{Properties.Settings.Default["version"]}v";
            string Merzalov = "TropicalPalm названа в честь пальмы Мерцалова.";
            string ico = "Пальма icon by Icons8";
            string message = $"{version}\n\n{Merzalov}\n\n{ico}";
            MessageBox.Show(message, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void BuildButton_Click(object sender, EventArgs e) {
            ArraysFiller.XFrom = Convert.ToDouble(xFromTextBox.Text);
            ArraysFiller.F = fRichTextBox.Text;
        }

        private void manualInput(object sender, EventArgs e) {
            Validation.ErrorCodes errorCode = Validation.checkInput(pRichTextBox.Text, qRichTextBox.Text, xFromTextBox.Text, xToTextBox.Text, fRichTextBox.Text);

            if(errorCode != Validation.ErrorCodes.ALL_IS_GOOD) {
                Validation.showError(errorCode);
                return;
            }

            int range = Tools.calculateRange(xFromTextBox.Text, xToTextBox.Text);

            bool onePolynomial = pRichTextBox.Text.Length > 0 ^ qRichTextBox.Text.Length > 0;
            bool isApproximating = fRichTextBox.Text.Length > 0;

            var ps = new Tools.PlotStruct(range);

            Number.Real rootMeanSquaredError;

            try {
                if(onePolynomial) {
                    rootMeanSquaredError = ArraysFiller.fillArrays(pRichTextBox.Text + qRichTextBox.Text, ps.PY, ps.FY, ps.ErrY, ps.XArr, range);
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
                if(!Validation.isConventionalAlgebraExpressionCorrect(fRichTextBox.Text)) {
                    MessageBox.Show("Ошибка в аппроксимируемой функции", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if(polynomialPairs is null) {
                MessageBox.Show("Не выбран файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            progressBar.Value = 0;
            selectBestRationalFunction(polynomialPairs);
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
            if(Validation.containsInappropriateCharacters(content)) {
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

        private void selectBestRationalFunction(PolynomialPair[] _polynomialPairs) {
            using var _ = MathS.Settings.DowncastingEnabled.Set(false);
            int range = Tools.calculateRange(xFromTextBox.Text, xToTextBox.Text);

            var ps = new Tools.PlotStruct(range);

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
                _polynomialPairs[j].P = Tools.stringToPolynomial(polynomials[i]);
                _polynomialPairs[j].Q = Tools.stringToPolynomial(polynomials[i + 1]);
            }

            return _polynomialPairs;
        }

        private void runApproximateBuild(object sender, EventArgs e) {
            if(fRichTextBox.Text.Length == 0) {
                MessageBox.Show("Поле аппроксимируемой функции -- пустое. ",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            if(!Validation.isConventionalAlgebraExpressionCorrect(fRichTextBox.Text)) {
                MessageBox.Show("Ошибка в аппроксимируемой функции", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            using var _ = MathS.Settings.DowncastingEnabled.Set(false);

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

            var func = fRichTextBox.Text;

            disableControls();
            pRichTextBoxROA.Text = "";
            qRichTextBoxROA.Text = "";
            Task.Run(() => approximateBuild(func, xs, mLeft, mRight));
        }

        private void approximateBuild(string fucntion, Entity.Matrix vector, int mLeft, int mRight) {
            using var _ = MathS.Settings.DowncastingEnabled.Set(false);
            int range = Tools.calculateRange(xFromTextBox.Text, xToTextBox.Text);
            var ps = new Tools.PlotStruct(range);

            Number.Real rootMeanSquaredError;

            int d = Convert.ToInt32(dNumericUpDown.Value);

            Entity P = null;
            if(polynomialRadioButton.Checked) {
                P = TropApprox.Approx.ApproximateFunctionWithPolynomial(fucntion, vector, mLeft, mRight, d);
                P = TropApprox.TropicalPolynomial.CreatePolynomial((Entity.Matrix)P, mLeft, mRight);
                rootMeanSquaredError = ArraysFiller.fillArrays(P.ToString(), ps.PY, ps.FY, ps.ErrY, ps.XArr, range);

                pRichTextBoxROA.Invoke(() => pRichTextBoxROA.Text = Tools.processCoeffs(P));
            }
            else {
                Entity Q = null;
                Task<Entity> rational = Task.Run(() => TropApprox.Approx.ApproximateFunction(fucntion, vector, mLeft, mRight, out P, out Q, d));
                rational.Wait();
                pRichTextBoxROA.Invoke(() => pRichTextBoxROA.Text = Tools.processCoeffs(P));
                qRichTextBoxROA.Invoke(() => qRichTextBoxROA.Text = Tools.processCoeffs(Q));

                rootMeanSquaredError = ArraysFiller.fillArrays(P.ToString(), Q.ToString(), ps.PY, ps.QY, ps.PbyQY, ps.FY, ps.ErrY, ps.XArr, range);
            }

            Invoke(() => showRmse(rootMeanSquaredError));

            Invoke(() => plotArrays(ps));

            Invoke(() => enableControls());
        }

        private void ChangeControlsEnable(bool enable) {
            tabControl.Enabled = enable;
            BuildButton.Enabled = enable;
        }

        private void disableControls() {
            ChangeControlsEnable(false);
        }

        private void enableControls() {
            ChangeControlsEnable(true);
        }

        void changeBorders(Entity.Matrix vector) {
            double min, max;
            Tools.findMinMaxInVector(vector, out min, out max);
            xFromTextBox.Invoke(() => xFromTextBox.Text = min.ToString());
            xToTextBox.Invoke(() => xToTextBox.Text = max.ToString());
        }

        private void nonSymmetryPowersCheckBox_CheckedChanged(object sender, EventArgs e) {
            mRightNumericUpDown.Visible = nonSymmetryPowersCheckBox.Checked;
            mLeftNumericUpDown.Minimum = nonSymmetryPowersCheckBox.Checked ? -100 : 0;
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e) {
            BuildButton.Click -= manualInput;
            BuildButton.Click -= fromFile;
            BuildButton.Click -= runApproximateBuild;

            switch(tabControl.SelectedIndex) {
                case 0:
                    unblockAlgebras();
                    BuildButton.Click += manualInput;
                    return;
                case 1:
                    unblockAlgebras();
                    BuildButton.Click += fromFile;
                    return;
                case 2:
                    blockAlgebras();
                    BuildButton.Click += runApproximateBuild;
                    return;
            }
        }

        private void blockAlgebras() {
            if(rationalRadioButton.Checked) {
                maxPlusRadioButton.Checked = true;
                minPlusRadioButton.Enabled = false;
                maxTimesRadioButton.Enabled = false;
                minTimesRadioButton.Enabled = false;
            }
            else {
                if(maxTimesRadioButton.Checked || minTimesRadioButton.Checked) {
                    maxPlusRadioButton.Checked = true;
                }
                minPlusRadioButton.Enabled = true;
                maxTimesRadioButton.Enabled = false;
                minTimesRadioButton.Enabled = false;
            }
        }

        private void unblockAlgebras() {
            maxPlusRadioButton.Enabled = true;
            minPlusRadioButton.Enabled = true;
            maxTimesRadioButton.Enabled = true;
            minTimesRadioButton.Enabled = true;
        }

        private void rationalRadioButton_CheckedChanged(object sender, EventArgs e) {
            blockAlgebras();
        }

        private void settingsToolStripLabel_Click(object sender, EventArgs e) {
            var settings = new Forms.Settings();
            settings.ShowDialog();
        }
    }
}
