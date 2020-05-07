namespace BasicControls
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
            this.ExampleLabel = new System.Windows.Forms.Label();
            this.ExampleLinkLabel = new System.Windows.Forms.LinkLabel();
            this.TransferButton = new System.Windows.Forms.Button();
            this.ExampleRadioButton = new System.Windows.Forms.RadioButton();
            this.ExampleCheckBox = new System.Windows.Forms.CheckBox();
            this.ExampleTextBox = new System.Windows.Forms.TextBox();
            this.ExamplePictureBox = new System.Windows.Forms.PictureBox();
            this.ExampleCheckBox2 = new System.Windows.Forms.CheckBox();
            this.ExampleRadioButton2 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.ExamplePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ExampleLabel
            // 
            this.ExampleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExampleLabel.AutoSize = true;
            this.ExampleLabel.Location = new System.Drawing.Point(235, 17);
            this.ExampleLabel.Name = "ExampleLabel";
            this.ExampleLabel.Size = new System.Drawing.Size(92, 17);
            this.ExampleLabel.TabIndex = 0;
            this.ExampleLabel.Text = "Example Text";
            // 
            // ExampleLinkLabel
            // 
            this.ExampleLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ExampleLinkLabel.AutoSize = true;
            this.ExampleLinkLabel.Location = new System.Drawing.Point(12, 424);
            this.ExampleLinkLabel.Name = "ExampleLinkLabel";
            this.ExampleLinkLabel.Size = new System.Drawing.Size(90, 17);
            this.ExampleLinkLabel.TabIndex = 1;
            this.ExampleLinkLabel.TabStop = true;
            this.ExampleLinkLabel.Text = "Show Picture";
            this.ExampleLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ExampleLinkLabel_LinkClicked);
            // 
            // TransferButton
            // 
            this.TransferButton.Location = new System.Drawing.Point(12, 12);
            this.TransferButton.Name = "TransferButton";
            this.TransferButton.Size = new System.Drawing.Size(75, 27);
            this.TransferButton.TabIndex = 2;
            this.TransferButton.Text = "Transfer";
            this.TransferButton.UseVisualStyleBackColor = true;
            this.TransferButton.Click += new System.EventHandler(this.TransferButton_Click);
            // 
            // ExampleRadioButton
            // 
            this.ExampleRadioButton.AutoSize = true;
            this.ExampleRadioButton.Location = new System.Drawing.Point(131, 45);
            this.ExampleRadioButton.Name = "ExampleRadioButton";
            this.ExampleRadioButton.Size = new System.Drawing.Size(110, 21);
            this.ExampleRadioButton.TabIndex = 3;
            this.ExampleRadioButton.TabStop = true;
            this.ExampleRadioButton.Text = "radioButton1";
            this.ExampleRadioButton.UseVisualStyleBackColor = true;
            this.ExampleRadioButton.CheckedChanged += new System.EventHandler(this.ExampleRadioButton_CheckedChanged);
            // 
            // ExampleCheckBox
            // 
            this.ExampleCheckBox.AutoSize = true;
            this.ExampleCheckBox.Location = new System.Drawing.Point(12, 45);
            this.ExampleCheckBox.Name = "ExampleCheckBox";
            this.ExampleCheckBox.Size = new System.Drawing.Size(98, 21);
            this.ExampleCheckBox.TabIndex = 4;
            this.ExampleCheckBox.Text = "checkBox1";
            this.ExampleCheckBox.UseVisualStyleBackColor = true;
            this.ExampleCheckBox.CheckedChanged += new System.EventHandler(this.ExampleCheckBox_CheckedChanged);
            // 
            // ExampleTextBox
            // 
            this.ExampleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExampleTextBox.Location = new System.Drawing.Point(93, 14);
            this.ExampleTextBox.Name = "ExampleTextBox";
            this.ExampleTextBox.Size = new System.Drawing.Size(136, 22);
            this.ExampleTextBox.TabIndex = 5;
            // 
            // ExamplePictureBox
            // 
            this.ExamplePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExamplePictureBox.BackColor = System.Drawing.Color.Black;
            this.ExamplePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ExamplePictureBox.Location = new System.Drawing.Point(12, 99);
            this.ExamplePictureBox.Name = "ExamplePictureBox";
            this.ExamplePictureBox.Size = new System.Drawing.Size(636, 322);
            this.ExamplePictureBox.TabIndex = 6;
            this.ExamplePictureBox.TabStop = false;
            // 
            // ExampleCheckBox2
            // 
            this.ExampleCheckBox2.AutoSize = true;
            this.ExampleCheckBox2.Location = new System.Drawing.Point(12, 72);
            this.ExampleCheckBox2.Name = "ExampleCheckBox2";
            this.ExampleCheckBox2.Size = new System.Drawing.Size(98, 21);
            this.ExampleCheckBox2.TabIndex = 4;
            this.ExampleCheckBox2.Text = "checkBox1";
            this.ExampleCheckBox2.UseVisualStyleBackColor = true;
            this.ExampleCheckBox2.CheckedChanged += new System.EventHandler(this.ExampleCheckBox2_CheckedChanged);
            // 
            // ExampleRadioButton2
            // 
            this.ExampleRadioButton2.AutoSize = true;
            this.ExampleRadioButton2.Location = new System.Drawing.Point(131, 72);
            this.ExampleRadioButton2.Name = "ExampleRadioButton2";
            this.ExampleRadioButton2.Size = new System.Drawing.Size(110, 21);
            this.ExampleRadioButton2.TabIndex = 3;
            this.ExampleRadioButton2.TabStop = true;
            this.ExampleRadioButton2.Text = "radioButton1";
            this.ExampleRadioButton2.UseVisualStyleBackColor = true;
            this.ExampleRadioButton2.CheckedChanged += new System.EventHandler(this.ExampleRadioButton2_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 450);
            this.Controls.Add(this.ExamplePictureBox);
            this.Controls.Add(this.ExampleTextBox);
            this.Controls.Add(this.ExampleCheckBox2);
            this.Controls.Add(this.ExampleCheckBox);
            this.Controls.Add(this.ExampleRadioButton2);
            this.Controls.Add(this.ExampleRadioButton);
            this.Controls.Add(this.TransferButton);
            this.Controls.Add(this.ExampleLinkLabel);
            this.Controls.Add(this.ExampleLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ExamplePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ExampleLabel;
        private System.Windows.Forms.LinkLabel ExampleLinkLabel;
        private System.Windows.Forms.Button TransferButton;
        private System.Windows.Forms.RadioButton ExampleRadioButton;
        private System.Windows.Forms.CheckBox ExampleCheckBox;
        private System.Windows.Forms.TextBox ExampleTextBox;
        private System.Windows.Forms.PictureBox ExamplePictureBox;
        private System.Windows.Forms.CheckBox ExampleCheckBox2;
        private System.Windows.Forms.RadioButton ExampleRadioButton2;
    }
}

