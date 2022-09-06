namespace Övningar
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
            this.lblTal1 = new System.Windows.Forms.Label();
            this.lblTal2 = new System.Windows.Forms.Label();
            this.tbxTal2 = new System.Windows.Forms.TextBox();
            this.tbxTal1 = new System.Windows.Forms.TextBox();
            this.lblsumma = new System.Windows.Forms.Label();
            this.btnKör = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTal1
            // 
            this.lblTal1.AutoSize = true;
            this.lblTal1.Location = new System.Drawing.Point(173, 80);
            this.lblTal1.Name = "lblTal1";
            this.lblTal1.Size = new System.Drawing.Size(43, 20);
            this.lblTal1.TabIndex = 0;
            this.lblTal1.Text = "Tal 1";
            // 
            // lblTal2
            // 
            this.lblTal2.AutoSize = true;
            this.lblTal2.Location = new System.Drawing.Point(173, 136);
            this.lblTal2.Name = "lblTal2";
            this.lblTal2.Size = new System.Drawing.Size(43, 20);
            this.lblTal2.TabIndex = 1;
            this.lblTal2.Text = "Tal 2";
            // 
            // tbxTal2
            // 
            this.tbxTal2.Location = new System.Drawing.Point(353, 130);
            this.tbxTal2.Name = "tbxTal2";
            this.tbxTal2.Size = new System.Drawing.Size(100, 26);
            this.tbxTal2.TabIndex = 2;
            // 
            // tbxTal1
            // 
            this.tbxTal1.Location = new System.Drawing.Point(353, 74);
            this.tbxTal1.Name = "tbxTal1";
            this.tbxTal1.Size = new System.Drawing.Size(100, 26);
            this.tbxTal1.TabIndex = 3;
            // 
            // lblsumma
            // 
            this.lblsumma.AutoSize = true;
            this.lblsumma.Location = new System.Drawing.Point(173, 226);
            this.lblsumma.Name = "lblsumma";
            this.lblsumma.Size = new System.Drawing.Size(51, 20);
            this.lblsumma.TabIndex = 4;
            this.lblsumma.Text = "label1";
            // 
            // btnKör
            // 
            this.btnKör.Location = new System.Drawing.Point(234, 281);
            this.btnKör.Name = "btnKör";
            this.btnKör.Size = new System.Drawing.Size(165, 39);
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
            this.Controls.Add(this.lblsumma);
            this.Controls.Add(this.tbxTal1);
            this.Controls.Add(this.tbxTal2);
            this.Controls.Add(this.lblTal2);
            this.Controls.Add(this.lblTal1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTal1;
        private System.Windows.Forms.Label lblTal2;
        private System.Windows.Forms.TextBox tbxTal2;
        private System.Windows.Forms.TextBox tbxTal1;
        private System.Windows.Forms.Label lblsumma;
        private System.Windows.Forms.Button btnKör;
    }
}

