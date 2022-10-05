namespace Exemplet_5._1
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
            this.btnKör = new System.Windows.Forms.Button();
            this.lblSvar = new System.Windows.Forms.Label();
            this.lblTid = new System.Windows.Forms.Label();
            this.tbxSvar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnKör
            // 
            this.btnKör.Location = new System.Drawing.Point(397, 298);
            this.btnKör.Name = "btnKör";
            this.btnKör.Size = new System.Drawing.Size(103, 49);
            this.btnKör.TabIndex = 0;
            this.btnKör.Text = "Kör";
            this.btnKör.UseVisualStyleBackColor = true;
            this.btnKör.Click += new System.EventHandler(this.btnKör_Click);
            // 
            // lblSvar
            // 
            this.lblSvar.AutoSize = true;
            this.lblSvar.Location = new System.Drawing.Point(421, 194);
            this.lblSvar.Name = "lblSvar";
            this.lblSvar.Size = new System.Drawing.Size(41, 20);
            this.lblSvar.TabIndex = 1;
            this.lblSvar.Text = "Svar";
            // 
            // lblTid
            // 
            this.lblTid.AutoSize = true;
            this.lblTid.Location = new System.Drawing.Point(263, 75);
            this.lblTid.Name = "lblTid";
            this.lblTid.Size = new System.Drawing.Size(94, 20);
            this.lblTid.TabIndex = 2;
            this.lblTid.Text = "Tid i minuter";
            // 
            // tbxSvar
            // 
            this.tbxSvar.Location = new System.Drawing.Point(425, 75);
            this.tbxSvar.Name = "tbxSvar";
            this.tbxSvar.Size = new System.Drawing.Size(100, 26);
            this.tbxSvar.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxSvar);
            this.Controls.Add(this.lblTid);
            this.Controls.Add(this.lblSvar);
            this.Controls.Add(this.btnKör);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKör;
        private System.Windows.Forms.Label lblSvar;
        private System.Windows.Forms.Label lblTid;
        private System.Windows.Forms.TextBox tbxSvar;
    }
}

