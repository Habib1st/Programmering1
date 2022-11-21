namespace övningar_9
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
            this.tbxSlutvärde = new System.Windows.Forms.TextBox();
            this.lblSlutvärde = new System.Windows.Forms.Label();
            this.tbxUtdata = new System.Windows.Forms.TextBox();
            this.btnStarta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxSlutvärde
            // 
            this.tbxSlutvärde.Location = new System.Drawing.Point(637, 50);
            this.tbxSlutvärde.Name = "tbxSlutvärde";
            this.tbxSlutvärde.Size = new System.Drawing.Size(100, 26);
            this.tbxSlutvärde.TabIndex = 7;
            // 
            // lblSlutvärde
            // 
            this.lblSlutvärde.AutoSize = true;
            this.lblSlutvärde.Location = new System.Drawing.Point(508, 50);
            this.lblSlutvärde.Name = "lblSlutvärde";
            this.lblSlutvärde.Size = new System.Drawing.Size(76, 20);
            this.lblSlutvärde.TabIndex = 6;
            this.lblSlutvärde.Text = "Slutvärde";
            // 
            // tbxUtdata
            // 
            this.tbxUtdata.Location = new System.Drawing.Point(63, 97);
            this.tbxUtdata.Multiline = true;
            this.tbxUtdata.Name = "tbxUtdata";
            this.tbxUtdata.Size = new System.Drawing.Size(674, 237);
            this.tbxUtdata.TabIndex = 5;
            // 
            // btnStarta
            // 
            this.btnStarta.Location = new System.Drawing.Point(372, 367);
            this.btnStarta.Name = "btnStarta";
            this.btnStarta.Size = new System.Drawing.Size(83, 33);
            this.btnStarta.TabIndex = 4;
            this.btnStarta.Text = "Starta";
            this.btnStarta.UseVisualStyleBackColor = true;
            this.btnStarta.Click += new System.EventHandler(this.btnStarta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxSlutvärde);
            this.Controls.Add(this.lblSlutvärde);
            this.Controls.Add(this.tbxUtdata);
            this.Controls.Add(this.btnStarta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxSlutvärde;
        private System.Windows.Forms.Label lblSlutvärde;
        private System.Windows.Forms.TextBox tbxUtdata;
        private System.Windows.Forms.Button btnStarta;
    }
}

