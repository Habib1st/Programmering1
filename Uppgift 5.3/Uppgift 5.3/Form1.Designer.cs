namespace Uppgift_5._3
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblSvar = new System.Windows.Forms.Label();
            this.btnKör = new System.Windows.Forms.Button();
            this.tbxNam = new System.Windows.Forms.TextBox();
            this.tbxTalj = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(363, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // lblSvar
            // 
            this.lblSvar.AutoSize = true;
            this.lblSvar.Location = new System.Drawing.Point(329, 262);
            this.lblSvar.Name = "lblSvar";
            this.lblSvar.Size = new System.Drawing.Size(119, 20);
            this.lblSvar.TabIndex = 1;
            this.lblSvar.Text = "Svar i bråkform:";
            // 
            // btnKör
            // 
            this.btnKör.Location = new System.Drawing.Point(653, 12);
            this.btnKör.Name = "btnKör";
            this.btnKör.Size = new System.Drawing.Size(135, 343);
            this.btnKör.TabIndex = 2;
            this.btnKör.Text = "KÖR";
            this.btnKör.UseVisualStyleBackColor = true;
            this.btnKör.Click += new System.EventHandler(this.btnKör_Click);
            // 
            // tbxNam
            // 
            this.tbxNam.Location = new System.Drawing.Point(493, 166);
            this.tbxNam.Name = "tbxNam";
            this.tbxNam.Size = new System.Drawing.Size(100, 26);
            this.tbxNam.TabIndex = 3;
            // 
            // tbxTalj
            // 
            this.tbxTalj.Location = new System.Drawing.Point(189, 166);
            this.tbxTalj.Name = "tbxTalj";
            this.tbxTalj.Size = new System.Drawing.Size(100, 26);
            this.tbxTalj.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxTalj);
            this.Controls.Add(this.tbxNam);
            this.Controls.Add(this.btnKör);
            this.Controls.Add(this.lblSvar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSvar;
        private System.Windows.Forms.Button btnKör;
        private System.Windows.Forms.TextBox tbxNam;
        private System.Windows.Forms.TextBox tbxTalj;
    }
}

