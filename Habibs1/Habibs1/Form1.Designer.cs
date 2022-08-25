namespace Habibs1
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
            this.BTNGIttmannen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTNGIttmannen
            // 
            this.BTNGIttmannen.Location = new System.Drawing.Point(209, 120);
            this.BTNGIttmannen.Name = "BTNGIttmannen";
            this.BTNGIttmannen.Size = new System.Drawing.Size(140, 79);
            this.BTNGIttmannen.TabIndex = 0;
            this.BTNGIttmannen.Text = "Gittmannen";
            this.BTNGIttmannen.UseVisualStyleBackColor = true;
            this.BTNGIttmannen.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 367);
            this.Controls.Add(this.BTNGIttmannen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTNGIttmannen;
    }
}

