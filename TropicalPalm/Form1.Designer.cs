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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // pRichTextBox
            // 
            this.pRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pRichTextBox.Location = new System.Drawing.Point(100, 17);
            this.pRichTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pRichTextBox.Multiline = false;
            this.pRichTextBox.Name = "pRichTextBox";
            this.pRichTextBox.Size = new System.Drawing.Size(313, 36);
            this.pRichTextBox.TabIndex = 0;
            this.pRichTextBox.Text = "";
            this.toolTip.SetToolTip(this.pRichTextBox, "Insert polynomial. Example: \r\n3*x^3+2x2-x+1+x^(-1)\r\nNB: x^(2/3) will be read as x" +
        "^(-1) in (max/min, +)-algebra\r\nNB: This field is obligatory to fill in");
            this.pRichTextBox.MouseHover += new System.EventHandler(this.pRichTextBox_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(52, 21);
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
            this.label2.Location = new System.Drawing.Point(50, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Q(x)";
            // 
            // qRichTextBox
            // 
            this.qRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.qRichTextBox.Location = new System.Drawing.Point(100, 61);
            this.qRichTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.qRichTextBox.Multiline = false;
            this.qRichTextBox.Name = "qRichTextBox";
            this.qRichTextBox.Size = new System.Drawing.Size(313, 36);
            this.qRichTextBox.TabIndex = 5;
            this.qRichTextBox.Text = "";
            this.toolTip.SetToolTip(this.qRichTextBox, "Insert polynomial. Example: \r\n3*x^3+2x2-x+1+x^(-1)\r\nNB: x^(2/3) will be read as x" +
        "^(-1) in (max/min, +)-algebra\r\nNB: This field is obligatory to fill in");
            // 
            // fRichTextBox
            // 
            this.fRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fRichTextBox.Location = new System.Drawing.Point(100, 157);
            this.fRichTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.fRichTextBox.Multiline = false;
            this.fRichTextBox.Name = "fRichTextBox";
            this.fRichTextBox.Size = new System.Drawing.Size(313, 36);
            this.fRichTextBox.TabIndex = 6;
            this.fRichTextBox.Text = "";
            this.toolTip.SetToolTip(this.fRichTextBox, "Insert function. Examples:\r\nx^2+x+3\r\n3x2-7\r\nsin(x)\r\ne^x+1");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(59, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "f(x)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.otherRadioButton);
            this.groupBox1.Controls.Add(this.minTimesRadioButton);
            this.groupBox1.Controls.Add(this.minPlusRadioButton);
            this.groupBox1.Controls.Add(this.maxTimesRadioButton);
            this.groupBox1.Controls.Add(this.maxPlusRadioButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(18, 398);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(397, 180);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select algebra";
            // 
            // otherRadioButton
            // 
            this.otherRadioButton.AutoSize = true;
            this.otherRadioButton.Enabled = false;
            this.otherRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.otherRadioButton.Location = new System.Drawing.Point(154, 122);
            this.otherRadioButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.otherRadioButton.Name = "otherRadioButton";
            this.otherRadioButton.Size = new System.Drawing.Size(63, 22);
            this.otherRadioButton.TabIndex = 4;
            this.otherRadioButton.Text = "Other";
            this.otherRadioButton.UseVisualStyleBackColor = true;
            // 
            // minTimesRadioButton
            // 
            this.minTimesRadioButton.AutoSize = true;
            this.minTimesRadioButton.Enabled = false;
            this.minTimesRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minTimesRadioButton.Location = new System.Drawing.Point(300, 85);
            this.minTimesRadioButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.minTimesRadioButton.Name = "minTimesRadioButton";
            this.minTimesRadioButton.Size = new System.Drawing.Size(77, 22);
            this.minTimesRadioButton.TabIndex = 3;
            this.minTimesRadioButton.Text = "(min, ×)";
            this.minTimesRadioButton.UseVisualStyleBackColor = true;
            // 
            // minPlusRadioButton
            // 
            this.minPlusRadioButton.AutoSize = true;
            this.minPlusRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minPlusRadioButton.Location = new System.Drawing.Point(300, 33);
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
            this.maxTimesRadioButton.Enabled = false;
            this.maxTimesRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maxTimesRadioButton.Location = new System.Drawing.Point(7, 85);
            this.maxTimesRadioButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.maxTimesRadioButton.Name = "maxTimesRadioButton";
            this.maxTimesRadioButton.Size = new System.Drawing.Size(81, 22);
            this.maxTimesRadioButton.TabIndex = 1;
            this.maxTimesRadioButton.Text = "(max, ×)";
            this.maxTimesRadioButton.UseVisualStyleBackColor = true;
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
            this.pDbyQRichTextBox.Location = new System.Drawing.Point(100, 105);
            this.pDbyQRichTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pDbyQRichTextBox.Multiline = false;
            this.pDbyQRichTextBox.Name = "pDbyQRichTextBox";
            this.pDbyQRichTextBox.ReadOnly = true;
            this.pDbyQRichTextBox.Size = new System.Drawing.Size(313, 36);
            this.pDbyQRichTextBox.TabIndex = 11;
            this.pDbyQRichTextBox.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(14, 108);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "P(x)/Q(x)";
            // 
            // kNumericUpDown
            // 
            this.kNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kNumericUpDown.Location = new System.Drawing.Point(100, 211);
            this.kNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.kNumericUpDown.Name = "kNumericUpDown";
            this.kNumericUpDown.Size = new System.Drawing.Size(140, 24);
            this.kNumericUpDown.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(75, 213);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "k";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(14, 256);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "x from";
            // 
            // xFromTextBox
            // 
            this.xFromTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.xFromTextBox.Location = new System.Drawing.Point(100, 254);
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
            this.label7.Location = new System.Drawing.Point(247, 257);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "to";
            // 
            // xToTextBox
            // 
            this.xToTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.xToTextBox.Location = new System.Drawing.Point(298, 254);
            this.xToTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.xToTextBox.Name = "xToTextBox";
            this.xToTextBox.Size = new System.Drawing.Size(116, 24);
            this.xToTextBox.TabIndex = 17;
            this.xToTextBox.Text = "10";
            this.xToTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxInputHandler);
            // 
            // BuildButton
            // 
            this.BuildButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BuildButton.Location = new System.Drawing.Point(78, 320);
            this.BuildButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BuildButton.Name = "BuildButton";
            this.BuildButton.Size = new System.Drawing.Size(90, 33);
            this.BuildButton.TabIndex = 18;
            this.BuildButton.Text = "Build";
            this.toolTip.SetToolTip(this.BuildButton, "Click to build plot\r\nNB: P(x) and Q(x) are obligatory to be filled in");
            this.BuildButton.UseVisualStyleBackColor = true;
            this.BuildButton.Click += new System.EventHandler(this.BuildButton_Click);
            // 
            // plot
            // 
            this.plot.Location = new System.Drawing.Point(422, 12);
            this.plot.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.plot.Name = "plot";
            this.plot.Size = new System.Drawing.Size(901, 514);
            this.plot.TabIndex = 19;

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 623);

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
    }
}

