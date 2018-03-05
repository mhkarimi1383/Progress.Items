namespace PregressBar_test
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressRing1 = new ProgressBar.ProgressRing();
            this.progressBar1 = new ProgressBar.ProgressBar();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressRing1
            // 
            this.progressRing1.BackgroundColor = System.Drawing.Color.White;
            this.progressRing1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.progressRing1.Location = new System.Drawing.Point(23, 5);
            this.progressRing1.Name = "progressRing1";
            this.progressRing1.ProgressColor = System.Drawing.Color.Red;
            this.progressRing1.ProgressTransform = -90F;
            this.progressRing1.Size = new System.Drawing.Size(400, 400);
            this.progressRing1.TabIndex = 1;
            this.progressRing1.TextTransform = 90F;
            this.progressRing1.UseWaitCursor = true;
            this.progressRing1.Value = 0;
            this.progressRing1.ValueTextColor = System.Drawing.Color.Red;
            this.progressRing1.ValueTextFont = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.Transparent;
            this.progressBar1.BackgroundColor = System.Drawing.Color.White;
            this.progressBar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.progressBar1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.progressBar1.Location = new System.Drawing.Point(429, 375);
            this.progressBar1.Maximum = 100;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.ProgressColor = System.Drawing.Color.Red;
            this.progressBar1.Size = new System.Drawing.Size(788, 30);
            this.progressBar1.TabIndex = 0;
            this.progressBar1.UseWaitCursor = true;
            this.progressBar1.Value = 0F;
            this.progressBar1.ValueTextColor = System.Drawing.Color.Red;
            this.progressBar1.ValueTextFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 430);
            this.Controls.Add(this.progressRing1);
            this.Controls.Add(this.progressBar1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private ProgressBar.ProgressBar progressBar1;
        private ProgressBar.ProgressRing progressRing1;
    }
}