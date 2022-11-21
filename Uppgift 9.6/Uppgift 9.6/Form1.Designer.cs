namespace Uppgift_9._6
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbxRes = new System.Windows.Forms.TextBox();
            this.btnBer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Antalet sexor du fick av 1000 slag är:";
            // 
            // tbxRes
            // 
            this.tbxRes.Location = new System.Drawing.Point(363, 154);
            this.tbxRes.Name = "tbxRes";
            this.tbxRes.Size = new System.Drawing.Size(229, 26);
            this.tbxRes.TabIndex = 1;
            // 
            // btnBer
            // 
            this.btnBer.Location = new System.Drawing.Point(275, 147);
            this.btnBer.Name = "btnBer";
            this.btnBer.Size = new System.Drawing.Size(82, 41);
            this.btnBer.TabIndex = 2;
            this.btnBer.Text = "Beräkna";
            this.btnBer.UseVisualStyleBackColor = true;
            this.btnBer.Click += new System.EventHandler(this.btnBer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBer);
            this.Controls.Add(this.tbxRes);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxRes;
        private System.Windows.Forms.Button btnBer;
    }
}

