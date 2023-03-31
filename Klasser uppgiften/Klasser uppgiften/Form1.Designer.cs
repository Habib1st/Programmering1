namespace Klasser_uppgiften
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
            this.lblSpelnamn = new System.Windows.Forms.Label();
            this.tbxNamn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxTyp = new System.Windows.Forms.TextBox();
            this.tbxÅr = new System.Windows.Forms.TextBox();
            this.lstbxRegister = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.listvNamn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listvTyp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listvÅr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnListv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSpelnamn
            // 
            this.lblSpelnamn.AutoSize = true;
            this.lblSpelnamn.Location = new System.Drawing.Point(17, 46);
            this.lblSpelnamn.Name = "lblSpelnamn";
            this.lblSpelnamn.Size = new System.Drawing.Size(120, 20);
            this.lblSpelnamn.TabIndex = 0;
            this.lblSpelnamn.Text = "Namn på spelet";
            // 
            // tbxNamn
            // 
            this.tbxNamn.Location = new System.Drawing.Point(143, 40);
            this.tbxNamn.Name = "tbxNamn";
            this.tbxNamn.Size = new System.Drawing.Size(100, 26);
            this.tbxNamn.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Speltyp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "publiceringsår";
            // 
            // tbxTyp
            // 
            this.tbxTyp.Location = new System.Drawing.Point(143, 149);
            this.tbxTyp.Name = "tbxTyp";
            this.tbxTyp.Size = new System.Drawing.Size(100, 26);
            this.tbxTyp.TabIndex = 4;
            // 
            // tbxÅr
            // 
            this.tbxÅr.Location = new System.Drawing.Point(143, 262);
            this.tbxÅr.Name = "tbxÅr";
            this.tbxÅr.Size = new System.Drawing.Size(100, 26);
            this.tbxÅr.TabIndex = 5;
            // 
            // lstbxRegister
            // 
            this.lstbxRegister.FormattingEnabled = true;
            this.lstbxRegister.ItemHeight = 20;
            this.lstbxRegister.Location = new System.Drawing.Point(331, 46);
            this.lstbxRegister.Name = "lstbxRegister";
            this.lstbxRegister.Size = new System.Drawing.Size(404, 64);
            this.lstbxRegister.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(327, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Register i listbox";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(45, 342);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(164, 41);
            this.btnRegister.TabIndex = 8;
            this.btnRegister.Text = "Spara i register ";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.listvNamn,
            this.listvTyp,
            this.listvÅr});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(331, 191);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(404, 97);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(327, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Register i listview";
            // 
            // listvNamn
            // 
            this.listvNamn.Text = "Namn";
            this.listvNamn.Width = 114;
            // 
            // listvTyp
            // 
            this.listvTyp.Text = "Typ";
            this.listvTyp.Width = 145;
            // 
            // listvÅr
            // 
            this.listvÅr.Text = "År";
            this.listvÅr.Width = 193;
            // 
            // btnListv
            // 
            this.btnListv.Location = new System.Drawing.Point(236, 351);
            this.btnListv.Name = "btnListv";
            this.btnListv.Size = new System.Drawing.Size(139, 32);
            this.btnListv.TabIndex = 11;
            this.btnListv.Text = "Spara i Listview";
            this.btnListv.UseVisualStyleBackColor = true;
            this.btnListv.Click += new System.EventHandler(this.btnListv_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnListv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstbxRegister);
            this.Controls.Add(this.tbxÅr);
            this.Controls.Add(this.tbxTyp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxNamn);
            this.Controls.Add(this.lblSpelnamn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSpelnamn;
        private System.Windows.Forms.TextBox tbxNamn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxTyp;
        private System.Windows.Forms.TextBox tbxÅr;
        private System.Windows.Forms.ListBox lstbxRegister;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader listvNamn;
        private System.Windows.Forms.ColumnHeader listvTyp;
        private System.Windows.Forms.ColumnHeader listvÅr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnListv;
    }
}

