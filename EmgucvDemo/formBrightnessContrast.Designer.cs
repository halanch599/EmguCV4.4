
namespace EmgucvDemo
{
    partial class formBrightnessContrast
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.lblMinContrast = new System.Windows.Forms.Label();
            this.lblCurrentContrast = new System.Windows.Forms.Label();
            this.lblMaxContrast = new System.Windows.Forms.Label();
            this.lblMaxBrightness = new System.Windows.Forms.Label();
            this.lblCurrentBrightness = new System.Windows.Forms.Label();
            this.lblMinBrightness = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(863, 33);
            this.panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(863, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblMaxContrast);
            this.groupBox1.Controls.Add(this.lblCurrentContrast);
            this.groupBox1.Controls.Add(this.lblMinContrast);
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 405);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(863, 97);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contrast";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblMinBrightness);
            this.groupBox2.Controls.Add(this.lblCurrentBrightness);
            this.groupBox2.Controls.Add(this.lblMaxBrightness);
            this.groupBox2.Controls.Add(this.trackBar2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(728, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(135, 372);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Brightness";
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.trackBar1.Location = new System.Drawing.Point(3, 18);
            this.trackBar1.Maximum = 500;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(857, 39);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Value = 100;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.AutoSize = false;
            this.trackBar2.Dock = System.Windows.Forms.DockStyle.Left;
            this.trackBar2.Location = new System.Drawing.Point(3, 18);
            this.trackBar2.Maximum = 100;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar2.Size = new System.Drawing.Size(47, 351);
            this.trackBar2.TabIndex = 0;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // lblMinContrast
            // 
            this.lblMinContrast.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblMinContrast.AutoSize = true;
            this.lblMinContrast.Location = new System.Drawing.Point(13, 64);
            this.lblMinContrast.Name = "lblMinContrast";
            this.lblMinContrast.Size = new System.Drawing.Size(46, 17);
            this.lblMinContrast.TabIndex = 1;
            this.lblMinContrast.Text = "label1";
            // 
            // lblCurrentContrast
            // 
            this.lblCurrentContrast.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblCurrentContrast.AutoSize = true;
            this.lblCurrentContrast.Location = new System.Drawing.Point(370, 74);
            this.lblCurrentContrast.Name = "lblCurrentContrast";
            this.lblCurrentContrast.Size = new System.Drawing.Size(46, 17);
            this.lblCurrentContrast.TabIndex = 2;
            this.lblCurrentContrast.Text = "label2";
            // 
            // lblMaxContrast
            // 
            this.lblMaxContrast.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblMaxContrast.AutoSize = true;
            this.lblMaxContrast.Location = new System.Drawing.Point(813, 63);
            this.lblMaxContrast.Name = "lblMaxContrast";
            this.lblMaxContrast.Size = new System.Drawing.Size(46, 17);
            this.lblMaxContrast.TabIndex = 3;
            this.lblMaxContrast.Text = "label3";
            // 
            // lblMaxBrightness
            // 
            this.lblMaxBrightness.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMaxBrightness.AutoSize = true;
            this.lblMaxBrightness.Location = new System.Drawing.Point(68, 18);
            this.lblMaxBrightness.Name = "lblMaxBrightness";
            this.lblMaxBrightness.Size = new System.Drawing.Size(46, 17);
            this.lblMaxBrightness.TabIndex = 1;
            this.lblMaxBrightness.Text = "label4";
            // 
            // lblCurrentBrightness
            // 
            this.lblCurrentBrightness.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCurrentBrightness.AutoSize = true;
            this.lblCurrentBrightness.Location = new System.Drawing.Point(71, 168);
            this.lblCurrentBrightness.Name = "lblCurrentBrightness";
            this.lblCurrentBrightness.Size = new System.Drawing.Size(46, 17);
            this.lblCurrentBrightness.TabIndex = 2;
            this.lblCurrentBrightness.Text = "label5";
            // 
            // lblMinBrightness
            // 
            this.lblMinBrightness.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMinBrightness.AutoSize = true;
            this.lblMinBrightness.Location = new System.Drawing.Point(74, 349);
            this.lblMinBrightness.Name = "lblMinBrightness";
            this.lblMinBrightness.Size = new System.Drawing.Size(46, 17);
            this.lblMinBrightness.TabIndex = 3;
            this.lblMinBrightness.Text = "label6";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(728, 372);
            this.panel2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(728, 372);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // formBrightnessContrast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 502);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "formBrightnessContrast";
            this.Text = "formBrightnessContrast";
            this.Load += new System.EventHandler(this.formBrightnessContrast_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblMaxContrast;
        private System.Windows.Forms.Label lblCurrentContrast;
        private System.Windows.Forms.Label lblMinContrast;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblMinBrightness;
        private System.Windows.Forms.Label lblCurrentBrightness;
        private System.Windows.Forms.Label lblMaxBrightness;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}