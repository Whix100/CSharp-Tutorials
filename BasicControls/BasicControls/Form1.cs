using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TransferButton_Click(object sender, EventArgs e)
        {
            ExampleLabel.Text = ExampleTextBox.Text;
        }

        private void ExampleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ExampleCheckBox.Checked == true)
            {
                ExampleCheckBox.Text = "Checked";
            }
            else
            {
                ExampleCheckBox.Text = "UnChecked";
            }
        }

        private void ExampleCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (ExampleCheckBox2.Checked == true)
            {
                ExampleCheckBox2.Text = "Checked";
            }
            else
            {
                ExampleCheckBox2.Text = "UnChecked";
            }
        }

        private void ExampleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ExampleRadioButton.Checked == true)
            {
                ExampleRadioButton.Text = "Checked";
            }
            else
            {
                ExampleRadioButton.Text = "UnChecked";
            }
        }

        private void ExampleRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (ExampleRadioButton2.Checked == true)
            {
                ExampleRadioButton2.Text = "Checked";
            }
            else
            {
                ExampleRadioButton2.Text = "UnChecked";
            }
        }

        private void ExampleLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ExamplePictureBox.BackgroundImage = BasicControls.Properties.Resources.TestImage;
        }
    }
}
