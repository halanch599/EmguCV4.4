namespace EmgucvDemo
{
    partial class FormConfusionMatrix
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
            this.dgvConfusionMatrix = new System.Windows.Forms.DataGridView();
            this.rtbSummary = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConfusionMatrix)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConfusionMatrix
            // 
            this.dgvConfusionMatrix.AllowUserToAddRows = false;
            this.dgvConfusionMatrix.AllowUserToDeleteRows = false;
            this.dgvConfusionMatrix.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvConfusionMatrix.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvConfusionMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConfusionMatrix.Location = new System.Drawing.Point(12, 12);
            this.dgvConfusionMatrix.Name = "dgvConfusionMatrix";
            this.dgvConfusionMatrix.ReadOnly = true;
            this.dgvConfusionMatrix.RowHeadersWidth = 51;
            this.dgvConfusionMatrix.RowTemplate.Height = 24;
            this.dgvConfusionMatrix.Size = new System.Drawing.Size(776, 314);
            this.dgvConfusionMatrix.TabIndex = 0;
            // 
            // rtbSummary
            // 
            this.rtbSummary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbSummary.Location = new System.Drawing.Point(12, 342);
            this.rtbSummary.Name = "rtbSummary";
            this.rtbSummary.Size = new System.Drawing.Size(776, 96);
            this.rtbSummary.TabIndex = 1;
            this.rtbSummary.Text = "";
            // 
            // FormConfusionMatrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbSummary);
            this.Controls.Add(this.dgvConfusionMatrix);
            this.Name = "FormConfusionMatrix";
            this.Text = "FormConfusionMatrix";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConfusionMatrix)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConfusionMatrix;
        private System.Windows.Forms.RichTextBox rtbSummary;
    }
}