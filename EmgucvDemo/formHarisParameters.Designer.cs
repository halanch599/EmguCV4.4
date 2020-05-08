namespace EmgucvDemo
{
    partial class formHarisParameters
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
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(-1, 30);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(465, 56);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMin.Location = new System.Drawing.Point(13, 7);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(53, 20);
            this.lblMin.TabIndex = 1;
            this.lblMin.Text = "label1";
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCurrent.Location = new System.Drawing.Point(217, 9);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(53, 20);
            this.lblCurrent.TabIndex = 2;
            this.lblCurrent.Text = "label1";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMax.Location = new System.Drawing.Point(387, 9);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(53, 20);
            this.lblMax.TabIndex = 3;
            this.lblMax.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(335, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // formHarisParameters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 116);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblCurrent);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.trackBar1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(481, 163);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(481, 163);
            this.Name = "formHarisParameters";
            this.Text = "Haris Parameters";
            this.Load += new System.EventHandler(this.formHarisParameters_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Button button1;
    }
}