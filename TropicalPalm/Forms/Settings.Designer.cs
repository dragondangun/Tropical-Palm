namespace TropicalPalm.Forms {
    partial class Settings {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            shortCoeffsCheckBox = new System.Windows.Forms.CheckBox();
            SuspendLayout();
            // 
            // shortCoeffsCheckBox
            // 
            shortCoeffsCheckBox.AutoSize = true;
            shortCoeffsCheckBox.Checked = true;
            shortCoeffsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            shortCoeffsCheckBox.Location = new System.Drawing.Point(12, 29);
            shortCoeffsCheckBox.Name = "shortCoeffsCheckBox";
            shortCoeffsCheckBox.Size = new System.Drawing.Size(176, 19);
            shortCoeffsCheckBox.TabIndex = 0;
            shortCoeffsCheckBox.Text = "Сокращать коэффициенты";
            shortCoeffsCheckBox.UseVisualStyleBackColor = true;
            shortCoeffsCheckBox.CheckedChanged += shortCoeffsCheckBox_CheckedChanged;
            // 
            // Settings
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(214, 82);
            Controls.Add(shortCoeffsCheckBox);
            Name = "Settings";
            Text = "Settings";
            Load += Settings_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.CheckBox shortCoeffsCheckBox;
    }
}