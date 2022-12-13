namespace Mini_projekt_Yatzy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnKasta = new System.Windows.Forms.Button();
            this.dice4 = new System.Windows.Forms.PictureBox();
            this.dice5 = new System.Windows.Forms.PictureBox();
            this.dice3 = new System.Windows.Forms.PictureBox();
            this.dice2 = new System.Windows.Forms.PictureBox();
            this.dice1 = new System.Windows.Forms.PictureBox();
            this.tbxRe = new System.Windows.Forms.TextBox();
            this.lblResultat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dice4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKasta
            // 
            this.btnKasta.Location = new System.Drawing.Point(272, 274);
            this.btnKasta.Name = "btnKasta";
            this.btnKasta.Size = new System.Drawing.Size(330, 93);
            this.btnKasta.TabIndex = 6;
            this.btnKasta.Text = "Kasta";
            this.btnKasta.UseVisualStyleBackColor = true;
            this.btnKasta.Click += new System.EventHandler(this.btnKasta_Click);
            // 
            // dice4
            // 
            this.dice4.Image = ((System.Drawing.Image)(resources.GetObject("dice4.Image")));
            this.dice4.Location = new System.Drawing.Point(579, 45);
            this.dice4.Name = "dice4";
            this.dice4.Size = new System.Drawing.Size(50, 50);
            this.dice4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dice4.TabIndex = 5;
            this.dice4.TabStop = false;
            this.dice4.Click += new System.EventHandler(this.dice4_Click);
            // 
            // dice5
            // 
            this.dice5.Image = ((System.Drawing.Image)(resources.GetObject("dice5.Image")));
            this.dice5.Location = new System.Drawing.Point(756, 45);
            this.dice5.Name = "dice5";
            this.dice5.Size = new System.Drawing.Size(50, 50);
            this.dice5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dice5.TabIndex = 4;
            this.dice5.TabStop = false;
            this.dice5.Click += new System.EventHandler(this.dice5_Click);
            // 
            // dice3
            // 
            this.dice3.Image = ((System.Drawing.Image)(resources.GetObject("dice3.Image")));
            this.dice3.Location = new System.Drawing.Point(392, 45);
            this.dice3.Name = "dice3";
            this.dice3.Size = new System.Drawing.Size(50, 50);
            this.dice3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dice3.TabIndex = 3;
            this.dice3.TabStop = false;
            this.dice3.Click += new System.EventHandler(this.dice3_Click);
            // 
            // dice2
            // 
            this.dice2.Image = ((System.Drawing.Image)(resources.GetObject("dice2.Image")));
            this.dice2.Location = new System.Drawing.Point(192, 45);
            this.dice2.Name = "dice2";
            this.dice2.Size = new System.Drawing.Size(50, 50);
            this.dice2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dice2.TabIndex = 2;
            this.dice2.TabStop = false;
            this.dice2.Click += new System.EventHandler(this.dice2_Click);
            // 
            // dice1
            // 
            this.dice1.Image = ((System.Drawing.Image)(resources.GetObject("dice1.Image")));
            this.dice1.Location = new System.Drawing.Point(12, 45);
            this.dice1.Name = "dice1";
            this.dice1.Size = new System.Drawing.Size(50, 50);
            this.dice1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dice1.TabIndex = 0;
            this.dice1.TabStop = false;
            this.dice1.Click += new System.EventHandler(this.dice1_Click);
            // 
            // tbxRe
            // 
            this.tbxRe.Location = new System.Drawing.Point(142, 172);
            this.tbxRe.Name = "tbxRe";
            this.tbxRe.Size = new System.Drawing.Size(664, 26);
            this.tbxRe.TabIndex = 7;
            // 
            // lblResultat
            // 
            this.lblResultat.AutoSize = true;
            this.lblResultat.Location = new System.Drawing.Point(55, 175);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(69, 20);
            this.lblResultat.TabIndex = 8;
            this.lblResultat.Text = "Resultat";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 450);
            this.Controls.Add(this.lblResultat);
            this.Controls.Add(this.tbxRe);
            this.Controls.Add(this.btnKasta);
            this.Controls.Add(this.dice4);
            this.Controls.Add(this.dice5);
            this.Controls.Add(this.dice3);
            this.Controls.Add(this.dice2);
            this.Controls.Add(this.dice1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dice4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox dice1;
        private System.Windows.Forms.PictureBox dice2;
        private System.Windows.Forms.PictureBox dice3;
        private System.Windows.Forms.PictureBox dice5;
        private System.Windows.Forms.PictureBox dice4;
        private System.Windows.Forms.Button btnKasta;
        private System.Windows.Forms.TextBox tbxRe;
        private System.Windows.Forms.Label lblResultat;
    }
}

