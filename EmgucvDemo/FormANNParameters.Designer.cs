namespace EmgucvDemo
{
    partial class FormANNParameters
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbActivationFunction = new System.Windows.Forms.ComboBox();
            this.cbTrainedMethod = new System.Windows.Forms.ComboBox();
            this.tbMomentum = new System.Windows.Forms.TextBox();
            this.tbIterations = new System.Windows.Forms.TextBox();
            this.tbRMSE = new System.Windows.Forms.TextBox();
            this.tbLayerSize = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbSaveModel = new System.Windows.Forms.CheckBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Activation Function :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Layer Size :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "RMSE :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Momentum :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Trained Method";
            // 
            // cbActivationFunction
            // 
            this.cbActivationFunction.FormattingEnabled = true;
            this.cbActivationFunction.Location = new System.Drawing.Point(177, 45);
            this.cbActivationFunction.Name = "cbActivationFunction";
            this.cbActivationFunction.Size = new System.Drawing.Size(194, 24);
            this.cbActivationFunction.TabIndex = 5;
            // 
            // cbTrainedMethod
            // 
            this.cbTrainedMethod.FormattingEnabled = true;
            this.cbTrainedMethod.Location = new System.Drawing.Point(177, 75);
            this.cbTrainedMethod.Name = "cbTrainedMethod";
            this.cbTrainedMethod.Size = new System.Drawing.Size(194, 24);
            this.cbTrainedMethod.TabIndex = 6;
            // 
            // tbMomentum
            // 
            this.tbMomentum.Location = new System.Drawing.Point(177, 105);
            this.tbMomentum.Name = "tbMomentum";
            this.tbMomentum.Size = new System.Drawing.Size(194, 22);
            this.tbMomentum.TabIndex = 7;
            // 
            // tbIterations
            // 
            this.tbIterations.Location = new System.Drawing.Point(177, 161);
            this.tbIterations.Name = "tbIterations";
            this.tbIterations.Size = new System.Drawing.Size(194, 22);
            this.tbIterations.TabIndex = 8;
            // 
            // tbRMSE
            // 
            this.tbRMSE.Location = new System.Drawing.Point(177, 133);
            this.tbRMSE.Name = "tbRMSE";
            this.tbRMSE.Size = new System.Drawing.Size(194, 22);
            this.tbRMSE.TabIndex = 9;
            // 
            // tbLayerSize
            // 
            this.tbLayerSize.Location = new System.Drawing.Point(177, 189);
            this.tbLayerSize.Name = "tbLayerSize";
            this.tbLayerSize.Size = new System.Drawing.Size(194, 22);
            this.tbLayerSize.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(66, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 29);
            this.button1.TabIndex = 11;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(288, 260);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 29);
            this.button2.TabIndex = 12;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(177, 260);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 29);
            this.button3.TabIndex = 13;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(97, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Iterations :";
            // 
            // cbSaveModel
            // 
            this.cbSaveModel.AutoSize = true;
            this.cbSaveModel.Location = new System.Drawing.Point(177, 217);
            this.cbSaveModel.Name = "cbSaveModel";
            this.cbSaveModel.Size = new System.Drawing.Size(156, 21);
            this.cbSaveModel.TabIndex = 15;
            this.cbSaveModel.Text = "Load Saved Model?";
            this.cbSaveModel.UseVisualStyleBackColor = true;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(177, 13);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 17);
            this.lblMessage.TabIndex = 16;
            // 
            // FormANNParameters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 312);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.cbSaveModel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbLayerSize);
            this.Controls.Add(this.tbRMSE);
            this.Controls.Add(this.tbIterations);
            this.Controls.Add(this.tbMomentum);
            this.Controls.Add(this.cbTrainedMethod);
            this.Controls.Add(this.cbActivationFunction);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormANNParameters";
            this.Text = "ANN Parameters";
            this.Load += new System.EventHandler(this.FormANNParameters_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbActivationFunction;
        private System.Windows.Forms.ComboBox cbTrainedMethod;
        private System.Windows.Forms.TextBox tbMomentum;
        private System.Windows.Forms.TextBox tbIterations;
        private System.Windows.Forms.TextBox tbRMSE;
        private System.Windows.Forms.TextBox tbLayerSize;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbSaveModel;
        private System.Windows.Forms.Label lblMessage;
    }
}