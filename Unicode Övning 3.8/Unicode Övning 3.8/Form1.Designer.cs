﻿namespace Unicode_Övning_3._8
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
            this.lblVersal = new System.Windows.Forms.Label();
            this.lblSvar = new System.Windows.Forms.Label();
            this.btnKör = new System.Windows.Forms.Button();
            this.tbxVersal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblVersal
            // 
            this.lblVersal.AutoSize = true;
            this.lblVersal.Location = new System.Drawing.Point(205, 62);
            this.lblVersal.Name = "lblVersal";
            this.lblVersal.Size = new System.Drawing.Size(98, 20);
            this.lblVersal.TabIndex = 0;
            this.lblVersal.Text = "Stor bokstav";
            // 
            // lblSvar
            // 
            this.lblSvar.AutoSize = true;
            this.lblSvar.Location = new System.Drawing.Point(392, 232);
            this.lblSvar.Name = "lblSvar";
            this.lblSvar.Size = new System.Drawing.Size(41, 20);
            this.lblSvar.TabIndex = 1;
            this.lblSvar.Text = "Svar";
            // 
            // btnKör
            // 
            this.btnKör.Location = new System.Drawing.Point(368, 302);
            this.btnKör.Name = "btnKör";
            this.btnKör.Size = new System.Drawing.Size(118, 57);
            this.btnKör.TabIndex = 2;
            this.btnKör.Text = "Kör";
            this.btnKör.UseVisualStyleBackColor = true;
            this.btnKör.Click += new System.EventHandler(this.btnKör_Click);
            // 
            // tbxVersal
            // 
            this.tbxVersal.Location = new System.Drawing.Point(386, 62);
            this.tbxVersal.Name = "tbxVersal";
            this.tbxVersal.Size = new System.Drawing.Size(100, 26);
            this.tbxVersal.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxVersal);
            this.Controls.Add(this.btnKör);
            this.Controls.Add(this.lblSvar);
            this.Controls.Add(this.lblVersal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVersal;
        private System.Windows.Forms.Label lblSvar;
        private System.Windows.Forms.Button btnKör;
        private System.Windows.Forms.TextBox tbxVersal;
    }
}

