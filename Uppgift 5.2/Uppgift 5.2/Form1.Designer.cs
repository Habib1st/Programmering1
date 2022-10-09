namespace Uppgift_5._2
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblSkriv = new System.Windows.Forms.Label();
            this.tbxSkriv = new System.Windows.Forms.TextBox();
            this.lblSvar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(530, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(258, 290);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSkriv
            // 
            this.lblSkriv.AutoSize = true;
            this.lblSkriv.Location = new System.Drawing.Point(295, 102);
            this.lblSkriv.Name = "lblSkriv";
            this.lblSkriv.Size = new System.Drawing.Size(87, 20);
            this.lblSkriv.TabIndex = 1;
            this.lblSkriv.Text = "Skriv ett tal";
            // 
            // tbxSkriv
            // 
            this.tbxSkriv.Location = new System.Drawing.Point(402, 102);
            this.tbxSkriv.Name = "tbxSkriv";
            this.tbxSkriv.Size = new System.Drawing.Size(100, 26);
            this.tbxSkriv.TabIndex = 2;
            // 
            // lblSvar
            // 
            this.lblSvar.AutoSize = true;
            this.lblSvar.Location = new System.Drawing.Point(329, 163);
            this.lblSvar.Name = "lblSvar";
            this.lblSvar.Size = new System.Drawing.Size(152, 20);
            this.lblSvar.TabIndex = 3;
            this.lblSvar.Text = "Avrundat till tusental";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSvar);
            this.Controls.Add(this.tbxSkriv);
            this.Controls.Add(this.lblSkriv);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblSkriv;
        private System.Windows.Forms.TextBox tbxSkriv;
        private System.Windows.Forms.Label lblSvar;
    }
}

