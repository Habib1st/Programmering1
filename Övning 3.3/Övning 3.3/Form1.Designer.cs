namespace Övning_3._3
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
            this.lblC = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxC = new System.Windows.Forms.TextBox();
            this.tbxB = new System.Windows.Forms.TextBox();
            this.tbxA = new System.Windows.Forms.TextBox();
            this.lblMedel = new System.Windows.Forms.Label();
            this.lblSumma = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(69, 23);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(45, 20);
            this.lblA.TabIndex = 0;
            this.lblA.Text = "Tal A";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(69, 116);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(45, 20);
            this.lblC.TabIndex = 1;
            this.lblC.Text = "Tal C";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(69, 69);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(45, 20);
            this.lblB.TabIndex = 2;
            this.lblB.Text = "Tal B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 3;
            // 
            // tbxC
            // 
            this.tbxC.Location = new System.Drawing.Point(365, 116);
            this.tbxC.Name = "tbxC";
            this.tbxC.Size = new System.Drawing.Size(100, 26);
            this.tbxC.TabIndex = 4;
            // 
            // tbxB
            // 
            this.tbxB.Location = new System.Drawing.Point(365, 69);
            this.tbxB.Name = "tbxB";
            this.tbxB.Size = new System.Drawing.Size(100, 26);
            this.tbxB.TabIndex = 5;
            // 
            // tbxA
            // 
            this.tbxA.Location = new System.Drawing.Point(365, 23);
            this.tbxA.Name = "tbxA";
            this.tbxA.Size = new System.Drawing.Size(100, 26);
            this.tbxA.TabIndex = 6;
            // 
            // lblMedel
            // 
            this.lblMedel.AutoSize = true;
            this.lblMedel.Location = new System.Drawing.Point(361, 237);
            this.lblMedel.Name = "lblMedel";
            this.lblMedel.Size = new System.Drawing.Size(95, 20);
            this.lblMedel.TabIndex = 7;
            this.lblMedel.Text = "Medelvärde:";
            // 
            // lblSumma
            // 
            this.lblSumma.AutoSize = true;
            this.lblSumma.Location = new System.Drawing.Point(361, 188);
            this.lblSumma.Name = "lblSumma";
            this.lblSumma.Size = new System.Drawing.Size(68, 20);
            this.lblSumma.TabIndex = 8;
            this.lblSumma.Text = "Summa:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(365, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 54);
            this.button1.TabIndex = 9;
            this.button1.Text = "Kör";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblSumma);
            this.Controls.Add(this.lblMedel);
            this.Controls.Add(this.tbxA);
            this.Controls.Add(this.tbxB);
            this.Controls.Add(this.tbxC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxC;
        private System.Windows.Forms.TextBox tbxB;
        private System.Windows.Forms.TextBox tbxA;
        private System.Windows.Forms.Label lblMedel;
        private System.Windows.Forms.Label lblSumma;
        private System.Windows.Forms.Button button1;
    }
}

