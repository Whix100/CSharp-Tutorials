using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List_Controls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ExComboBox.SelectedIndex = 0;
            ExListBox.SelectedIndex = 0;
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            if (CBRadioButton.Checked == true)
            {
                MessageBox.Show(ExComboBox.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show(ExListBox.SelectedItem.ToString());
            }
        }
    }
}
