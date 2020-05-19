namespace Min_Max_Controls
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
            this.ExProgressBar = new System.Windows.Forms.ProgressBar();
            this.ExNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.ExTrackBar = new System.Windows.Forms.TrackBar();
            this.ExScrollBar = new System.Windows.Forms.HScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.ExNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // ExProgressBar
            // 
            this.ExProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ExProgressBar.Location = new System.Drawing.Point(12, 12);
            this.ExProgressBar.Name = "ExProgressBar";
            this.ExProgressBar.Size = new System.Drawing.Size(776, 23);
            this.ExProgressBar.Step = 1;
            this.ExProgressBar.TabIndex = 0;
            // 
            // ExNumUpDown
            // 
            this.ExNumUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ExNumUpDown.Location = new System.Drawing.Point(12, 41);
            this.ExNumUpDown.Name = "ExNumUpDown";
            this.ExNumUpDown.Size = new System.Drawing.Size(776, 22);
            this.ExNumUpDown.TabIndex = 1;
            this.ExNumUpDown.ValueChanged += new System.EventHandler(this.ExNUmUpDown_ValueChanged);
            // 
            // ExTrackBar
            // 
            this.ExTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ExTrackBar.Location = new System.Drawing.Point(12, 69);
            this.ExTrackBar.Maximum = 100;
            this.ExTrackBar.Name = "ExTrackBar";
            this.ExTrackBar.Size = new System.Drawing.Size(776, 56);
            this.ExTrackBar.TabIndex = 2;
            this.ExTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.ExTrackBar.Scroll += new System.EventHandler(this.ExTrackBar_Scroll);
            // 
            // ExScrollBar
            // 
            this.ExScrollBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ExScrollBar.LargeChange = 1;
            this.ExScrollBar.Location = new System.Drawing.Point(12, 104);
            this.ExScrollBar.Name = "ExScrollBar";
            this.ExScrollBar.Size = new System.Drawing.Size(776, 21);
            this.ExScrollBar.TabIndex = 3;
            this.ExScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ExScrollBar_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 147);
            this.Controls.Add(this.ExScrollBar);
            this.Controls.Add(this.ExTrackBar);
            this.Controls.Add(this.ExNumUpDown);
            this.Controls.Add(this.ExProgressBar);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(10000, 194);
            this.MinimumSize = new System.Drawing.Size(0, 194);
            this.Name = "Form1";
            this.Text = "Min-Max Controls";
            ((System.ComponentModel.ISupportInitialize)(this.ExNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar ExProgressBar;
        private System.Windows.Forms.NumericUpDown ExNumUpDown;
        private System.Windows.Forms.TrackBar ExTrackBar;
        private System.Windows.Forms.HScrollBar ExScrollBar;
    }
}

