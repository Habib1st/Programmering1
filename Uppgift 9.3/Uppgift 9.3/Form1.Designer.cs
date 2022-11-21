namespace Uppgift_9._3
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
            this.btnRäkna = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxSlut = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRäkna
            // 
            this.btnRäkna.Location = new System.Drawing.Point(345, 224);
            this.btnRäkna.Name = "btnRäkna";
            this.btnRäkna.Size = new System.Drawing.Size(104, 54);
            this.btnRäkna.TabIndex = 0;
            this.btnRäkna.Text = "Räkna";
            this.btnRäkna.UseVisualStyleBackColor = true;
            this.btnRäkna.Click += new System.EventHandler(this.btnRäkna_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(474, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hur många gånger behöver man vika ett papper så det når månen";
            // 
            // tbxSlut
            // 
            this.tbxSlut.Location = new System.Drawing.Point(69, 158);
            this.tbxSlut.Name = "tbxSlut";
            this.tbxSlut.Size = new System.Drawing.Size(673, 26);
            this.tbxSlut.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxSlut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRäkna);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRäkna;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxSlut;
    }
}

