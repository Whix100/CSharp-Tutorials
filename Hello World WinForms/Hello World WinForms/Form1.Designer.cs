namespace Hello_World_WinForms
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
            this.HWButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HWButton
            // 
            this.HWButton.Location = new System.Drawing.Point(12, 12);
            this.HWButton.Name = "HWButton";
            this.HWButton.Size = new System.Drawing.Size(192, 88);
            this.HWButton.TabIndex = 0;
            this.HWButton.Text = "Hello World";
            this.HWButton.UseVisualStyleBackColor = true;
            this.HWButton.Click += new System.EventHandler(this.HWButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 112);
            this.Controls.Add(this.HWButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button HWButton;
    }
}

