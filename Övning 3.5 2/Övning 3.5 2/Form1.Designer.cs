﻿namespace Övning_3._5_2
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
            this.lblNamn = new System.Windows.Forms.Label();
            this.lblFödd = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.tbxNamn = new System.Windows.Forms.TextBox();
            this.tbxFödd = new System.Windows.Forms.TextBox();
            this.btnKör = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNamn
            // 
            this.lblNamn.AutoSize = true;
            this.lblNamn.Location = new System.Drawing.Point(202, 88);
            this.lblNamn.Name = "lblNamn";
            this.lblNamn.Size = new System.Drawing.Size(51, 20);
            this.lblNamn.TabIndex = 0;
            this.lblNamn.Text = "Namn";
            // 
            // lblFödd
            // 
            this.lblFödd.AutoSize = true;
            this.lblFödd.Location = new System.Drawing.Point(202, 183);
            this.lblFödd.Name = "lblFödd";
            this.lblFödd.Size = new System.Drawing.Size(80, 20);
            this.lblFödd.TabIndex = 1;
            this.lblFödd.Text = "Födelseår";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(368, 260);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(41, 20);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Text = "Svar";
            // 
            // tbxNamn
            // 
            this.tbxNamn.Location = new System.Drawing.Point(407, 88);
            this.tbxNamn.Name = "tbxNamn";
            this.tbxNamn.Size = new System.Drawing.Size(100, 26);
            this.tbxNamn.TabIndex = 3;
            // 
            // tbxFödd
            // 
            this.tbxFödd.Location = new System.Drawing.Point(407, 183);
            this.tbxFödd.Name = "tbxFödd";
            this.tbxFödd.Size = new System.Drawing.Size(100, 26);
            this.tbxFödd.TabIndex = 4;
            // 
            // btnKör
            // 
            this.btnKör.Location = new System.Drawing.Point(347, 325);
            this.btnKör.Name = "btnKör";
            this.btnKör.Size = new System.Drawing.Size(111, 54);
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
            this.Controls.Add(this.tbxFödd);
            this.Controls.Add(this.tbxNamn);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblFödd);
            this.Controls.Add(this.lblNamn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNamn;
        private System.Windows.Forms.Label lblFödd;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TextBox tbxNamn;
        private System.Windows.Forms.TextBox tbxFödd;
        private System.Windows.Forms.Button btnKör;
    }
}

