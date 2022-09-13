namespace Uppgift_3._4_a_och_b
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
            this.lblBelopp = new System.Windows.Forms.Label();
            this.tbxBelopp = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblUttag = new System.Windows.Forms.Label();
            this.lblHundra = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBelopp
            // 
            this.lblBelopp.AutoSize = true;
            this.lblBelopp.Location = new System.Drawing.Point(191, 71);
            this.lblBelopp.Name = "lblBelopp";
            this.lblBelopp.Size = new System.Drawing.Size(109, 20);
            this.lblBelopp.TabIndex = 0;
            this.lblBelopp.Text = "Skriv beloppet";
            this.lblBelopp.Click += new System.EventHandler(this.lblBelopp_Click);
            // 
            // tbxBelopp
            // 
            this.tbxBelopp.Location = new System.Drawing.Point(400, 71);
            this.tbxBelopp.Name = "tbxBelopp";
            this.tbxBelopp.Size = new System.Drawing.Size(100, 26);
            this.tbxBelopp.TabIndex = 1;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(557, 71);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(84, 36);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblUttag
            // 
            this.lblUttag.AutoSize = true;
            this.lblUttag.Location = new System.Drawing.Point(310, 182);
            this.lblUttag.Name = "lblUttag";
            this.lblUttag.Size = new System.Drawing.Size(139, 20);
            this.lblUttag.TabIndex = 3;
            this.lblUttag.Text = "Uttag i 500-sedlar:";
            // 
            // lblHundra
            // 
            this.lblHundra.AutoSize = true;
            this.lblHundra.Location = new System.Drawing.Point(310, 236);
            this.lblHundra.Name = "lblHundra";
            this.lblHundra.Size = new System.Drawing.Size(135, 20);
            this.lblHundra.TabIndex = 4;
            this.lblHundra.Text = "Uttag i 100-sedlar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblHundra);
            this.Controls.Add(this.lblUttag);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tbxBelopp);
            this.Controls.Add(this.lblBelopp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBelopp;
        private System.Windows.Forms.TextBox tbxBelopp;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblUttag;
        private System.Windows.Forms.Label lblHundra;
    }
}

