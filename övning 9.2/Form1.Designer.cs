namespace övning_9._2
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
            this.btnVisa = new System.Windows.Forms.Button();
            this.tbxKorn = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnVisa
            // 
            this.btnVisa.Location = new System.Drawing.Point(368, 56);
            this.btnVisa.Name = "btnVisa";
            this.btnVisa.Size = new System.Drawing.Size(105, 41);
            this.btnVisa.TabIndex = 0;
            this.btnVisa.Text = "Visa";
            this.btnVisa.UseVisualStyleBackColor = true;
            this.btnVisa.Click += new System.EventHandler(this.btnVisa_Click);
            // 
            // tbxKorn
            // 
            this.tbxKorn.Location = new System.Drawing.Point(71, 103);
            this.tbxKorn.Multiline = true;
            this.tbxKorn.Name = "tbxKorn";
            this.tbxKorn.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxKorn.Size = new System.Drawing.Size(663, 258);
            this.tbxKorn.TabIndex = 1;
            this.tbxKorn.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxKorn);
            this.Controls.Add(this.btnVisa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVisa;
        private System.Windows.Forms.TextBox tbxKorn;
    }
}

