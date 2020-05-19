namespace List_Controls
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ExComboBox = new System.Windows.Forms.ComboBox();
            this.ExListBox = new System.Windows.Forms.ListBox();
            this.ShowButton = new System.Windows.Forms.Button();
            this.CBRadioButton = new System.Windows.Forms.RadioButton();
            this.LBRadioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // ExComboBox
            // 
            this.ExComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ExComboBox.FormattingEnabled = true;
            this.ExComboBox.Items.AddRange(new object[] {
            "Comb0",
            "Combo1",
            "Combo2",
            "Combo3",
            "Combo4"});
            this.ExComboBox.Location = new System.Drawing.Point(12, 12);
            this.ExComboBox.Name = "ExComboBox";
            this.ExComboBox.Size = new System.Drawing.Size(121, 24);
            this.ExComboBox.TabIndex = 1;
            // 
            // ExListBox
            // 
            this.ExListBox.FormattingEnabled = true;
            this.ExListBox.ItemHeight = 16;
            this.ExListBox.Items.AddRange(new object[] {
            "List0",
            "List1",
            "List2",
            "List3",
            "List4"});
            this.ExListBox.Location = new System.Drawing.Point(12, 42);
            this.ExListBox.Name = "ExListBox";
            this.ExListBox.Size = new System.Drawing.Size(121, 84);
            this.ExListBox.TabIndex = 2;
            // 
            // ShowButton
            // 
            this.ShowButton.Location = new System.Drawing.Point(139, 66);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(110, 28);
            this.ShowButton.TabIndex = 3;
            this.ShowButton.Text = "Selected Item";
            this.ShowButton.UseVisualStyleBackColor = true;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // CBRadioButton
            // 
            this.CBRadioButton.AutoSize = true;
            this.CBRadioButton.Checked = true;
            this.CBRadioButton.Location = new System.Drawing.Point(139, 12);
            this.CBRadioButton.Name = "CBRadioButton";
            this.CBRadioButton.Size = new System.Drawing.Size(96, 21);
            this.CBRadioButton.TabIndex = 4;
            this.CBRadioButton.TabStop = true;
            this.CBRadioButton.Text = "ComboBox";
            this.CBRadioButton.UseVisualStyleBackColor = true;
            // 
            // LBRadioButton
            // 
            this.LBRadioButton.AutoSize = true;
            this.LBRadioButton.Location = new System.Drawing.Point(139, 39);
            this.LBRadioButton.Name = "LBRadioButton";
            this.LBRadioButton.Size = new System.Drawing.Size(74, 21);
            this.LBRadioButton.TabIndex = 5;
            this.LBRadioButton.Text = "ListBox";
            this.LBRadioButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 141);
            this.Controls.Add(this.LBRadioButton);
            this.Controls.Add(this.CBRadioButton);
            this.Controls.Add(this.ShowButton);
            this.Controls.Add(this.ExListBox);
            this.Controls.Add(this.ExComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "List Controls";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ExComboBox;
        private System.Windows.Forms.ListBox ExListBox;
        private System.Windows.Forms.Button ShowButton;
        private System.Windows.Forms.RadioButton CBRadioButton;
        private System.Windows.Forms.RadioButton LBRadioButton;
    }
}

