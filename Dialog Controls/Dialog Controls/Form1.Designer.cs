namespace Dialog_Controls
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
            this.ColorTextBox = new System.Windows.Forms.TextBox();
            this.ColorButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FolderTextBox = new System.Windows.Forms.TextBox();
            this.FolderButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.OpenTextBox = new System.Windows.Forms.TextBox();
            this.OpenButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SaveTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.FontTextBox = new System.Windows.Forms.TextBox();
            this.FontButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ColorTextBox
            // 
            this.ColorTextBox.Location = new System.Drawing.Point(64, 6);
            this.ColorTextBox.Name = "ColorTextBox";
            this.ColorTextBox.Size = new System.Drawing.Size(100, 22);
            this.ColorTextBox.TabIndex = 0;
            // 
            // ColorButton
            // 
            this.ColorButton.Location = new System.Drawing.Point(170, 5);
            this.ColorButton.Name = "ColorButton";
            this.ColorButton.Size = new System.Drawing.Size(75, 25);
            this.ColorButton.TabIndex = 1;
            this.ColorButton.Text = "Browse";
            this.ColorButton.UseVisualStyleBackColor = true;
            this.ColorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Color:";
            // 
            // FolderTextBox
            // 
            this.FolderTextBox.Location = new System.Drawing.Point(64, 37);
            this.FolderTextBox.Name = "FolderTextBox";
            this.FolderTextBox.Size = new System.Drawing.Size(100, 22);
            this.FolderTextBox.TabIndex = 0;
            // 
            // FolderButton
            // 
            this.FolderButton.Location = new System.Drawing.Point(170, 36);
            this.FolderButton.Name = "FolderButton";
            this.FolderButton.Size = new System.Drawing.Size(75, 25);
            this.FolderButton.TabIndex = 1;
            this.FolderButton.Text = "Browse";
            this.FolderButton.UseVisualStyleBackColor = true;
            this.FolderButton.Click += new System.EventHandler(this.FolderButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Folder:";
            // 
            // OpenTextBox
            // 
            this.OpenTextBox.Location = new System.Drawing.Point(64, 68);
            this.OpenTextBox.Name = "OpenTextBox";
            this.OpenTextBox.Size = new System.Drawing.Size(100, 22);
            this.OpenTextBox.TabIndex = 0;
            // 
            // OpenButton
            // 
            this.OpenButton.Location = new System.Drawing.Point(170, 67);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(75, 25);
            this.OpenButton.TabIndex = 1;
            this.OpenButton.Text = "Browse";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Open:";
            // 
            // SaveTextBox
            // 
            this.SaveTextBox.Location = new System.Drawing.Point(64, 99);
            this.SaveTextBox.Name = "SaveTextBox";
            this.SaveTextBox.Size = new System.Drawing.Size(100, 22);
            this.SaveTextBox.TabIndex = 0;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(170, 98);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 25);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Browse";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Save:";
            // 
            // FontTextBox
            // 
            this.FontTextBox.Location = new System.Drawing.Point(64, 130);
            this.FontTextBox.Name = "FontTextBox";
            this.FontTextBox.Size = new System.Drawing.Size(100, 22);
            this.FontTextBox.TabIndex = 0;
            // 
            // FontButton
            // 
            this.FontButton.Location = new System.Drawing.Point(170, 129);
            this.FontButton.Name = "FontButton";
            this.FontButton.Size = new System.Drawing.Size(75, 25);
            this.FontButton.TabIndex = 1;
            this.FontButton.Text = "Browse";
            this.FontButton.UseVisualStyleBackColor = true;
            this.FontButton.Click += new System.EventHandler(this.FontButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Font:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 169);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FontButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.FontTextBox);
            this.Controls.Add(this.OpenButton);
            this.Controls.Add(this.SaveTextBox);
            this.Controls.Add(this.FolderButton);
            this.Controls.Add(this.OpenTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FolderTextBox);
            this.Controls.Add(this.ColorButton);
            this.Controls.Add(this.ColorTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ColorTextBox;
        private System.Windows.Forms.Button ColorButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FolderTextBox;
        private System.Windows.Forms.Button FolderButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox OpenTextBox;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SaveTextBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox FontTextBox;
        private System.Windows.Forms.Button FontButton;
        private System.Windows.Forms.Label label5;
    }
}

