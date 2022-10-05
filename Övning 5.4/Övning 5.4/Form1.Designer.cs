namespace Övning_5._4
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
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.lblSvar = new System.Windows.Forms.Label();
            this.btnKör = new System.Windows.Forms.Button();
            this.tbxC = new System.Windows.Forms.TextBox();
            this.tbxB = new System.Windows.Forms.TextBox();
            this.tbxA = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(212, 54);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(45, 20);
            this.lblA.TabIndex = 0;
            this.lblA.Text = "Tal A";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(212, 86);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(45, 20);
            this.lblB.TabIndex = 1;
            this.lblB.Text = "Tal B";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(212, 118);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(45, 20);
            this.lblC.TabIndex = 2;
            this.lblC.Text = "Tal C";
            // 
            // lblSvar
            // 
            this.lblSvar.AutoSize = true;
            this.lblSvar.Location = new System.Drawing.Point(329, 230);
            this.lblSvar.Name = "lblSvar";
            this.lblSvar.Size = new System.Drawing.Size(41, 20);
            this.lblSvar.TabIndex = 3;
            this.lblSvar.Text = "Svar";
            // 
            // btnKör
            // 
            this.btnKör.Location = new System.Drawing.Point(632, 8);
            this.btnKör.Name = "btnKör";
            this.btnKör.Size = new System.Drawing.Size(156, 369);
            this.btnKör.TabIndex = 4;
            this.btnKör.Text = "Kör";
            this.btnKör.UseVisualStyleBackColor = true;
            this.btnKör.Click += new System.EventHandler(this.btnKör_Click);
            // 
            // tbxC
            // 
            this.tbxC.Location = new System.Drawing.Point(386, 112);
            this.tbxC.Name = "tbxC";
            this.tbxC.Size = new System.Drawing.Size(100, 26);
            this.tbxC.TabIndex = 5;
            // 
            // tbxB
            // 
            this.tbxB.Location = new System.Drawing.Point(386, 80);
            this.tbxB.Name = "tbxB";
            this.tbxB.Size = new System.Drawing.Size(100, 26);
            this.tbxB.TabIndex = 6;
            // 
            // tbxA
            // 
            this.tbxA.Location = new System.Drawing.Point(386, 48);
            this.tbxA.Name = "tbxA";
            this.tbxA.Size = new System.Drawing.Size(100, 26);
            this.tbxA.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxA);
            this.Controls.Add(this.tbxB);
            this.Controls.Add(this.tbxC);
            this.Controls.Add(this.btnKör);
            this.Controls.Add(this.lblSvar);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblSvar;
        private System.Windows.Forms.Button btnKör;
        private System.Windows.Forms.TextBox tbxC;
        private System.Windows.Forms.TextBox tbxB;
        private System.Windows.Forms.TextBox tbxA;
    }
}

