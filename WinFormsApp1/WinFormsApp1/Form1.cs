using System.Windows.Forms;

namespace Prov_Fordonsregistret
{
    public partial class Form1 : Form
    {
        private static Dictionary<string, Fordon> fordonDictionary = new Dictionary<string, Fordon>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            string regNr = tbxReg.Text;
            string marke = tbxMarke.Text;
            string modell = tbxModell.Text;

            Fordon fordon = new Fordon(regNr, marke, modell);
            fordonDictionary.Add(regNr, fordon);

            lbxFordon.Items.Add(regNr);

            tbxRegNr.Clear();
            tbxMarke.Clear();
            tbxModell.Clear();
        }

        private void lbxFordon_SelectedIndexChanged(object sender, EventArgs e)
        {
            string regnr = (string)lbxFordon.SelectedItem;
            if (fordonDictionary.ContainsKey(regnr))
            {
                Fordon fordon = fordonDictionary[regnr];
                string message = "Reg.nr: " + fordon.Regnr + "\nM�rke: " + fordon.Marke + "\nModell: " + fordon.Modell;
                MessageBox.Show(message);
            }
        }

        private TextBox tbxRegNr;
        private Label label1;
        private ListBox lbxFordon;
        private Button btnReg;
        private TextBox tbxMarke;
        private TextBox tbxModell;
        private Label label2;
        private Label label3;
        private Button btnDelet;

        public class Fordon
        {
            public string Regnr { get; set; }
            public string Marke { get; set; }
            public string Modell { get; set; }

            public Fordon(string regnr, string marke, string modell)
            {
                Regnr = regnr;
                Marke = marke;
                Modell = modell;
            }
        }

        private void InitializeComponent()
        {
            this.tbxRegNr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbxFordon = new System.Windows.Forms.ListBox();
            this.btnReg = new System.Windows.Forms.Button();
            this.tbxMarke = new System.Windows.Forms.TextBox();
            this.tbxModell = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDelet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxRegNr
            // 
            this.tbxRegNr.Location = new System.Drawing.Point(210, 62);
            this.tbxRegNr.Name = "tbxRegNr";
            this.tbxRegNr.Size = new System.Drawing.Size(150, 31);
            this.tbxRegNr.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // lbxFordon
            // 
            this.lbxFordon.FormattingEnabled = true;
            this.lbxFordon.ItemHeight = 25;
            this.lbxFordon.Location = new System.Drawing.Point(609, 62);
            this.lbxFordon.Name = "lbxFordon";
            this.lbxFordon.Size = new System.Drawing.Size(180, 129);
            this.lbxFordon.TabIndex = 2;
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(210, 210);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(112, 34);
            this.btnReg.TabIndex = 3;
            this.btnReg.Text = "btnReg";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbxMarke
            // 
            this.tbxMarke.Location = new System.Drawing.Point(210, 108);
            this.tbxMarke.Name = "tbxMarke";
            this.tbxMarke.Size = new System.Drawing.Size(150, 31);
            this.tbxMarke.TabIndex = 4;
            // 
            // tbxModell
            // 
            this.tbxModell.Location = new System.Drawing.Point(210, 160);
            this.tbxModell.Name = "tbxModell";
            this.tbxModell.Size = new System.Drawing.Size(150, 31);
            this.tbxModell.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // btnDelet
            // 
            this.btnDelet.Location = new System.Drawing.Point(640, 254);
            this.btnDelet.Name = "btnDelet";
            this.btnDelet.Size = new System.Drawing.Size(112, 34);
            this.btnDelet.TabIndex = 8;
            this.btnDelet.Text = "button2";
            this.btnDelet.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 450);
            this.Controls.Add(this.btnDelet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxModell);
            this.Controls.Add(this.tbxMarke);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.lbxFordon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxRegNr);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}