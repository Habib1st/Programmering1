namespace Text_3._6t
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
            this.lblSvar = new System.Windows.Forms.Label();
            this.lblSvenska = new System.Windows.Forms.Label();
            this.lblEngleska = new System.Windows.Forms.Label();
            this.tbxEngleska = new System.Windows.Forms.TextBox();
            this.tbsSvenska = new System.Windows.Forms.TextBox();
            this.btnKör = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSvar
            // 
            this.lblSvar.AutoSize = true;
            this.lblSvar.Location = new System.Drawing.Point(385, 239);
            this.lblSvar.Name = "lblSvar";
            this.lblSvar.Size = new System.Drawing.Size(51, 20);
            this.lblSvar.TabIndex = 0;
            this.lblSvar.Text = "label1";
            // 
            // lblSvenska
            // 
            this.lblSvenska.AutoSize = true;
            this.lblSvenska.Location = new System.Drawing.Point(195, 111);
            this.lblSvenska.Name = "lblSvenska";
            this.lblSvenska.Size = new System.Drawing.Size(70, 20);
            this.lblSvenska.TabIndex = 1;
            this.lblSvenska.Text = "Svenska";
            // 
            // lblEngleska
            // 
            this.lblEngleska.AutoSize = true;
            this.lblEngleska.Location = new System.Drawing.Point(195, 51);
            this.lblEngleska.Name = "lblEngleska";
            this.lblEngleska.Size = new System.Drawing.Size(75, 20);
            this.lblEngleska.TabIndex = 2;
            this.lblEngleska.Text = "Engleska";
            // 
            // tbxEngleska
            // 
            this.tbxEngleska.Location = new System.Drawing.Point(457, 51);
            this.tbxEngleska.Name = "tbxEngleska";
            this.tbxEngleska.Size = new System.Drawing.Size(100, 26);
            this.tbxEngleska.TabIndex = 3;
            // 
            // tbsSvenska
            // 
            this.tbsSvenska.Location = new System.Drawing.Point(457, 111);
            this.tbsSvenska.Name = "tbsSvenska";
            this.tbsSvenska.Size = new System.Drawing.Size(100, 26);
            this.tbsSvenska.TabIndex = 4;
            // 
            // btnKör
            // 
            this.btnKör.Location = new System.Drawing.Point(366, 317);
            this.btnKör.Name = "btnKör";
            this.btnKör.Size = new System.Drawing.Size(102, 53);
            this.btnKör.TabIndex = 5;
            this.btnKör.Text = "Kör";
            this.btnKör.UseVisualStyleBackColor = true;
            this.btnKör.Click += new System.EventHandler(this.btnKör_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKör);
            this.Controls.Add(this.tbsSvenska);
            this.Controls.Add(this.tbxEngleska);
            this.Controls.Add(this.lblEngleska);
            this.Controls.Add(this.lblSvenska);
            this.Controls.Add(this.lblSvar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSvar;
        private System.Windows.Forms.Label lblSvenska;
        private System.Windows.Forms.Label lblEngleska;
        private System.Windows.Forms.TextBox tbxEngleska;
        private System.Windows.Forms.TextBox tbsSvenska;
        private System.Windows.Forms.Button btnKör;
    }
}

