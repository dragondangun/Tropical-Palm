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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.plot = new ScottPlot.FormsPlot();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.qRichTextBox = new System.Windows.Forms.RichTextBox();
            this.pRichTextBox = new System.Windows.Forms.RichTextBox();
            this.fRichTextBox = new System.Windows.Forms.RichTextBox();
            this.BuildButton = new System.Windows.Forms.Button();
            this.qRichTextBoxRO = new System.Windows.Forms.RichTextBox();
            this.pRichTextBoxRO = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.aboutToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.rootMeanSquaredErrorValueLabel = new System.Windows.Forms.Label();
            this.rootMeanSquaredErrorLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.manualTabPage = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AutoTabPage = new System.Windows.Forms.TabPage();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.pathHolderLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pathLabel = new System.Windows.Forms.Label();
            this.openFileButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.ApproximateTabPage = new System.Windows.Forms.TabPage();
            this.qRichTextBoxROA = new System.Windows.Forms.RichTextBox();
            this.changeBordersCheckBox = new System.Windows.Forms.CheckBox();
            this.rationalRadioButton = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.polynomialRadioButton = new System.Windows.Forms.RadioButton();
            this.nonSymmetryPowersCheckBox = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.pRichTextBoxROA = new System.Windows.Forms.RichTextBox();
            this.mRightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.xsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mLeftNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.maxPlusRadioButton = new System.Windows.Forms.RadioButton();
            this.maxTimesRadioButton = new System.Windows.Forms.RadioButton();
            this.minPlusRadioButton = new System.Windows.Forms.RadioButton();
            this.minTimesRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.xFromTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.xToTextBox = new System.Windows.Forms.TextBox();
            this.errorFuncCheckBox = new System.Windows.Forms.CheckBox();
            this.toolStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.manualTabPage.SuspendLayout();
            this.AutoTabPage.SuspendLayout();
            this.ApproximateTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mRightNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mLeftNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // plot
            // 
            this.plot.Location = new System.Drawing.Point(508, 12);
            this.plot.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.plot.Name = "plot";
            this.plot.Size = new System.Drawing.Size(901, 553);
            this.plot.TabIndex = 19;
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 5000;
            this.toolTip.InitialDelay = 500;
            this.toolTip.ReshowDelay = 100;
            // 
            // qRichTextBox
            // 
            this.qRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.qRichTextBox.Location = new System.Drawing.Point(96, 50);
            this.qRichTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.qRichTextBox.Multiline = false;
            this.qRichTextBox.Name = "qRichTextBox";
            this.qRichTextBox.Size = new System.Drawing.Size(313, 36);
            this.qRichTextBox.TabIndex = 38;
            this.qRichTextBox.Text = "";
            this.toolTip.SetToolTip(this.qRichTextBox, "Example: \r\n3*x^3+(-2)*x+1+x^(-0.5)\r\n");
            // 
            // pRichTextBox
            // 
            this.pRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pRichTextBox.Location = new System.Drawing.Point(96, 6);
            this.pRichTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pRichTextBox.Multiline = false;
            this.pRichTextBox.Name = "pRichTextBox";
            this.pRichTextBox.Size = new System.Drawing.Size(313, 36);
            this.pRichTextBox.TabIndex = 35;
            this.pRichTextBox.Text = "";
            this.toolTip.SetToolTip(this.pRichTextBox, "Example: \r\n3*x^3+(-2)*x+1+x^(-0.5)");
            // 
            // fRichTextBox
            // 
            this.fRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fRichTextBox.Location = new System.Drawing.Point(112, 352);
            this.fRichTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.fRichTextBox.Multiline = false;
            this.fRichTextBox.Name = "fRichTextBox";
            this.fRichTextBox.Size = new System.Drawing.Size(399, 36);
            this.fRichTextBox.TabIndex = 39;
            this.fRichTextBox.Text = "";
            this.toolTip.SetToolTip(this.fRichTextBox, "Example:\r\nx^2+2*x+3*e+sin(x)");
            // 
            // BuildButton
            // 
            this.BuildButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BuildButton.Location = new System.Drawing.Point(33, 518);
            this.BuildButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BuildButton.Name = "BuildButton";
            this.BuildButton.Size = new System.Drawing.Size(479, 76);
            this.BuildButton.TabIndex = 48;
            this.BuildButton.Text = "Build";
            this.toolTip.SetToolTip(this.BuildButton, "Click to build plot\r\nNB: P(x) and Q(x) are obligatory to be filled in");
            this.BuildButton.UseVisualStyleBackColor = true;
            this.BuildButton.Click += new System.EventHandler(this.BuildButton_Click);
            // 
            // qRichTextBoxRO
            // 
            this.qRichTextBoxRO.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.qRichTextBoxRO.Location = new System.Drawing.Point(92, 53);
            this.qRichTextBoxRO.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.qRichTextBoxRO.Multiline = false;
            this.qRichTextBoxRO.Name = "qRichTextBoxRO";
            this.qRichTextBoxRO.ReadOnly = true;
            this.qRichTextBoxRO.Size = new System.Drawing.Size(313, 36);
            this.qRichTextBoxRO.TabIndex = 42;
            this.qRichTextBoxRO.Text = "";
            // 
            // pRichTextBoxRO
            // 
            this.pRichTextBoxRO.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pRichTextBoxRO.Location = new System.Drawing.Point(92, 9);
            this.pRichTextBoxRO.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pRichTextBoxRO.Multiline = false;
            this.pRichTextBoxRO.Name = "pRichTextBoxRO";
            this.pRichTextBoxRO.ReadOnly = true;
            this.pRichTextBoxRO.Size = new System.Drawing.Size(313, 36);
            this.pRichTextBoxRO.TabIndex = 39;
            this.pRichTextBoxRO.Text = "";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripLabel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1398, 25);
            this.toolStrip1.TabIndex = 23;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // aboutToolStripLabel
            // 
            this.aboutToolStripLabel.Name = "aboutToolStripLabel";
            this.aboutToolStripLabel.Size = new System.Drawing.Size(82, 22);
            this.aboutToolStripLabel.Text = "О программе";
            this.aboutToolStripLabel.Click += new System.EventHandler(this.aboutToolStripLabel_Click);
            // 
            // rootMeanSquaredErrorValueLabel
            // 
            this.rootMeanSquaredErrorValueLabel.AutoSize = true;
            this.rootMeanSquaredErrorValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rootMeanSquaredErrorValueLabel.Location = new System.Drawing.Point(621, 569);
            this.rootMeanSquaredErrorValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rootMeanSquaredErrorValueLabel.Name = "rootMeanSquaredErrorValueLabel";
            this.rootMeanSquaredErrorValueLabel.Size = new System.Drawing.Size(0, 29);
            this.rootMeanSquaredErrorValueLabel.TabIndex = 26;
            this.rootMeanSquaredErrorValueLabel.Visible = false;
            // 
            // rootMeanSquaredErrorLabel
            // 
            this.rootMeanSquaredErrorLabel.AutoSize = true;
            this.rootMeanSquaredErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rootMeanSquaredErrorLabel.Location = new System.Drawing.Point(520, 568);
            this.rootMeanSquaredErrorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rootMeanSquaredErrorLabel.Name = "rootMeanSquaredErrorLabel";
            this.rootMeanSquaredErrorLabel.Size = new System.Drawing.Size(93, 29);
            this.rootMeanSquaredErrorLabel.TabIndex = 25;
            this.rootMeanSquaredErrorLabel.Text = "RMSE:";
            this.rootMeanSquaredErrorLabel.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(621, 565);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 29);
            this.label8.TabIndex = 26;
            this.label8.Visible = false;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.manualTabPage);
            this.tabControl.Controls.Add(this.AutoTabPage);
            this.tabControl.Controls.Add(this.ApproximateTabPage);
            this.tabControl.Location = new System.Drawing.Point(12, 28);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(505, 318);
            this.tabControl.TabIndex = 35;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // manualTabPage
            // 
            this.manualTabPage.Controls.Add(this.qRichTextBox);
            this.manualTabPage.Controls.Add(this.label2);
            this.manualTabPage.Controls.Add(this.label1);
            this.manualTabPage.Controls.Add(this.pRichTextBox);
            this.manualTabPage.Location = new System.Drawing.Point(4, 24);
            this.manualTabPage.Name = "manualTabPage";
            this.manualTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.manualTabPage.Size = new System.Drawing.Size(497, 290);
            this.manualTabPage.TabIndex = 0;
            this.manualTabPage.Text = "Manual";
            this.manualTabPage.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(46, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 18);
            this.label2.TabIndex = 37;
            this.label2.Text = "Q(x)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(48, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 18);
            this.label1.TabIndex = 36;
            this.label1.Text = "P(x)";
            // 
            // AutoTabPage
            // 
            this.AutoTabPage.Controls.Add(this.qRichTextBoxRO);
            this.AutoTabPage.Controls.Add(this.progressBar);
            this.AutoTabPage.Controls.Add(this.pathHolderLabel);
            this.AutoTabPage.Controls.Add(this.label10);
            this.AutoTabPage.Controls.Add(this.pathLabel);
            this.AutoTabPage.Controls.Add(this.openFileButton);
            this.AutoTabPage.Controls.Add(this.label11);
            this.AutoTabPage.Controls.Add(this.pRichTextBoxRO);
            this.AutoTabPage.Location = new System.Drawing.Point(4, 24);
            this.AutoTabPage.Name = "AutoTabPage";
            this.AutoTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.AutoTabPage.Size = new System.Drawing.Size(497, 290);
            this.AutoTabPage.TabIndex = 1;
            this.AutoTabPage.Text = "Autoselect";
            this.AutoTabPage.UseVisualStyleBackColor = true;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(92, 133);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(313, 32);
            this.progressBar.TabIndex = 58;
            // 
            // pathHolderLabel
            // 
            this.pathHolderLabel.AutoSize = true;
            this.pathHolderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pathHolderLabel.Location = new System.Drawing.Point(44, 104);
            this.pathHolderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pathHolderLabel.Name = "pathHolderLabel";
            this.pathHolderLabel.Size = new System.Drawing.Size(42, 18);
            this.pathHolderLabel.TabIndex = 56;
            this.pathHolderLabel.Text = "Path:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(42, 57);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 18);
            this.label10.TabIndex = 41;
            this.label10.Text = "Q(x)";
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pathLabel.Location = new System.Drawing.Point(92, 104);
            this.pathLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(0, 18);
            this.pathLabel.TabIndex = 57;
            // 
            // openFileButton
            // 
            this.openFileButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.openFileButton.Location = new System.Drawing.Point(412, 7);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(80, 80);
            this.openFileButton.TabIndex = 55;
            this.openFileButton.Text = "Open file";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(44, 13);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 18);
            this.label11.TabIndex = 40;
            this.label11.Text = "P(x)";
            // 
            // ApproximateTabPage
            // 
            this.ApproximateTabPage.Controls.Add(this.qRichTextBoxROA);
            this.ApproximateTabPage.Controls.Add(this.changeBordersCheckBox);
            this.ApproximateTabPage.Controls.Add(this.rationalRadioButton);
            this.ApproximateTabPage.Controls.Add(this.label12);
            this.ApproximateTabPage.Controls.Add(this.polynomialRadioButton);
            this.ApproximateTabPage.Controls.Add(this.nonSymmetryPowersCheckBox);
            this.ApproximateTabPage.Controls.Add(this.label13);
            this.ApproximateTabPage.Controls.Add(this.pRichTextBoxROA);
            this.ApproximateTabPage.Controls.Add(this.mRightNumericUpDown);
            this.ApproximateTabPage.Controls.Add(this.xsRichTextBox);
            this.ApproximateTabPage.Controls.Add(this.label5);
            this.ApproximateTabPage.Controls.Add(this.mLeftNumericUpDown);
            this.ApproximateTabPage.Controls.Add(this.label9);
            this.ApproximateTabPage.Controls.Add(this.label4);
            this.ApproximateTabPage.Controls.Add(this.dNumericUpDown);
            this.ApproximateTabPage.Location = new System.Drawing.Point(4, 24);
            this.ApproximateTabPage.Name = "ApproximateTabPage";
            this.ApproximateTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ApproximateTabPage.Size = new System.Drawing.Size(497, 290);
            this.ApproximateTabPage.TabIndex = 2;
            this.ApproximateTabPage.Text = "Approximate";
            this.ApproximateTabPage.UseVisualStyleBackColor = true;
            // 
            // qRichTextBoxROA
            // 
            this.qRichTextBoxROA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.qRichTextBoxROA.Location = new System.Drawing.Point(60, 60);
            this.qRichTextBoxROA.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.qRichTextBoxROA.Multiline = false;
            this.qRichTextBoxROA.Name = "qRichTextBoxROA";
            this.qRichTextBoxROA.ReadOnly = true;
            this.qRichTextBoxROA.Size = new System.Drawing.Size(419, 36);
            this.qRichTextBoxROA.TabIndex = 62;
            this.qRichTextBoxROA.Text = "";
            // 
            // changeBordersCheckBox
            // 
            this.changeBordersCheckBox.AutoSize = true;
            this.changeBordersCheckBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.changeBordersCheckBox.Location = new System.Drawing.Point(232, 220);
            this.changeBordersCheckBox.Name = "changeBordersCheckBox";
            this.changeBordersCheckBox.Size = new System.Drawing.Size(140, 25);
            this.changeBordersCheckBox.TabIndex = 64;
            this.changeBordersCheckBox.Text = "Change borders";
            this.changeBordersCheckBox.UseVisualStyleBackColor = true;
            // 
            // rationalRadioButton
            // 
            this.rationalRadioButton.AutoSize = true;
            this.rationalRadioButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rationalRadioButton.Location = new System.Drawing.Point(173, 259);
            this.rationalRadioButton.Name = "rationalRadioButton";
            this.rationalRadioButton.Size = new System.Drawing.Size(85, 25);
            this.rationalRadioButton.TabIndex = 63;
            this.rationalRadioButton.Text = "Rational";
            this.rationalRadioButton.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(9, 64);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 18);
            this.label12.TabIndex = 61;
            this.label12.Text = "Q(x)";
            // 
            // polynomialRadioButton
            // 
            this.polynomialRadioButton.AutoSize = true;
            this.polynomialRadioButton.Checked = true;
            this.polynomialRadioButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.polynomialRadioButton.Location = new System.Drawing.Point(34, 259);
            this.polynomialRadioButton.Name = "polynomialRadioButton";
            this.polynomialRadioButton.Size = new System.Drawing.Size(105, 25);
            this.polynomialRadioButton.TabIndex = 62;
            this.polynomialRadioButton.TabStop = true;
            this.polynomialRadioButton.Text = "Polynomial";
            this.polynomialRadioButton.UseVisualStyleBackColor = true;
            // 
            // nonSymmetryPowersCheckBox
            // 
            this.nonSymmetryPowersCheckBox.AutoSize = true;
            this.nonSymmetryPowersCheckBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nonSymmetryPowersCheckBox.Location = new System.Drawing.Point(36, 220);
            this.nonSymmetryPowersCheckBox.Name = "nonSymmetryPowersCheckBox";
            this.nonSymmetryPowersCheckBox.Size = new System.Drawing.Size(190, 25);
            this.nonSymmetryPowersCheckBox.TabIndex = 61;
            this.nonSymmetryPowersCheckBox.Text = "Non-symmetry powers";
            this.nonSymmetryPowersCheckBox.UseVisualStyleBackColor = true;
            this.nonSymmetryPowersCheckBox.CheckedChanged += new System.EventHandler(this.nonSymmetryPowersCheckBox_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(11, 20);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 18);
            this.label13.TabIndex = 60;
            this.label13.Text = "P(x)";
            // 
            // pRichTextBoxROA
            // 
            this.pRichTextBoxROA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pRichTextBoxROA.Location = new System.Drawing.Point(59, 16);
            this.pRichTextBoxROA.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pRichTextBoxROA.Multiline = false;
            this.pRichTextBoxROA.Name = "pRichTextBoxROA";
            this.pRichTextBoxROA.ReadOnly = true;
            this.pRichTextBoxROA.Size = new System.Drawing.Size(419, 36);
            this.pRichTextBoxROA.TabIndex = 59;
            this.pRichTextBoxROA.Text = "";
            // 
            // mRightNumericUpDown
            // 
            this.mRightNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mRightNumericUpDown.Location = new System.Drawing.Point(184, 160);
            this.mRightNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mRightNumericUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.mRightNumericUpDown.Name = "mRightNumericUpDown";
            this.mRightNumericUpDown.Size = new System.Drawing.Size(140, 24);
            this.mRightNumericUpDown.TabIndex = 60;
            this.mRightNumericUpDown.Visible = false;
            // 
            // xsRichTextBox
            // 
            this.xsRichTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.xsRichTextBox.Location = new System.Drawing.Point(36, 116);
            this.xsRichTextBox.Name = "xsRichTextBox";
            this.xsRichTextBox.Size = new System.Drawing.Size(442, 32);
            this.xsRichTextBox.TabIndex = 59;
            this.xsRichTextBox.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(5, 122);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 18);
            this.label5.TabIndex = 57;
            this.label5.Text = "Xs";
            // 
            // mLeftNumericUpDown
            // 
            this.mLeftNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mLeftNumericUpDown.Location = new System.Drawing.Point(36, 160);
            this.mLeftNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mLeftNumericUpDown.Name = "mLeftNumericUpDown";
            this.mLeftNumericUpDown.Size = new System.Drawing.Size(140, 24);
            this.mLeftNumericUpDown.TabIndex = 55;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(11, 192);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 18);
            this.label9.TabIndex = 58;
            this.label9.Text = "d";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(11, 162);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 18);
            this.label4.TabIndex = 56;
            this.label4.Text = "M";
            // 
            // dNumericUpDown
            // 
            this.dNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dNumericUpDown.Location = new System.Drawing.Point(36, 190);
            this.dNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dNumericUpDown.Name = "dNumericUpDown";
            this.dNumericUpDown.Size = new System.Drawing.Size(140, 24);
            this.dNumericUpDown.TabIndex = 57;
            this.dNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(71, 355);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 18);
            this.label3.TabIndex = 40;
            this.label3.Text = "f(x)";
            // 
            // maxPlusRadioButton
            // 
            this.maxPlusRadioButton.AutoSize = true;
            this.maxPlusRadioButton.Checked = true;
            this.maxPlusRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maxPlusRadioButton.Location = new System.Drawing.Point(8, 33);
            this.maxPlusRadioButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.maxPlusRadioButton.Name = "maxPlusRadioButton";
            this.maxPlusRadioButton.Size = new System.Drawing.Size(81, 22);
            this.maxPlusRadioButton.TabIndex = 0;
            this.maxPlusRadioButton.TabStop = true;
            this.maxPlusRadioButton.Text = "(max, +)";
            this.maxPlusRadioButton.UseVisualStyleBackColor = true;
            this.maxPlusRadioButton.CheckedChanged += new System.EventHandler(this.maxPlusRadioButton_CheckedChanged);
            // 
            // maxTimesRadioButton
            // 
            this.maxTimesRadioButton.AutoSize = true;
            this.maxTimesRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maxTimesRadioButton.Location = new System.Drawing.Point(9, 61);
            this.maxTimesRadioButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.maxTimesRadioButton.Name = "maxTimesRadioButton";
            this.maxTimesRadioButton.Size = new System.Drawing.Size(81, 22);
            this.maxTimesRadioButton.TabIndex = 1;
            this.maxTimesRadioButton.Text = "(max, ×)";
            this.maxTimesRadioButton.UseVisualStyleBackColor = true;
            this.maxTimesRadioButton.CheckedChanged += new System.EventHandler(this.maxTimesRadioButton_CheckedChanged);
            // 
            // minPlusRadioButton
            // 
            this.minPlusRadioButton.AutoSize = true;
            this.minPlusRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minPlusRadioButton.Location = new System.Drawing.Point(402, 33);
            this.minPlusRadioButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.minPlusRadioButton.Name = "minPlusRadioButton";
            this.minPlusRadioButton.Size = new System.Drawing.Size(77, 22);
            this.minPlusRadioButton.TabIndex = 2;
            this.minPlusRadioButton.Text = "(min, +)";
            this.minPlusRadioButton.UseVisualStyleBackColor = true;
            this.minPlusRadioButton.CheckedChanged += new System.EventHandler(this.minPlusRadioButton_CheckedChanged);
            // 
            // minTimesRadioButton
            // 
            this.minTimesRadioButton.AutoSize = true;
            this.minTimesRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minTimesRadioButton.Location = new System.Drawing.Point(402, 61);
            this.minTimesRadioButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.minTimesRadioButton.Name = "minTimesRadioButton";
            this.minTimesRadioButton.Size = new System.Drawing.Size(77, 22);
            this.minTimesRadioButton.TabIndex = 3;
            this.minTimesRadioButton.Text = "(min, ×)";
            this.minTimesRadioButton.UseVisualStyleBackColor = true;
            this.minTimesRadioButton.CheckedChanged += new System.EventHandler(this.minTimesRadioButton_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.minTimesRadioButton);
            this.groupBox1.Controls.Add(this.minPlusRadioButton);
            this.groupBox1.Controls.Add(this.maxTimesRadioButton);
            this.groupBox1.Controls.Add(this.maxPlusRadioButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(25, 418);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(486, 94);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select algebra";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(52, 397);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 18);
            this.label6.TabIndex = 44;
            this.label6.Text = "x from";
            // 
            // xFromTextBox
            // 
            this.xFromTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.xFromTextBox.Location = new System.Drawing.Point(114, 394);
            this.xFromTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.xFromTextBox.Name = "xFromTextBox";
            this.xFromTextBox.Size = new System.Drawing.Size(116, 24);
            this.xFromTextBox.TabIndex = 45;
            this.xFromTextBox.Text = "-10";
            this.xFromTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxInputHandler);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(237, 397);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 18);
            this.label7.TabIndex = 46;
            this.label7.Text = "to";
            // 
            // xToTextBox
            // 
            this.xToTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.xToTextBox.Location = new System.Drawing.Point(267, 394);
            this.xToTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.xToTextBox.Name = "xToTextBox";
            this.xToTextBox.Size = new System.Drawing.Size(116, 24);
            this.xToTextBox.TabIndex = 47;
            this.xToTextBox.Text = "10";
            this.xToTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxInputHandler);
            // 
            // errorFuncCheckBox
            // 
            this.errorFuncCheckBox.AutoSize = true;
            this.errorFuncCheckBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.errorFuncCheckBox.Location = new System.Drawing.Point(401, 396);
            this.errorFuncCheckBox.Name = "errorFuncCheckBox";
            this.errorFuncCheckBox.Size = new System.Drawing.Size(112, 23);
            this.errorFuncCheckBox.TabIndex = 49;
            this.errorFuncCheckBox.Text = "Error function";
            this.errorFuncCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 606);
            this.Controls.Add(this.errorFuncCheckBox);
            this.Controls.Add(this.BuildButton);
            this.Controls.Add(this.xToTextBox);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.xFromTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rootMeanSquaredErrorValueLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fRichTextBox);
            this.Controls.Add(this.rootMeanSquaredErrorLabel);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.plot);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Tropical Palm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.manualTabPage.ResumeLayout(false);
            this.manualTabPage.PerformLayout();
            this.AutoTabPage.ResumeLayout(false);
            this.AutoTabPage.PerformLayout();
            this.ApproximateTabPage.ResumeLayout(false);
            this.ApproximateTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mRightNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mLeftNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dNumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

