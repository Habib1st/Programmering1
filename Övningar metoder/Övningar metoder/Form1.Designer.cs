namespace Övningar_metoder
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblRes = new System.Windows.Forms.Label();
            this.tbxT1 = new System.Windows.Forms.TextBox();
            this.tbxT2 = new System.Windows.Forms.TextBox();
            this.btnAd = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btn_Sub = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tal 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(463, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tal 2";
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Location = new System.Drawing.Point(258, 183);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(69, 20);
            this.lblRes.TabIndex = 2;
            this.lblRes.Text = "Resultat";
            // 
            // tbxT1
            // 
            this.tbxT1.Location = new System.Drawing.Point(262, 38);
            this.tbxT1.Name = "tbxT1";
            this.tbxT1.Size = new System.Drawing.Size(100, 26);
            this.tbxT1.TabIndex = 3;
            // 
            // tbxT2
            // 
            this.tbxT2.Location = new System.Drawing.Point(467, 38);
            this.tbxT2.Name = "tbxT2";
            this.tbxT2.Size = new System.Drawing.Size(100, 26);
            this.tbxT2.TabIndex = 4;
            this.tbxT2.TextChanged += new System.EventHandler(this.tbxT2_TextChanged);
            // 
            // btnAd
            // 
            this.btnAd.Location = new System.Drawing.Point(218, 255);
            this.btnAd.Name = "btnAd";
            this.btnAd.Size = new System.Drawing.Size(83, 38);
            this.btnAd.TabIndex = 5;
            this.btnAd.Text = "Addition";
            this.btnAd.UseVisualStyleBackColor = true;
            this.btnAd.Click += new System.EventHandler(this.btnAd_Click);
            // 
            // btnMulti
            // 
            this.btnMulti.Location = new System.Drawing.Point(467, 260);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(122, 38);
            this.btnMulti.TabIndex = 6;
            this.btnMulti.Text = "Multiplikation";
            this.btnMulti.UseVisualStyleBackColor = true;
            this.btnMulti.Click += new System.EventHandler(this.btnMulti_Click);
            // 
            // btn_Sub
            // 
            this.btn_Sub.Location = new System.Drawing.Point(349, 260);
            this.btn_Sub.Name = "btn_Sub";
            this.btn_Sub.Size = new System.Drawing.Size(90, 33);
            this.btn_Sub.TabIndex = 7;
            this.btn_Sub.Text = "Sub";
            this.btn_Sub.UseVisualStyleBackColor = true;
            this.btn_Sub.Click += new System.EventHandler(this.btn_Sub_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Sub);
            this.Controls.Add(this.btnMulti);
            this.Controls.Add(this.btnAd);
            this.Controls.Add(this.tbxT2);
            this.Controls.Add(this.tbxT1);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.TextBox tbxT1;
        private System.Windows.Forms.TextBox tbxT2;
        private System.Windows.Forms.Button btnAd;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btn_Sub;
    }
}

