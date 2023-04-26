namespace Slutprojekt_Kryptering
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
            this.btnSkicka = new System.Windows.Forms.Button();
            this.btnDekrypt = new System.Windows.Forms.Button();
            this.tbxKryptering = new System.Windows.Forms.TextBox();
            this.tbxDekrypt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSkicka
            // 
            this.btnSkicka.Location = new System.Drawing.Point(200, 289);
            this.btnSkicka.Name = "btnSkicka";
            this.btnSkicka.Size = new System.Drawing.Size(100, 43);
            this.btnSkicka.TabIndex = 0;
            this.btnSkicka.Text = "Skicka";
            this.btnSkicka.UseVisualStyleBackColor = true;
            this.btnSkicka.Click += new System.EventHandler(this.btnSkicka_Click);
            // 
            // btnDekrypt
            // 
            this.btnDekrypt.Location = new System.Drawing.Point(554, 289);
            this.btnDekrypt.Name = "btnDekrypt";
            this.btnDekrypt.Size = new System.Drawing.Size(108, 43);
            this.btnDekrypt.TabIndex = 1;
            this.btnDekrypt.Text = "Dekryptera\r\n\r\n";
            this.btnDekrypt.UseVisualStyleBackColor = true;
            // 
            // tbxKryptering
            // 
            this.tbxKryptering.Location = new System.Drawing.Point(200, 57);
            this.tbxKryptering.Multiline = true;
            this.tbxKryptering.Name = "tbxKryptering";
            this.tbxKryptering.Size = new System.Drawing.Size(100, 226);
            this.tbxKryptering.TabIndex = 2;
            // 
            // tbxDekrypt
            // 
            this.tbxDekrypt.Location = new System.Drawing.Point(554, 57);
            this.tbxDekrypt.Multiline = true;
            this.tbxDekrypt.Name = "tbxDekrypt";
            this.tbxDekrypt.Size = new System.Drawing.Size(108, 226);
            this.tbxDekrypt.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxDekrypt);
            this.Controls.Add(this.tbxKryptering);
            this.Controls.Add(this.btnDekrypt);
            this.Controls.Add(this.btnSkicka);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSkicka;
        private System.Windows.Forms.Button btnDekrypt;
        private System.Windows.Forms.TextBox tbxKryptering;
        private System.Windows.Forms.TextBox tbxDekrypt;
    }
}

