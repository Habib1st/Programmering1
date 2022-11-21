namespace Övning_9._9
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
            this.tbxTe1 = new System.Windows.Forms.TextBox();
            this.tbxTe2 = new System.Windows.Forms.TextBox();
            this.tbxTe3 = new System.Windows.Forms.TextBox();
            this.btnFör = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(353, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sträng";
            // 
            // tbxTe1
            // 
            this.tbxTe1.Location = new System.Drawing.Point(329, 113);
            this.tbxTe1.Name = "tbxTe1";
            this.tbxTe1.Size = new System.Drawing.Size(100, 26);
            this.tbxTe1.TabIndex = 1;
            // 
            // tbxTe2
            // 
            this.tbxTe2.Location = new System.Drawing.Point(329, 165);
            this.tbxTe2.Name = "tbxTe2";
            this.tbxTe2.Size = new System.Drawing.Size(100, 26);
            this.tbxTe2.TabIndex = 2;
            // 
            // tbxTe3
            // 
            this.tbxTe3.Location = new System.Drawing.Point(329, 212);
            this.tbxTe3.Name = "tbxTe3";
            this.tbxTe3.Size = new System.Drawing.Size(100, 26);
            this.tbxTe3.TabIndex = 3;
            // 
            // btnFör
            // 
            this.btnFör.Location = new System.Drawing.Point(346, 277);
            this.btnFör.Name = "btnFör";
            this.btnFör.Size = new System.Drawing.Size(83, 44);
            this.btnFör.TabIndex = 4;
            this.btnFör.Text = "Förskjut";
            this.btnFör.UseVisualStyleBackColor = true;
            this.btnFör.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFör);
            this.Controls.Add(this.tbxTe3);
            this.Controls.Add(this.tbxTe2);
            this.Controls.Add(this.tbxTe1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxTe1;
        private System.Windows.Forms.TextBox tbxTe2;
        private System.Windows.Forms.TextBox tbxTe3;
        private System.Windows.Forms.Button btnFör;
    }
}

