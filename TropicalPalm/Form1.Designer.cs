namespace TropicalPalm {
    partial class Form1 {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            plot = new ScottPlot.FormsPlot();
            toolTip = new System.Windows.Forms.ToolTip(components);
            qRichTextBox = new System.Windows.Forms.RichTextBox();
            pRichTextBox = new System.Windows.Forms.RichTextBox();
            fRichTextBox = new System.Windows.Forms.RichTextBox();
            BuildButton = new System.Windows.Forms.Button();
            qRichTextBoxRO = new System.Windows.Forms.RichTextBox();
            pRichTextBoxRO = new System.Windows.Forms.RichTextBox();
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            aboutToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            settingsToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            rootMeanSquaredErrorValueLabel = new System.Windows.Forms.Label();
            rootMeanSquaredErrorLabel = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            tabControl = new System.Windows.Forms.TabControl();
            manualTabPage = new System.Windows.Forms.TabPage();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            AutoTabPage = new System.Windows.Forms.TabPage();
            progressBar = new System.Windows.Forms.ProgressBar();
            pathHolderLabel = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            pathLabel = new System.Windows.Forms.Label();
            openFileButton = new System.Windows.Forms.Button();
            label11 = new System.Windows.Forms.Label();
            ApproximateTabPage = new System.Windows.Forms.TabPage();
            qRichTextBoxROA = new System.Windows.Forms.RichTextBox();
            changeBordersCheckBox = new System.Windows.Forms.CheckBox();
            rationalRadioButton = new System.Windows.Forms.RadioButton();
            label12 = new System.Windows.Forms.Label();
            polynomialRadioButton = new System.Windows.Forms.RadioButton();
            nonSymmetryPowersCheckBox = new System.Windows.Forms.CheckBox();
            label13 = new System.Windows.Forms.Label();
            pRichTextBoxROA = new System.Windows.Forms.RichTextBox();
            mRightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            xsRichTextBox = new System.Windows.Forms.RichTextBox();
            label5 = new System.Windows.Forms.Label();
            mLeftNumericUpDown = new System.Windows.Forms.NumericUpDown();
            label9 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            dNumericUpDown = new System.Windows.Forms.NumericUpDown();
            label3 = new System.Windows.Forms.Label();
            maxPlusRadioButton = new System.Windows.Forms.RadioButton();
            maxTimesRadioButton = new System.Windows.Forms.RadioButton();
            minPlusRadioButton = new System.Windows.Forms.RadioButton();
            minTimesRadioButton = new System.Windows.Forms.RadioButton();
            groupBox1 = new System.Windows.Forms.GroupBox();
            label6 = new System.Windows.Forms.Label();
            xFromTextBox = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            xToTextBox = new System.Windows.Forms.TextBox();
            errorFuncCheckBox = new System.Windows.Forms.CheckBox();
            toolStrip1.SuspendLayout();
            tabControl.SuspendLayout();
            manualTabPage.SuspendLayout();
            AutoTabPage.SuspendLayout();
            ApproximateTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mRightNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mLeftNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dNumericUpDown).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // plot
            // 
            plot.Location = new System.Drawing.Point(508, 12);
            plot.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            plot.Name = "plot";
            plot.Size = new System.Drawing.Size(901, 553);
            plot.TabIndex = 19;
            // 
            // toolTip
            // 
            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 500;
            toolTip.ReshowDelay = 100;
            // 
            // qRichTextBox
            // 
            qRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            qRichTextBox.Location = new System.Drawing.Point(96, 50);
            qRichTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            qRichTextBox.Multiline = false;
            qRichTextBox.Name = "qRichTextBox";
            qRichTextBox.Size = new System.Drawing.Size(313, 36);
            qRichTextBox.TabIndex = 38;
            qRichTextBox.Text = "";
            toolTip.SetToolTip(qRichTextBox, "Example: \r\n3*x^3+(-2)*x+1+x^(-0.5)\r\n");
            // 
            // pRichTextBox
            // 
            pRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            pRichTextBox.Location = new System.Drawing.Point(96, 6);
            pRichTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pRichTextBox.Multiline = false;
            pRichTextBox.Name = "pRichTextBox";
            pRichTextBox.Size = new System.Drawing.Size(313, 36);
            pRichTextBox.TabIndex = 35;
            pRichTextBox.Text = "";
            toolTip.SetToolTip(pRichTextBox, "Example: \r\n3*x^3+(-2)*x+1+x^(-0.5)");
            // 
            // fRichTextBox
            // 
            fRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            fRichTextBox.Location = new System.Drawing.Point(112, 352);
            fRichTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            fRichTextBox.Multiline = false;
            fRichTextBox.Name = "fRichTextBox";
            fRichTextBox.Size = new System.Drawing.Size(399, 36);
            fRichTextBox.TabIndex = 39;
            fRichTextBox.Text = "";
            toolTip.SetToolTip(fRichTextBox, "Example:\r\nx^2+2*x+3*e+sin(x)");
            // 
            // BuildButton
            // 
            BuildButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            BuildButton.Location = new System.Drawing.Point(33, 518);
            BuildButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            BuildButton.Name = "BuildButton";
            BuildButton.Size = new System.Drawing.Size(479, 76);
            BuildButton.TabIndex = 48;
            BuildButton.Text = "Build";
            toolTip.SetToolTip(BuildButton, "Click to build plot\r\nNB: P(x) and Q(x) are obligatory to be filled in");
            BuildButton.UseVisualStyleBackColor = true;
            BuildButton.Click += BuildButton_Click;
            // 
            // qRichTextBoxRO
            // 
            qRichTextBoxRO.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            qRichTextBoxRO.Location = new System.Drawing.Point(92, 53);
            qRichTextBoxRO.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            qRichTextBoxRO.Multiline = false;
            qRichTextBoxRO.Name = "qRichTextBoxRO";
            qRichTextBoxRO.ReadOnly = true;
            qRichTextBoxRO.Size = new System.Drawing.Size(313, 36);
            qRichTextBoxRO.TabIndex = 42;
            qRichTextBoxRO.Text = "";
            // 
            // pRichTextBoxRO
            // 
            pRichTextBoxRO.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            pRichTextBoxRO.Location = new System.Drawing.Point(92, 9);
            pRichTextBoxRO.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pRichTextBoxRO.Multiline = false;
            pRichTextBoxRO.Name = "pRichTextBoxRO";
            pRichTextBoxRO.ReadOnly = true;
            pRichTextBoxRO.Size = new System.Drawing.Size(313, 36);
            pRichTextBoxRO.TabIndex = 39;
            pRichTextBoxRO.Text = "";
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { aboutToolStripLabel, settingsToolStripLabel });
            toolStrip1.Location = new System.Drawing.Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new System.Drawing.Size(1398, 25);
            toolStrip1.TabIndex = 23;
            toolStrip1.Text = "toolStrip1";
            // 
            // aboutToolStripLabel
            // 
            aboutToolStripLabel.Name = "aboutToolStripLabel";
            aboutToolStripLabel.Size = new System.Drawing.Size(82, 22);
            aboutToolStripLabel.Text = "О программе";
            aboutToolStripLabel.Click += aboutToolStripLabel_Click;
            // 
            // settingsToolStripLabel
            // 
            settingsToolStripLabel.Name = "settingsToolStripLabel";
            settingsToolStripLabel.Size = new System.Drawing.Size(49, 22);
            settingsToolStripLabel.Text = "Settings";
            settingsToolStripLabel.Click += settingsToolStripLabel_Click;
            // 
            // rootMeanSquaredErrorValueLabel
            // 
            rootMeanSquaredErrorValueLabel.AutoSize = true;
            rootMeanSquaredErrorValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            rootMeanSquaredErrorValueLabel.Location = new System.Drawing.Point(621, 569);
            rootMeanSquaredErrorValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            rootMeanSquaredErrorValueLabel.Name = "rootMeanSquaredErrorValueLabel";
            rootMeanSquaredErrorValueLabel.Size = new System.Drawing.Size(0, 29);
            rootMeanSquaredErrorValueLabel.TabIndex = 26;
            rootMeanSquaredErrorValueLabel.Visible = false;
            // 
            // rootMeanSquaredErrorLabel
            // 
            rootMeanSquaredErrorLabel.AutoSize = true;
            rootMeanSquaredErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            rootMeanSquaredErrorLabel.Location = new System.Drawing.Point(520, 568);
            rootMeanSquaredErrorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            rootMeanSquaredErrorLabel.Name = "rootMeanSquaredErrorLabel";
            rootMeanSquaredErrorLabel.Size = new System.Drawing.Size(93, 29);
            rootMeanSquaredErrorLabel.TabIndex = 25;
            rootMeanSquaredErrorLabel.Text = "RMSE:";
            rootMeanSquaredErrorLabel.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label8.Location = new System.Drawing.Point(621, 565);
            label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(0, 29);
            label8.TabIndex = 26;
            label8.Visible = false;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(manualTabPage);
            tabControl.Controls.Add(AutoTabPage);
            tabControl.Controls.Add(ApproximateTabPage);
            tabControl.Location = new System.Drawing.Point(12, 28);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new System.Drawing.Size(505, 318);
            tabControl.TabIndex = 35;
            tabControl.SelectedIndexChanged += tabControl_SelectedIndexChanged;
            // 
            // manualTabPage
            // 
            manualTabPage.Controls.Add(qRichTextBox);
            manualTabPage.Controls.Add(label2);
            manualTabPage.Controls.Add(label1);
            manualTabPage.Controls.Add(pRichTextBox);
            manualTabPage.Location = new System.Drawing.Point(4, 24);
            manualTabPage.Name = "manualTabPage";
            manualTabPage.Padding = new System.Windows.Forms.Padding(3);
            manualTabPage.Size = new System.Drawing.Size(497, 290);
            manualTabPage.TabIndex = 0;
            manualTabPage.Text = "Manual";
            manualTabPage.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(46, 54);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(37, 18);
            label2.TabIndex = 37;
            label2.Text = "Q(x)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(48, 10);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(35, 18);
            label1.TabIndex = 36;
            label1.Text = "P(x)";
            // 
            // AutoTabPage
            // 
            AutoTabPage.Controls.Add(qRichTextBoxRO);
            AutoTabPage.Controls.Add(progressBar);
            AutoTabPage.Controls.Add(pathHolderLabel);
            AutoTabPage.Controls.Add(label10);
            AutoTabPage.Controls.Add(pathLabel);
            AutoTabPage.Controls.Add(openFileButton);
            AutoTabPage.Controls.Add(label11);
            AutoTabPage.Controls.Add(pRichTextBoxRO);
            AutoTabPage.Location = new System.Drawing.Point(4, 24);
            AutoTabPage.Name = "AutoTabPage";
            AutoTabPage.Padding = new System.Windows.Forms.Padding(3);
            AutoTabPage.Size = new System.Drawing.Size(497, 290);
            AutoTabPage.TabIndex = 1;
            AutoTabPage.Text = "Autoselect";
            AutoTabPage.UseVisualStyleBackColor = true;
            // 
            // progressBar
            // 
            progressBar.Location = new System.Drawing.Point(92, 133);
            progressBar.Name = "progressBar";
            progressBar.Size = new System.Drawing.Size(313, 32);
            progressBar.TabIndex = 58;
            // 
            // pathHolderLabel
            // 
            pathHolderLabel.AutoSize = true;
            pathHolderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            pathHolderLabel.Location = new System.Drawing.Point(44, 104);
            pathHolderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            pathHolderLabel.Name = "pathHolderLabel";
            pathHolderLabel.Size = new System.Drawing.Size(42, 18);
            pathHolderLabel.TabIndex = 56;
            pathHolderLabel.Text = "Path:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label10.Location = new System.Drawing.Point(42, 57);
            label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(37, 18);
            label10.TabIndex = 41;
            label10.Text = "Q(x)";
            // 
            // pathLabel
            // 
            pathLabel.AutoSize = true;
            pathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            pathLabel.Location = new System.Drawing.Point(92, 104);
            pathLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            pathLabel.Name = "pathLabel";
            pathLabel.Size = new System.Drawing.Size(0, 18);
            pathLabel.TabIndex = 57;
            // 
            // openFileButton
            // 
            openFileButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            openFileButton.Location = new System.Drawing.Point(412, 7);
            openFileButton.Name = "openFileButton";
            openFileButton.Size = new System.Drawing.Size(80, 80);
            openFileButton.TabIndex = 55;
            openFileButton.Text = "Open file";
            openFileButton.UseVisualStyleBackColor = true;
            openFileButton.Click += openFileButton_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label11.Location = new System.Drawing.Point(44, 13);
            label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(35, 18);
            label11.TabIndex = 40;
            label11.Text = "P(x)";
            // 
            // ApproximateTabPage
            // 
            ApproximateTabPage.Controls.Add(qRichTextBoxROA);
            ApproximateTabPage.Controls.Add(changeBordersCheckBox);
            ApproximateTabPage.Controls.Add(rationalRadioButton);
            ApproximateTabPage.Controls.Add(label12);
            ApproximateTabPage.Controls.Add(polynomialRadioButton);
            ApproximateTabPage.Controls.Add(nonSymmetryPowersCheckBox);
            ApproximateTabPage.Controls.Add(label13);
            ApproximateTabPage.Controls.Add(pRichTextBoxROA);
            ApproximateTabPage.Controls.Add(mRightNumericUpDown);
            ApproximateTabPage.Controls.Add(xsRichTextBox);
            ApproximateTabPage.Controls.Add(label5);
            ApproximateTabPage.Controls.Add(mLeftNumericUpDown);
            ApproximateTabPage.Controls.Add(label9);
            ApproximateTabPage.Controls.Add(label4);
            ApproximateTabPage.Controls.Add(dNumericUpDown);
            ApproximateTabPage.Location = new System.Drawing.Point(4, 24);
            ApproximateTabPage.Name = "ApproximateTabPage";
            ApproximateTabPage.Padding = new System.Windows.Forms.Padding(3);
            ApproximateTabPage.Size = new System.Drawing.Size(497, 290);
            ApproximateTabPage.TabIndex = 2;
            ApproximateTabPage.Text = "Approximate";
            ApproximateTabPage.UseVisualStyleBackColor = true;
            // 
            // qRichTextBoxROA
            // 
            qRichTextBoxROA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            qRichTextBoxROA.Location = new System.Drawing.Point(60, 60);
            qRichTextBoxROA.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            qRichTextBoxROA.Multiline = false;
            qRichTextBoxROA.Name = "qRichTextBoxROA";
            qRichTextBoxROA.ReadOnly = true;
            qRichTextBoxROA.Size = new System.Drawing.Size(419, 36);
            qRichTextBoxROA.TabIndex = 62;
            qRichTextBoxROA.Text = "";
            // 
            // changeBordersCheckBox
            // 
            changeBordersCheckBox.AutoSize = true;
            changeBordersCheckBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            changeBordersCheckBox.Location = new System.Drawing.Point(232, 220);
            changeBordersCheckBox.Name = "changeBordersCheckBox";
            changeBordersCheckBox.Size = new System.Drawing.Size(140, 25);
            changeBordersCheckBox.TabIndex = 64;
            changeBordersCheckBox.Text = "Change borders";
            changeBordersCheckBox.UseVisualStyleBackColor = true;
            // 
            // rationalRadioButton
            // 
            rationalRadioButton.AutoSize = true;
            rationalRadioButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            rationalRadioButton.Location = new System.Drawing.Point(173, 259);
            rationalRadioButton.Name = "rationalRadioButton";
            rationalRadioButton.Size = new System.Drawing.Size(85, 25);
            rationalRadioButton.TabIndex = 63;
            rationalRadioButton.Text = "Rational";
            rationalRadioButton.UseVisualStyleBackColor = true;
            rationalRadioButton.CheckedChanged += rationalRadioButton_CheckedChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label12.Location = new System.Drawing.Point(9, 64);
            label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(37, 18);
            label12.TabIndex = 61;
            label12.Text = "Q(x)";
            // 
            // polynomialRadioButton
            // 
            polynomialRadioButton.AutoSize = true;
            polynomialRadioButton.Checked = true;
            polynomialRadioButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            polynomialRadioButton.Location = new System.Drawing.Point(34, 259);
            polynomialRadioButton.Name = "polynomialRadioButton";
            polynomialRadioButton.Size = new System.Drawing.Size(105, 25);
            polynomialRadioButton.TabIndex = 62;
            polynomialRadioButton.TabStop = true;
            polynomialRadioButton.Text = "Polynomial";
            polynomialRadioButton.UseVisualStyleBackColor = true;
            // 
            // nonSymmetryPowersCheckBox
            // 
            nonSymmetryPowersCheckBox.AutoSize = true;
            nonSymmetryPowersCheckBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            nonSymmetryPowersCheckBox.Location = new System.Drawing.Point(36, 220);
            nonSymmetryPowersCheckBox.Name = "nonSymmetryPowersCheckBox";
            nonSymmetryPowersCheckBox.Size = new System.Drawing.Size(190, 25);
            nonSymmetryPowersCheckBox.TabIndex = 61;
            nonSymmetryPowersCheckBox.Text = "Non-symmetry powers";
            nonSymmetryPowersCheckBox.UseVisualStyleBackColor = true;
            nonSymmetryPowersCheckBox.CheckedChanged += nonSymmetryPowersCheckBox_CheckedChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label13.Location = new System.Drawing.Point(11, 20);
            label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(35, 18);
            label13.TabIndex = 60;
            label13.Text = "P(x)";
            // 
            // pRichTextBoxROA
            // 
            pRichTextBoxROA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            pRichTextBoxROA.Location = new System.Drawing.Point(59, 16);
            pRichTextBoxROA.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pRichTextBoxROA.Multiline = false;
            pRichTextBoxROA.Name = "pRichTextBoxROA";
            pRichTextBoxROA.ReadOnly = true;
            pRichTextBoxROA.Size = new System.Drawing.Size(419, 36);
            pRichTextBoxROA.TabIndex = 59;
            pRichTextBoxROA.Text = "";
            // 
            // mRightNumericUpDown
            // 
            mRightNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            mRightNumericUpDown.Location = new System.Drawing.Point(184, 160);
            mRightNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            mRightNumericUpDown.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            mRightNumericUpDown.Name = "mRightNumericUpDown";
            mRightNumericUpDown.Size = new System.Drawing.Size(140, 24);
            mRightNumericUpDown.TabIndex = 60;
            mRightNumericUpDown.Visible = false;
            // 
            // xsRichTextBox
            // 
            xsRichTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            xsRichTextBox.Location = new System.Drawing.Point(36, 116);
            xsRichTextBox.Name = "xsRichTextBox";
            xsRichTextBox.Size = new System.Drawing.Size(442, 32);
            xsRichTextBox.TabIndex = 59;
            xsRichTextBox.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(5, 122);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(26, 18);
            label5.TabIndex = 57;
            label5.Text = "Xs";
            // 
            // mLeftNumericUpDown
            // 
            mLeftNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            mLeftNumericUpDown.Location = new System.Drawing.Point(36, 160);
            mLeftNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            mLeftNumericUpDown.Name = "mLeftNumericUpDown";
            mLeftNumericUpDown.Size = new System.Drawing.Size(140, 24);
            mLeftNumericUpDown.TabIndex = 55;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label9.Location = new System.Drawing.Point(11, 192);
            label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(16, 18);
            label9.TabIndex = 58;
            label9.Text = "d";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(11, 162);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(21, 18);
            label4.TabIndex = 56;
            label4.Text = "M";
            // 
            // dNumericUpDown
            // 
            dNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dNumericUpDown.Location = new System.Drawing.Point(36, 190);
            dNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            dNumericUpDown.Name = "dNumericUpDown";
            dNumericUpDown.Size = new System.Drawing.Size(140, 24);
            dNumericUpDown.TabIndex = 57;
            dNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(71, 355);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(29, 18);
            label3.TabIndex = 40;
            label3.Text = "f(x)";
            // 
            // maxPlusRadioButton
            // 
            maxPlusRadioButton.AutoSize = true;
            maxPlusRadioButton.Checked = true;
            maxPlusRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            maxPlusRadioButton.Location = new System.Drawing.Point(8, 33);
            maxPlusRadioButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            maxPlusRadioButton.Name = "maxPlusRadioButton";
            maxPlusRadioButton.Size = new System.Drawing.Size(81, 22);
            maxPlusRadioButton.TabIndex = 0;
            maxPlusRadioButton.TabStop = true;
            maxPlusRadioButton.Text = "(max, +)";
            maxPlusRadioButton.UseVisualStyleBackColor = true;
            maxPlusRadioButton.CheckedChanged += maxPlusRadioButton_CheckedChanged;
            // 
            // maxTimesRadioButton
            // 
            maxTimesRadioButton.AutoSize = true;
            maxTimesRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            maxTimesRadioButton.Location = new System.Drawing.Point(9, 61);
            maxTimesRadioButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            maxTimesRadioButton.Name = "maxTimesRadioButton";
            maxTimesRadioButton.Size = new System.Drawing.Size(81, 22);
            maxTimesRadioButton.TabIndex = 1;
            maxTimesRadioButton.Text = "(max, ×)";
            maxTimesRadioButton.UseVisualStyleBackColor = true;
            maxTimesRadioButton.CheckedChanged += maxTimesRadioButton_CheckedChanged;
            // 
            // minPlusRadioButton
            // 
            minPlusRadioButton.AutoSize = true;
            minPlusRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            minPlusRadioButton.Location = new System.Drawing.Point(402, 33);
            minPlusRadioButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            minPlusRadioButton.Name = "minPlusRadioButton";
            minPlusRadioButton.Size = new System.Drawing.Size(77, 22);
            minPlusRadioButton.TabIndex = 2;
            minPlusRadioButton.Text = "(min, +)";
            minPlusRadioButton.UseVisualStyleBackColor = true;
            minPlusRadioButton.CheckedChanged += minPlusRadioButton_CheckedChanged;
            // 
            // minTimesRadioButton
            // 
            minTimesRadioButton.AutoSize = true;
            minTimesRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            minTimesRadioButton.Location = new System.Drawing.Point(402, 61);
            minTimesRadioButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            minTimesRadioButton.Name = "minTimesRadioButton";
            minTimesRadioButton.Size = new System.Drawing.Size(77, 22);
            minTimesRadioButton.TabIndex = 3;
            minTimesRadioButton.Text = "(min, ×)";
            minTimesRadioButton.UseVisualStyleBackColor = true;
            minTimesRadioButton.CheckedChanged += minTimesRadioButton_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(minTimesRadioButton);
            groupBox1.Controls.Add(minPlusRadioButton);
            groupBox1.Controls.Add(maxTimesRadioButton);
            groupBox1.Controls.Add(maxPlusRadioButton);
            groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            groupBox1.Location = new System.Drawing.Point(25, 418);
            groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox1.Size = new System.Drawing.Size(486, 94);
            groupBox1.TabIndex = 41;
            groupBox1.TabStop = false;
            groupBox1.Text = "Select algebra";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(52, 397);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(50, 18);
            label6.TabIndex = 44;
            label6.Text = "x from";
            // 
            // xFromTextBox
            // 
            xFromTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            xFromTextBox.Location = new System.Drawing.Point(114, 394);
            xFromTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            xFromTextBox.Name = "xFromTextBox";
            xFromTextBox.Size = new System.Drawing.Size(116, 24);
            xFromTextBox.TabIndex = 45;
            xFromTextBox.Text = "-10";
            xFromTextBox.KeyPress += TextBoxInputHandler;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label7.Location = new System.Drawing.Point(237, 397);
            label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(21, 18);
            label7.TabIndex = 46;
            label7.Text = "to";
            // 
            // xToTextBox
            // 
            xToTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            xToTextBox.Location = new System.Drawing.Point(267, 394);
            xToTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            xToTextBox.Name = "xToTextBox";
            xToTextBox.Size = new System.Drawing.Size(116, 24);
            xToTextBox.TabIndex = 47;
            xToTextBox.Text = "10";
            xToTextBox.KeyPress += TextBoxInputHandler;
            // 
            // errorFuncCheckBox
            // 
            errorFuncCheckBox.AutoSize = true;
            errorFuncCheckBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            errorFuncCheckBox.Location = new System.Drawing.Point(401, 396);
            errorFuncCheckBox.Name = "errorFuncCheckBox";
            errorFuncCheckBox.Size = new System.Drawing.Size(112, 23);
            errorFuncCheckBox.TabIndex = 49;
            errorFuncCheckBox.Text = "Error function";
            errorFuncCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1398, 606);
            Controls.Add(errorFuncCheckBox);
            Controls.Add(BuildButton);
            Controls.Add(xToTextBox);
            Controls.Add(tabControl);
            Controls.Add(label7);
            Controls.Add(xFromTextBox);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(groupBox1);
            Controls.Add(rootMeanSquaredErrorValueLabel);
            Controls.Add(label3);
            Controls.Add(fRichTextBox);
            Controls.Add(rootMeanSquaredErrorLabel);
            Controls.Add(toolStrip1);
            Controls.Add(plot);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Tropical Palm";
            Load += Form1_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            tabControl.ResumeLayout(false);
            manualTabPage.ResumeLayout(false);
            manualTabPage.PerformLayout();
            AutoTabPage.ResumeLayout(false);
            AutoTabPage.PerformLayout();
            ApproximateTabPage.ResumeLayout(false);
            ApproximateTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)mRightNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)mLeftNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)dNumericUpDown).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ScottPlot.FormsPlot plot;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel aboutToolStripLabel;
        private System.Windows.Forms.Label rootMeanSquaredErrorValueLabel;
        private System.Windows.Forms.Label rootMeanSquaredErrorLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage manualTabPage;
        private System.Windows.Forms.RichTextBox qRichTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox pRichTextBox;
        private System.Windows.Forms.TabPage AutoTabPage;
        private System.Windows.Forms.RichTextBox qRichTextBoxRO;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label pathHolderLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox pRichTextBoxRO;
        private System.Windows.Forms.TabPage ApproximateTabPage;
        private System.Windows.Forms.NumericUpDown mLeftNumericUpDown;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown dNumericUpDown;
        private System.Windows.Forms.RichTextBox fRichTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton maxPlusRadioButton;
        private System.Windows.Forms.RadioButton maxTimesRadioButton;
        private System.Windows.Forms.RadioButton minPlusRadioButton;
        private System.Windows.Forms.RadioButton minTimesRadioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox xFromTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox xToTextBox;
        private System.Windows.Forms.Button BuildButton;
        private System.Windows.Forms.CheckBox errorFuncCheckBox;
        private System.Windows.Forms.RadioButton rationalRadioButton;
        private System.Windows.Forms.RadioButton polynomialRadioButton;
        private System.Windows.Forms.CheckBox nonSymmetryPowersCheckBox;
        private System.Windows.Forms.NumericUpDown mRightNumericUpDown;
        private System.Windows.Forms.RichTextBox xsRichTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox changeBordersCheckBox;
        private System.Windows.Forms.RichTextBox qRichTextBoxROA;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RichTextBox pRichTextBoxROA;
        private System.Windows.Forms.ToolStripLabel settingsToolStripLabel;
    }
}

