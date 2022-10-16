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
            this.pRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.qRichTextBox = new System.Windows.Forms.RichTextBox();
            this.fRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.minDivRadioButton = new System.Windows.Forms.RadioButton();
            this.maxDivRadioButton = new System.Windows.Forms.RadioButton();
            this.otherRadioButton = new System.Windows.Forms.RadioButton();
            this.minTimesRadioButton = new System.Windows.Forms.RadioButton();
            this.minPlusRadioButton = new System.Windows.Forms.RadioButton();
            this.maxTimesRadioButton = new System.Windows.Forms.RadioButton();
            this.maxPlusRadioButton = new System.Windows.Forms.RadioButton();
            this.pDbyQRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.kNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.xFromTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.xToTextBox = new System.Windows.Forms.TextBox();
            this.BuildButton = new System.Windows.Forms.Button();
            this.plot = new ScottPlot.FormsPlot();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.errorFuncCheckBox = new System.Windows.Forms.CheckBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.aboutToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.openFileButton = new System.Windows.Forms.Button();
            this.rootMeanSquaredErrorValueLabel = new System.Windows.Forms.Label();
            this.rootMeanSquaredErrorLabel = new System.Windows.Forms.Label();
            this.manualButton = new System.Windows.Forms.Button();
            this.pathHolderLabel = new System.Windows.Forms.Label();
            this.pathLabel = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kNumericUpDown)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pRichTextBox
            // 
            this.pRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pRichTextBox.Location = new System.Drawing.Point(100, 32);
            this.pRichTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pRichTextBox.Multiline = false;
            this.pRichTextBox.Name = "pRichTextBox";
            this.pRichTextBox.Size = new System.Drawing.Size(313, 36);
            this.pRichTextBox.TabIndex = 0;
            this.pRichTextBox.Text = "";
            this.toolTip.SetToolTip(this.pRichTextBox, "Example: \r\n3*x^3+(-2)*x+1+x^(-0.5)");
            this.pRichTextBox.MouseHover += new System.EventHandler(this.pRichTextBox_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(52, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "P(x)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(50, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Q(x)";
            // 
            // qRichTextBox
            // 
            this.qRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.qRichTextBox.Location = new System.Drawing.Point(100, 76);
            this.qRichTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.qRichTextBox.Multiline = false;
            this.qRichTextBox.Name = "qRichTextBox";
            this.qRichTextBox.Size = new System.Drawing.Size(313, 36);
            this.qRichTextBox.TabIndex = 5;
            this.qRichTextBox.Text = "";
            this.toolTip.SetToolTip(this.qRichTextBox, "Example: \r\n3*x^3+(-2)*x+1+x^(-0.5)\r\n");
            // 
            // fRichTextBox
            // 
            this.fRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fRichTextBox.Location = new System.Drawing.Point(100, 248);
            this.fRichTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.fRichTextBox.Multiline = false;
            this.fRichTextBox.Name = "fRichTextBox";
            this.fRichTextBox.Size = new System.Drawing.Size(399, 36);
            this.fRichTextBox.TabIndex = 6;
            this.fRichTextBox.Text = "";
            this.toolTip.SetToolTip(this.fRichTextBox, "Example:\r\nx^2+2*x+3*e+sin(x)");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(59, 251);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "f(x)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.minDivRadioButton);
            this.groupBox1.Controls.Add(this.maxDivRadioButton);
            this.groupBox1.Controls.Add(this.otherRadioButton);
            this.groupBox1.Controls.Add(this.minTimesRadioButton);
            this.groupBox1.Controls.Add(this.minPlusRadioButton);
            this.groupBox1.Controls.Add(this.maxTimesRadioButton);
            this.groupBox1.Controls.Add(this.maxPlusRadioButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(13, 363);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(486, 122);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select algebra";
            // 
            // minDivRadioButton
            // 
            this.minDivRadioButton.AutoSize = true;
            this.minDivRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minDivRadioButton.Location = new System.Drawing.Point(400, 89);
            this.minDivRadioButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.minDivRadioButton.Name = "minDivRadioButton";
            this.minDivRadioButton.Size = new System.Drawing.Size(72, 22);
            this.minDivRadioButton.TabIndex = 6;
            this.minDivRadioButton.Text = "(min, /)";
            this.minDivRadioButton.UseVisualStyleBackColor = true;
            this.minDivRadioButton.CheckedChanged += new System.EventHandler(this.minDivRadioButton_CheckedChanged);
            // 
            // maxDivRadioButton
            // 
            this.maxDivRadioButton.AutoSize = true;
            this.maxDivRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maxDivRadioButton.Location = new System.Drawing.Point(7, 89);
            this.maxDivRadioButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.maxDivRadioButton.Name = "maxDivRadioButton";
            this.maxDivRadioButton.Size = new System.Drawing.Size(76, 22);
            this.maxDivRadioButton.TabIndex = 5;
            this.maxDivRadioButton.Text = "(max, /)";
            this.maxDivRadioButton.UseVisualStyleBackColor = true;
            this.maxDivRadioButton.CheckedChanged += new System.EventHandler(this.maxDivRadioButton_CheckedChanged);
            // 
            // otherRadioButton
            // 
            this.otherRadioButton.AutoSize = true;
            this.otherRadioButton.Enabled = false;
            this.otherRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.otherRadioButton.Location = new System.Drawing.Point(205, 89);
            this.otherRadioButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.otherRadioButton.Name = "otherRadioButton";
            this.otherRadioButton.Size = new System.Drawing.Size(63, 22);
            this.otherRadioButton.TabIndex = 4;
            this.otherRadioButton.Text = "Other";
            this.otherRadioButton.UseVisualStyleBackColor = true;
            this.otherRadioButton.Visible = false;
            // 
            // minTimesRadioButton
            // 
            this.minTimesRadioButton.AutoSize = true;
            this.minTimesRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minTimesRadioButton.Location = new System.Drawing.Point(401, 61);
            this.minTimesRadioButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.minTimesRadioButton.Name = "minTimesRadioButton";
            this.minTimesRadioButton.Size = new System.Drawing.Size(77, 22);
            this.minTimesRadioButton.TabIndex = 3;
            this.minTimesRadioButton.Text = "(min, ×)";
            this.minTimesRadioButton.UseVisualStyleBackColor = true;
            this.minTimesRadioButton.CheckedChanged += new System.EventHandler(this.minTimesRadioButton_CheckedChanged);
            // 
            // minPlusRadioButton
            // 
            this.minPlusRadioButton.AutoSize = true;
            this.minPlusRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minPlusRadioButton.Location = new System.Drawing.Point(401, 33);
            this.minPlusRadioButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.minPlusRadioButton.Name = "minPlusRadioButton";
            this.minPlusRadioButton.Size = new System.Drawing.Size(77, 22);
            this.minPlusRadioButton.TabIndex = 2;
            this.minPlusRadioButton.Text = "(min, +)";
            this.minPlusRadioButton.UseVisualStyleBackColor = true;
            this.minPlusRadioButton.CheckedChanged += new System.EventHandler(this.minPlusRadioButton_CheckedChanged);
            // 
            // maxTimesRadioButton
            // 
            this.maxTimesRadioButton.AutoSize = true;
            this.maxTimesRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maxTimesRadioButton.Location = new System.Drawing.Point(8, 61);
            this.maxTimesRadioButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.maxTimesRadioButton.Name = "maxTimesRadioButton";
            this.maxTimesRadioButton.Size = new System.Drawing.Size(81, 22);
            this.maxTimesRadioButton.TabIndex = 1;
            this.maxTimesRadioButton.Text = "(max, ×)";
            this.maxTimesRadioButton.UseVisualStyleBackColor = true;
            this.maxTimesRadioButton.CheckedChanged += new System.EventHandler(this.maxTimesRadioButton_CheckedChanged);
            // 
            // maxPlusRadioButton
            // 
            this.maxPlusRadioButton.AutoSize = true;
            this.maxPlusRadioButton.Checked = true;
            this.maxPlusRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maxPlusRadioButton.Location = new System.Drawing.Point(7, 33);
            this.maxPlusRadioButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.maxPlusRadioButton.Name = "maxPlusRadioButton";
            this.maxPlusRadioButton.Size = new System.Drawing.Size(81, 22);
            this.maxPlusRadioButton.TabIndex = 0;
            this.maxPlusRadioButton.TabStop = true;
            this.maxPlusRadioButton.Text = "(max, +)";
            this.maxPlusRadioButton.UseVisualStyleBackColor = true;
            this.maxPlusRadioButton.CheckedChanged += new System.EventHandler(this.maxPlusRadioButton_CheckedChanged);
            // 
            // pDbyQRichTextBox
            // 
            this.pDbyQRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pDbyQRichTextBox.Location = new System.Drawing.Point(100, 196);
            this.pDbyQRichTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pDbyQRichTextBox.Multiline = false;
            this.pDbyQRichTextBox.Name = "pDbyQRichTextBox";
            this.pDbyQRichTextBox.ReadOnly = true;
            this.pDbyQRichTextBox.Size = new System.Drawing.Size(399, 36);
            this.pDbyQRichTextBox.TabIndex = 11;
            this.pDbyQRichTextBox.Text = "";
            this.pDbyQRichTextBox.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(14, 199);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "P(x)/Q(x)";
            this.label4.Visible = false;
            // 
            // kNumericUpDown
            // 
            this.kNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kNumericUpDown.Location = new System.Drawing.Point(100, 290);
            this.kNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.kNumericUpDown.Name = "kNumericUpDown";
            this.kNumericUpDown.Size = new System.Drawing.Size(140, 24);
            this.kNumericUpDown.TabIndex = 12;
            this.kNumericUpDown.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(75, 292);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "k";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(14, 335);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "x from";
            // 
            // xFromTextBox
            // 
            this.xFromTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.xFromTextBox.Location = new System.Drawing.Point(100, 333);
            this.xFromTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.xFromTextBox.Name = "xFromTextBox";
            this.xFromTextBox.Size = new System.Drawing.Size(116, 24);
            this.xFromTextBox.TabIndex = 15;
            this.xFromTextBox.Text = "-10";
            this.xFromTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxInputHandler);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(285, 333);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "to";
            // 
            // xToTextBox
            // 
            this.xToTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.xToTextBox.Location = new System.Drawing.Point(383, 332);
            this.xToTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.xToTextBox.Name = "xToTextBox";
            this.xToTextBox.Size = new System.Drawing.Size(116, 24);
            this.xToTextBox.TabIndex = 17;
            this.xToTextBox.Text = "10";
            this.xToTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxInputHandler);
            // 
            // BuildButton
            // 
            this.BuildButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BuildButton.Location = new System.Drawing.Point(21, 491);
            this.BuildButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BuildButton.Name = "BuildButton";
            this.BuildButton.Size = new System.Drawing.Size(479, 76);
            this.BuildButton.TabIndex = 18;
            this.BuildButton.Text = "Build";
            this.toolTip.SetToolTip(this.BuildButton, "Click to build plot\r\nNB: P(x) and Q(x) are obligatory to be filled in");
            this.BuildButton.UseVisualStyleBackColor = true;
            this.BuildButton.Click += new System.EventHandler(this.BuildButton_Click);
            // 
            // plot
            // 
            this.plot.Location = new System.Drawing.Point(508, 12);
            this.plot.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.plot.Name = "plot";
            this.plot.Size = new System.Drawing.Size(901, 514);
            this.plot.TabIndex = 19;
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 5000;
            this.toolTip.InitialDelay = 500;
            this.toolTip.ReshowDelay = 100;
            // 
            // errorFuncCheckBox
            // 
            this.errorFuncCheckBox.AutoSize = true;
            this.errorFuncCheckBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.errorFuncCheckBox.Location = new System.Drawing.Point(247, 290);
            this.errorFuncCheckBox.Name = "errorFuncCheckBox";
            this.errorFuncCheckBox.Size = new System.Drawing.Size(112, 23);
            this.errorFuncCheckBox.TabIndex = 20;
            this.errorFuncCheckBox.Text = "Error function";
            this.errorFuncCheckBox.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripLabel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1435, 25);
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
            // openFileButton
            // 
            this.openFileButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.openFileButton.Location = new System.Drawing.Point(420, 32);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(80, 80);
            this.openFileButton.TabIndex = 24;
            this.openFileButton.Text = "Open file";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // rootMeanSquaredErrorValueLabel
            // 
            this.rootMeanSquaredErrorValueLabel.AutoSize = true;
            this.rootMeanSquaredErrorValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rootMeanSquaredErrorValueLabel.Location = new System.Drawing.Point(625, 533);
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
            this.rootMeanSquaredErrorLabel.Location = new System.Drawing.Point(524, 529);
            this.rootMeanSquaredErrorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rootMeanSquaredErrorLabel.Name = "rootMeanSquaredErrorLabel";
            this.rootMeanSquaredErrorLabel.Size = new System.Drawing.Size(93, 29);
            this.rootMeanSquaredErrorLabel.TabIndex = 25;
            this.rootMeanSquaredErrorLabel.Text = "RMSE:";
            this.rootMeanSquaredErrorLabel.Visible = false;
            // 
            // manualButton
            // 
            this.manualButton.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.manualButton.Location = new System.Drawing.Point(420, 118);
            this.manualButton.Name = "manualButton";
            this.manualButton.Size = new System.Drawing.Size(80, 39);
            this.manualButton.TabIndex = 27;
            this.manualButton.Text = "Manual";
            this.manualButton.UseVisualStyleBackColor = true;
            this.manualButton.Visible = false;
            // 
            // pathHolderLabel
            // 
            this.pathHolderLabel.AutoSize = true;
            this.pathHolderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pathHolderLabel.Location = new System.Drawing.Point(52, 129);
            this.pathHolderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pathHolderLabel.Name = "pathHolderLabel";
            this.pathHolderLabel.Size = new System.Drawing.Size(42, 18);
            this.pathHolderLabel.TabIndex = 28;
            this.pathHolderLabel.Text = "Path:";
            this.pathHolderLabel.Visible = false;
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pathLabel.Location = new System.Drawing.Point(100, 129);
            this.pathLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(0, 18);
            this.pathLabel.TabIndex = 29;
            this.pathLabel.Visible = false;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(100, 150);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(313, 32);
            this.progressBar.TabIndex = 30;
            this.progressBar.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1435, 582);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.pathLabel);
            this.Controls.Add(this.pathHolderLabel);
            this.Controls.Add(this.manualButton);
            this.Controls.Add(this.rootMeanSquaredErrorValueLabel);
            this.Controls.Add(this.rootMeanSquaredErrorLabel);
            this.Controls.Add(this.openFileButton);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.errorFuncCheckBox);
            this.Controls.Add(this.plot);
            this.Controls.Add(this.BuildButton);
            this.Controls.Add(this.xToTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.xFromTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.kNumericUpDown);
            this.Controls.Add(this.pDbyQRichTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fRichTextBox);
            this.Controls.Add(this.qRichTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pRichTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Tropical Palm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kNumericUpDown)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

#endregion

        private System.Windows.Forms.RichTextBox pRichTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox qRichTextBox;
        private System.Windows.Forms.RichTextBox fRichTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton otherRadioButton;
        private System.Windows.Forms.RadioButton minTimesRadioButton;
        private System.Windows.Forms.RadioButton minPlusRadioButton;
        private System.Windows.Forms.RadioButton maxTimesRadioButton;
        private System.Windows.Forms.RadioButton maxPlusRadioButton;
        private System.Windows.Forms.RichTextBox pDbyQRichTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown kNumericUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox xFromTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox xToTextBox;
        private System.Windows.Forms.Button BuildButton;
        private ScottPlot.FormsPlot plot;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.RadioButton minDivRadioButton;
        private System.Windows.Forms.RadioButton maxDivRadioButton;
        private System.Windows.Forms.CheckBox errorFuncCheckBox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel aboutToolStripLabel;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.Label rootMeanSquaredErrorValueLabel;
        private System.Windows.Forms.Label rootMeanSquaredErrorLabel;
        private System.Windows.Forms.Button manualButton;
        private System.Windows.Forms.Label pathHolderLabel;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

