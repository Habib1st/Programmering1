namespace Övning_3._6_tecken
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
            this.lblFörnamn = new System.Windows.Forms.Label();
            this.lblEfternamn = new System.Windows.Forms.Label();
            this.lblSvar = new System.Windows.Forms.Label();
            this.tbxxFörnamn = new System.Windows.Forms.TextBox();
            this.tbxEfternamn = new System.Windows.Forms.TextBox();
            this.btnKör = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFörnamn
            // 
            this.lblFörnamn.AutoSize = true;
            this.lblFörnamn.Location = new System.Drawing.Point(176, 51);
            this.lblFörnamn.Name = "lblFörnamn";
            this.lblFörnamn.Size = new System.Drawing.Size(73, 20);
            this.lblFörnamn.TabIndex = 0;
            this.lblFörnamn.Text = "Förnamn";
            // 
            // lblEfternamn
            // 
            this.lblEfternamn.AutoSize = true;
            this.lblEfternamn.Location = new System.Drawing.Point(176, 141);
            this.lblEfternamn.Name = "lblEfternamn";
            this.lblEfternamn.Size = new System.Drawing.Size(84, 20);
            this.lblEfternamn.TabIndex = 1;
            this.lblEfternamn.Text = "Efternamn";
            // 
            // lblSvar
            // 
            this.lblSvar.AutoSize = true;
            this.lblSvar.Location = new System.Drawing.Point(364, 229);
            this.lblSvar.Name = "lblSvar";
            this.lblSvar.Size = new System.Drawing.Size(41, 20);
            this.lblSvar.TabIndex = 2;
            this.lblSvar.Text = "Svar";
            // 
            // tbxxFörnamn
            // 
            this.tbxxFörnamn.Location = new System.Drawing.Point(368, 51);
            this.tbxxFörnamn.Name = "tbxxFörnamn";
            this.tbxxFörnamn.Size = new System.Drawing.Size(100, 26);
            this.tbxxFörnamn.TabIndex = 3;
            // 
            // tbxEfternamn
            // 
            this.tbxEfternamn.Location = new System.Drawing.Point(368, 141);
            this.tbxEfternamn.Name = "tbxEfternamn";
            this.tbxEfternamn.Size = new System.Drawing.Size(100, 26);
            this.tbxEfternamn.TabIndex = 4;
            // 
            // btnKör
            // 
            this.btnKör.Location = new System.Drawing.Point(352, 296);
            this.btnKör.Name = "btnKör";
            this.btnKör.Size = new System.Drawing.Size(116, 57);
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
            this.Controls.Add(this.tbxEfternamn);
            this.Controls.Add(this.tbxxFörnamn);
            this.Controls.Add(this.lblSvar);
            this.Controls.Add(this.lblEfternamn);
            this.Controls.Add(this.lblFörnamn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFörnamn;
        private System.Windows.Forms.Label lblEfternamn;
        private System.Windows.Forms.Label lblSvar;
        private System.Windows.Forms.TextBox tbxxFörnamn;
        private System.Windows.Forms.TextBox tbxEfternamn;
        private System.Windows.Forms.Button btnKör;
    }
}

