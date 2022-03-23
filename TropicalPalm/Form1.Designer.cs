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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.qRichTextBox = new System.Windows.Forms.RichTextBox();
            this.fRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
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
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // pRichTextBox
            // 
            this.pRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pRichTextBox.Location = new System.Drawing.Point(86, 15);
            this.pRichTextBox.Multiline = false;
            this.pRichTextBox.Name = "pRichTextBox";
            this.pRichTextBox.Size = new System.Drawing.Size(269, 32);
            this.pRichTextBox.TabIndex = 0;
            this.pRichTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(45, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "P(x)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(43, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Q(x)";
            // 
            // qRichTextBox
            // 
            this.qRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.qRichTextBox.Location = new System.Drawing.Point(86, 53);
            this.qRichTextBox.Multiline = false;
            this.qRichTextBox.Name = "qRichTextBox";
            this.qRichTextBox.Size = new System.Drawing.Size(269, 32);
            this.qRichTextBox.TabIndex = 5;
            this.qRichTextBox.Text = "";
            // 
            // fRichTextBox
            // 
            this.fRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fRichTextBox.Location = new System.Drawing.Point(86, 136);
            this.fRichTextBox.Multiline = false;
            this.fRichTextBox.Name = "fRichTextBox";
            this.fRichTextBox.Size = new System.Drawing.Size(269, 32);
            this.fRichTextBox.TabIndex = 6;
            this.fRichTextBox.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(51, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "f(x)";
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(361, 15);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(772, 513);
            this.chart.TabIndex = 8;
            this.chart.Text = "chart1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.otherRadioButton);
            this.groupBox1.Controls.Add(this.minTimesRadioButton);
            this.groupBox1.Controls.Add(this.minPlusRadioButton);
            this.groupBox1.Controls.Add(this.maxTimesRadioButton);
            this.groupBox1.Controls.Add(this.maxPlusRadioButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(15, 345);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 156);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select algebra";
            // 
            // otherRadioButton
            // 
            this.otherRadioButton.AutoSize = true;
            this.otherRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.otherRadioButton.Location = new System.Drawing.Point(132, 106);
            this.otherRadioButton.Name = "otherRadioButton";
            this.otherRadioButton.Size = new System.Drawing.Size(63, 22);
            this.otherRadioButton.TabIndex = 4;
            this.otherRadioButton.Text = "Other";
            this.otherRadioButton.UseVisualStyleBackColor = true;
            // 
            // minTimesRadioButton
            // 
            this.minTimesRadioButton.AutoSize = true;
            this.minTimesRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minTimesRadioButton.Location = new System.Drawing.Point(257, 74);
            this.minTimesRadioButton.Name = "minTimesRadioButton";
            this.minTimesRadioButton.Size = new System.Drawing.Size(77, 22);
            this.minTimesRadioButton.TabIndex = 3;
            this.minTimesRadioButton.Text = "(min, ×)";
            this.minTimesRadioButton.UseVisualStyleBackColor = true;
            // 
            // minPlusRadioButton
            // 
            this.minPlusRadioButton.AutoSize = true;
            this.minPlusRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minPlusRadioButton.Location = new System.Drawing.Point(257, 29);
            this.minPlusRadioButton.Name = "minPlusRadioButton";
            this.minPlusRadioButton.Size = new System.Drawing.Size(77, 22);
            this.minPlusRadioButton.TabIndex = 2;
            this.minPlusRadioButton.Text = "(min, +)";
            this.minPlusRadioButton.UseVisualStyleBackColor = true;
            // 
            // maxTimesRadioButton
            // 
            this.maxTimesRadioButton.AutoSize = true;
            this.maxTimesRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maxTimesRadioButton.Location = new System.Drawing.Point(6, 74);
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
            this.maxPlusRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maxPlusRadioButton.Location = new System.Drawing.Point(6, 29);
            this.maxPlusRadioButton.Name = "maxPlusRadioButton";
            this.maxPlusRadioButton.Size = new System.Drawing.Size(81, 22);
            this.maxPlusRadioButton.TabIndex = 0;
            this.maxPlusRadioButton.TabStop = true;
            this.maxPlusRadioButton.Text = "(max, +)";
            this.maxPlusRadioButton.UseVisualStyleBackColor = true;
            // 
            // pDbyQRichTextBox
            // 
            this.pDbyQRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pDbyQRichTextBox.Location = new System.Drawing.Point(86, 91);
            this.pDbyQRichTextBox.Multiline = false;
            this.pDbyQRichTextBox.Name = "pDbyQRichTextBox";
            this.pDbyQRichTextBox.ReadOnly = true;
            this.pDbyQRichTextBox.Size = new System.Drawing.Size(269, 32);
            this.pDbyQRichTextBox.TabIndex = 11;
            this.pDbyQRichTextBox.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "P(x)/Q(x)";
            // 
            // kNumericUpDown
            // 
            this.kNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kNumericUpDown.Location = new System.Drawing.Point(86, 183);
            this.kNumericUpDown.Name = "kNumericUpDown";
            this.kNumericUpDown.Size = new System.Drawing.Size(120, 24);
            this.kNumericUpDown.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(64, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "k";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "x from";
            // 
            // xFromTextBox
            // 
            this.xFromTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xFromTextBox.Location = new System.Drawing.Point(86, 220);
            this.xFromTextBox.Name = "xFromTextBox";
            this.xFromTextBox.Size = new System.Drawing.Size(100, 24);
            this.xFromTextBox.TabIndex = 15;
            this.xFromTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxInputHandler);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(212, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "to";
            // 
            // xToTextBox
            // 
            this.xToTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xToTextBox.Location = new System.Drawing.Point(255, 220);
            this.xToTextBox.Name = "xToTextBox";
            this.xToTextBox.Size = new System.Drawing.Size(100, 24);
            this.xToTextBox.TabIndex = 17;
            this.xToTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxInputHandler);
            // 
            // BuildButton
            // 
            this.BuildButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BuildButton.Location = new System.Drawing.Point(67, 277);
            this.BuildButton.Name = "BuildButton";
            this.BuildButton.Size = new System.Drawing.Size(77, 29);
            this.BuildButton.TabIndex = 18;
            this.BuildButton.Text = "Build";
            this.BuildButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 540);
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
            this.Controls.Add(this.chart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fRichTextBox);
            this.Controls.Add(this.qRichTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pRichTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Tropical Palm";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
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
    }
}

