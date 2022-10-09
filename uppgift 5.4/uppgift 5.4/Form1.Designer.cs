namespace uppgift_5._4
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
            this.button1 = new System.Windows.Forms.Button();
            this.tbxTim = new System.Windows.Forms.TextBox();
            this.tbxMin = new System.Windows.Forms.TextBox();
            this.tbxSek = new System.Windows.Forms.TextBox();
            this.lblSek = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblTim = new System.Windows.Forms.Label();
            this.lblSkriv = new System.Windows.Forms.Label();
            this.tbxSkriv = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(617, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 333);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbxTim
            // 
            this.tbxTim.Location = new System.Drawing.Point(354, 235);
            this.tbxTim.Name = "tbxTim";
            this.tbxTim.Size = new System.Drawing.Size(100, 26);
            this.tbxTim.TabIndex = 1;
            // 
            // tbxMin
            // 
            this.tbxMin.Location = new System.Drawing.Point(354, 178);
            this.tbxMin.Name = "tbxMin";
            this.tbxMin.Size = new System.Drawing.Size(100, 26);
            this.tbxMin.TabIndex = 2;
            // 
            // tbxSek
            // 
            this.tbxSek.Location = new System.Drawing.Point(354, 132);
            this.tbxSek.Name = "tbxSek";
            this.tbxSek.Size = new System.Drawing.Size(100, 26);
            this.tbxSek.TabIndex = 3;
            // 
            // lblSek
            // 
            this.lblSek.AutoSize = true;
            this.lblSek.Location = new System.Drawing.Point(207, 132);
            this.lblSek.Name = "lblSek";
            this.lblSek.Size = new System.Drawing.Size(107, 20);
            this.lblSek.TabIndex = 4;
            this.lblSek.Text = "Tid i sekunder";
            this.lblSek.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(207, 184);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(94, 20);
            this.lblMin.TabIndex = 5;
            this.lblMin.Text = "Tid i minuter";
            // 
            // lblTim
            // 
            this.lblTim.AutoSize = true;
            this.lblTim.Location = new System.Drawing.Point(207, 241);
            this.lblTim.Name = "lblTim";
            this.lblTim.Size = new System.Drawing.Size(89, 20);
            this.lblTim.TabIndex = 6;
            this.lblTim.Text = "Tid i timmar";
            // 
            // lblSkriv
            // 
            this.lblSkriv.AutoSize = true;
            this.lblSkriv.Location = new System.Drawing.Point(207, 84);
            this.lblSkriv.Name = "lblSkriv";
            this.lblSkriv.Size = new System.Drawing.Size(141, 20);
            this.lblSkriv.TabIndex = 7;
            this.lblSkriv.Text = "Skriv tid i sekunder";
            // 
            // tbxSkriv
            // 
            this.tbxSkriv.Location = new System.Drawing.Point(354, 84);
            this.tbxSkriv.Name = "tbxSkriv";
            this.tbxSkriv.Size = new System.Drawing.Size(100, 26);
            this.tbxSkriv.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxSkriv);
            this.Controls.Add(this.lblSkriv);
            this.Controls.Add(this.lblTim);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblSek);
            this.Controls.Add(this.tbxSek);
            this.Controls.Add(this.tbxMin);
            this.Controls.Add(this.tbxTim);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbxTim;
        private System.Windows.Forms.TextBox tbxMin;
        private System.Windows.Forms.TextBox tbxSek;
        private System.Windows.Forms.Label lblSek;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblTim;
        private System.Windows.Forms.Label lblSkriv;
        private System.Windows.Forms.TextBox tbxSkriv;
    }
}

