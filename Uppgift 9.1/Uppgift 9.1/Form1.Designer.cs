namespace Uppgift_9._1
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
            this.btnBer = new System.Windows.Forms.Button();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblTid = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxSlut = new System.Windows.Forms.TextBox();
            this.tbxTid = new System.Windows.Forms.TextBox();
            this.tbxStart = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBer
            // 
            this.btnBer.Location = new System.Drawing.Point(316, 219);
            this.btnBer.Name = "btnBer";
            this.btnBer.Size = new System.Drawing.Size(164, 56);
            this.btnBer.TabIndex = 0;
            this.btnBer.Text = "Beräkna tillväxt";
            this.btnBer.UseVisualStyleBackColor = true;
            this.btnBer.Click += new System.EventHandler(this.btnBer_Click);
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(194, 22);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(79, 20);
            this.lblStart.TabIndex = 1;
            this.lblStart.Text = "Startantal";
            this.lblStart.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTid
            // 
            this.lblTid.AutoSize = true;
            this.lblTid.Location = new System.Drawing.Point(194, 76);
            this.lblTid.Name = "lblTid";
            this.lblTid.Size = new System.Drawing.Size(30, 20);
            this.lblTid.TabIndex = 2;
            this.lblTid.Text = "Tid";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(422, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "x10 minuter";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Slutantal";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tbxSlut
            // 
            this.tbxSlut.Location = new System.Drawing.Point(316, 331);
            this.tbxSlut.Name = "tbxSlut";
            this.tbxSlut.Size = new System.Drawing.Size(422, 26);
            this.tbxSlut.TabIndex = 5;
            // 
            // tbxTid
            // 
            this.tbxTid.Location = new System.Drawing.Point(316, 70);
            this.tbxTid.Name = "tbxTid";
            this.tbxTid.Size = new System.Drawing.Size(100, 26);
            this.tbxTid.TabIndex = 6;
            // 
            // tbxStart
            // 
            this.tbxStart.Location = new System.Drawing.Point(316, 16);
            this.tbxStart.Name = "tbxStart";
            this.tbxStart.Size = new System.Drawing.Size(398, 26);
            this.tbxStart.TabIndex = 7;
            this.tbxStart.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxStart);
            this.Controls.Add(this.tbxTid);
            this.Controls.Add(this.tbxSlut);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTid);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.btnBer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBer;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblTid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxSlut;
        private System.Windows.Forms.TextBox tbxTid;
        private System.Windows.Forms.TextBox tbxStart;
    }
}

