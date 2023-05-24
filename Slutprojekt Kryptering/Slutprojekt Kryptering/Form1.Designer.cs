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
            this.btnDekrypt = new System.Windows.Forms.Button();
            this.tbxKryptering = new System.Windows.Forms.TextBox();
            this.tbxDekrypt = new System.Windows.Forms.TextBox();
            this.btnRot7o13 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDekrypt
            // 
            this.btnDekrypt.Location = new System.Drawing.Point(554, 289);
            this.btnDekrypt.Name = "btnDekrypt";
            this.btnDekrypt.Size = new System.Drawing.Size(108, 43);
            this.btnDekrypt.TabIndex = 1;
            this.btnDekrypt.Text = "Dekryptera\r\n\r\n";
            this.btnDekrypt.UseVisualStyleBackColor = true;
            this.btnDekrypt.Click += new System.EventHandler(this.btnDekrypt_Click);
            // 
            // tbxKryptering
            // 
            this.tbxKryptering.Location = new System.Drawing.Point(332, 57);
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
            // btnRot7o13
            // 
            this.btnRot7o13.Location = new System.Drawing.Point(295, 289);
            this.btnRot7o13.Name = "btnRot7o13";
            this.btnRot7o13.Size = new System.Drawing.Size(164, 59);
            this.btnRot7o13.TabIndex = 4;
            this.btnRot7o13.Text = "Skicka med rot 7 och 13";
            this.btnRot7o13.UseVisualStyleBackColor = true;
            this.btnRot7o13.Click += new System.EventHandler(this.rot7o13_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRot7o13);
            this.Controls.Add(this.tbxDekrypt);
            this.Controls.Add(this.tbxKryptering);
            this.Controls.Add(this.btnDekrypt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDekrypt;
        private System.Windows.Forms.TextBox tbxKryptering;
        private System.Windows.Forms.TextBox tbxDekrypt;
        private System.Windows.Forms.Button btnRot7o13;
    }
}

