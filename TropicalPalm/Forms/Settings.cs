using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TropicalPalm.Forms {
    public partial class Settings:Form {
        public Settings() {
            InitializeComponent();
        }

        private void shortCoeffsCheckBox_CheckedChanged(object sender, EventArgs e) {
            Tools.ShortCoeffs = shortCoeffsCheckBox.Checked;
        }

        private void Settings_Load(object sender, EventArgs e) {
            shortCoeffsCheckBox.Checked = Tools.ShortCoeffs;
        }
    }
}
