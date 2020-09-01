namespace EmgucvDemo
{
    partial class formParameterTable2Text
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
            this.tbBinaryThreshold = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tboffset = new System.Windows.Forms.TextBox();
            this.tbMorphThreshold = new System.Windows.Forms.TextBox();
            this.tbNoCols = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbBinaryThreshold
            // 
            this.tbBinaryThreshold.Location = new System.Drawing.Point(156, 127);
            this.tbBinaryThreshold.Name = "tbBinaryThreshold";
            this.tbBinaryThreshold.Size = new System.Drawing.Size(131, 22);
            this.tbBinaryThreshold.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Binary Threshold";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(153, 23);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 17);
            this.lblMessage.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(156, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 29);
            this.button1.TabIndex = 16;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tboffset
            // 
            this.tboffset.Location = new System.Drawing.Point(156, 99);
            this.tboffset.Name = "tboffset";
            this.tboffset.Size = new System.Drawing.Size(131, 22);
            this.tboffset.TabIndex = 15;
            // 
            // tbMorphThreshold
            // 
            this.tbMorphThreshold.Location = new System.Drawing.Point(156, 71);
            this.tbMorphThreshold.Name = "tbMorphThreshold";
            this.tbMorphThreshold.Size = new System.Drawing.Size(131, 22);
            this.tbMorphThreshold.TabIndex = 14;
            // 
            // tbNoCols
            // 
            this.tbNoCols.Location = new System.Drawing.Point(156, 43);
            this.tbNoCols.Name = "tbNoCols";
            this.tbNoCols.Size = new System.Drawing.Size(131, 22);
            this.tbNoCols.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "offset";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "MorphThreshold";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "NoCols";
            // 
            // formParameterTable2Text
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 214);
            this.Controls.Add(this.tbBinaryThreshold);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tboffset);
            this.Controls.Add(this.tbMorphThreshold);
            this.Controls.Add(this.tbNoCols);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "formParameterTable2Text";
            this.Text = "formParameterTable2Text";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbBinaryThreshold;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tboffset;
        private System.Windows.Forms.TextBox tbMorphThreshold;
        private System.Windows.Forms.TextBox tbNoCols;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}