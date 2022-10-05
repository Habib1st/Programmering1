namespace Uppgift_5._1
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.tbxSkriv = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblSvar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnKör
            // 
            this.btnKör.Location = new System.Drawing.Point(334, 12);
            this.btnKör.Name = "btnKör";
            this.btnKör.Size = new System.Drawing.Size(260, 250);
            this.btnKör.TabIndex = 0;
            this.btnKör.Text = "KÖR";
            this.btnKör.UseVisualStyleBackColor = true;
            this.btnKör.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Skriv nedan ett tal";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(91, 234);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(218, 26);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Subtrahera talet du tänkte på";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(91, 202);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(218, 26);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Addera 3";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(91, 170);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(218, 26);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "Halvera";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(91, 138);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(218, 26);
            this.textBox4.TabIndex = 5;
            this.textBox4.Text = "Subtrahera 6";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(91, 106);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(218, 26);
            this.textBox5.TabIndex = 6;
            this.textBox5.Text = "Multiplicera med 2";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(91, 74);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(218, 26);
            this.textBox6.TabIndex = 7;
            this.textBox6.Text = "Addera med 1";
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // tbxSkriv
            // 
            this.tbxSkriv.Location = new System.Drawing.Point(91, 42);
            this.tbxSkriv.Name = "tbxSkriv";
            this.tbxSkriv.Size = new System.Drawing.Size(218, 26);
            this.tbxSkriv.TabIndex = 8;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(132, 300);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(45, 20);
            this.lbl1.TabIndex = 9;
            this.lbl1.Text = "Svar:";
            // 
            // lblSvar
            // 
            this.lblSvar.AutoSize = true;
            this.lblSvar.Location = new System.Drawing.Point(224, 300);
            this.lblSvar.Name = "lblSvar";
            this.lblSvar.Size = new System.Drawing.Size(61, 20);
            this.lblSvar.TabIndex = 10;
            this.lblSvar.Text = ".............";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSvar);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.tbxSkriv);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKör);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKör;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox tbxSkriv;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblSvar;
    }
}

