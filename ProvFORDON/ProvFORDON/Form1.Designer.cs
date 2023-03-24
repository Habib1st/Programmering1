namespace ProvFORDON
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbxRegNr = new System.Windows.Forms.TextBox();
            this.lbxFordon = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReg = new System.Windows.Forms.Button();
            this.tbxMarke = new System.Windows.Forms.TextBox();
            this.tbxModell = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxRegNr
            // 
            this.tbxRegNr.Location = new System.Drawing.Point(124, 59);
            this.tbxRegNr.Name = "tbxRegNr";
            this.tbxRegNr.Size = new System.Drawing.Size(150, 31);
            this.tbxRegNr.TabIndex = 0;
            // 
            // lbxFordon
            // 
            this.lbxFordon.FormattingEnabled = true;
            this.lbxFordon.ItemHeight = 25;
            this.lbxFordon.Location = new System.Drawing.Point(416, 59);
            this.lbxFordon.Name = "lbxFordon";
            this.lbxFordon.Size = new System.Drawing.Size(307, 179);
            this.lbxFordon.TabIndex = 1;
            this.lbxFordon.SelectedIndexChanged += new System.EventHandler(this.lbsFordon_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(31, 252);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(205, 34);
            this.btnReg.TabIndex = 3;
            this.btnReg.Text = "button1";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // tbxMarke
            // 
            this.tbxMarke.Location = new System.Drawing.Point(124, 116);
            this.tbxMarke.Name = "tbxMarke";
            this.tbxMarke.Size = new System.Drawing.Size(150, 31);
            this.tbxMarke.TabIndex = 4;
            // 
            // tbxModell
            // 
            this.tbxModell.Location = new System.Drawing.Point(124, 176);
            this.tbxModell.Name = "tbxModell";
            this.tbxModell.Size = new System.Drawing.Size(150, 31);
            this.tbxModell.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(416, 252);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(307, 34);
            this.btnRemove.TabIndex = 8;
            this.btnRemove.Text = "button2";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxModell);
            this.Controls.Add(this.tbxMarke);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxFordon);
            this.Controls.Add(this.tbxRegNr);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbxRegNr;
        private ListBox lbxFordon;
        private Label label1;
        private Button btnReg;
        private TextBox tbxMarke;
        private TextBox tbxModell;
        private Label label2;
        private Label label3;
        private Button btnRemove;
    }
}