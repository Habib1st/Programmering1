namespace övnong_5._3
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
            this.lblPengar = new System.Windows.Forms.Label();
            this.lblPris = new System.Windows.Forms.Label();
            this.lblSvar = new System.Windows.Forms.Label();
            this.btnKör = new System.Windows.Forms.Button();
            this.tbxPengar = new System.Windows.Forms.TextBox();
            this.tbxPris = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblPengar
            // 
            this.lblPengar.AutoSize = true;
            this.lblPengar.Location = new System.Drawing.Point(249, 64);
            this.lblPengar.Name = "lblPengar";
            this.lblPengar.Size = new System.Drawing.Size(101, 20);
            this.lblPengar.TabIndex = 0;
            this.lblPengar.Text = "Mina pengar ";
            // 
            // lblPris
            // 
            this.lblPris.AutoSize = true;
            this.lblPris.Location = new System.Drawing.Point(249, 144);
            this.lblPris.Name = "lblPris";
            this.lblPris.Size = new System.Drawing.Size(93, 20);
            this.lblPris.TabIndex = 1;
            this.lblPris.Text = "Varans pris ";
            this.lblPris.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblSvar
            // 
            this.lblSvar.AutoSize = true;
            this.lblSvar.Location = new System.Drawing.Point(405, 234);
            this.lblSvar.Name = "lblSvar";
            this.lblSvar.Size = new System.Drawing.Size(41, 20);
            this.lblSvar.TabIndex = 2;
            this.lblSvar.Text = "Svar";
            // 
            // btnKör
            // 
            this.btnKör.Location = new System.Drawing.Point(324, 290);
            this.btnKör.Name = "btnKör";
            this.btnKör.Size = new System.Drawing.Size(120, 60);
            this.btnKör.TabIndex = 3;
            this.btnKör.Text = "Kör";
            this.btnKör.UseVisualStyleBackColor = true;
            this.btnKör.Click += new System.EventHandler(this.btnKör_Click);
            // 
            // tbxPengar
            // 
            this.tbxPengar.Location = new System.Drawing.Point(409, 64);
            this.tbxPengar.Name = "tbxPengar";
            this.tbxPengar.Size = new System.Drawing.Size(100, 26);
            this.tbxPengar.TabIndex = 4;
            // 
            // tbxPris
            // 
            this.tbxPris.Location = new System.Drawing.Point(409, 138);
            this.tbxPris.Name = "tbxPris";
            this.tbxPris.Size = new System.Drawing.Size(100, 26);
            this.tbxPris.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxPris);
            this.Controls.Add(this.tbxPengar);
            this.Controls.Add(this.btnKör);
            this.Controls.Add(this.lblSvar);
            this.Controls.Add(this.lblPris);
            this.Controls.Add(this.lblPengar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPengar;
        private System.Windows.Forms.Label lblPris;
        private System.Windows.Forms.Label lblSvar;
        private System.Windows.Forms.Button btnKör;
        private System.Windows.Forms.TextBox tbxPengar;
        private System.Windows.Forms.TextBox tbxPris;
    }
}

