using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Min_Max_Controls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ExNUmUpDown_ValueChanged(object sender, EventArgs e)
        {
            ExProgressBar.Value = (int)ExNumUpDown.Value;
            ExTrackBar.Value = (int)ExNumUpDown.Value;
            ExScrollBar.Value = (int)ExNumUpDown.Value;
        }

        private void ExTrackBar_Scroll(object sender, EventArgs e)
        {
            ExProgressBar.Value = ExTrackBar.Value;
            ExNumUpDown.Value = ExTrackBar.Value;
            ExScrollBar.Value = ExTrackBar.Value;
        }

        private void ExScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            ExProgressBar.Value = ExScrollBar.Value;
            ExNumUpDown.Value = ExScrollBar.Value;
            ExTrackBar.Value = ExScrollBar.Value;
        }
    }
}
