namespace ProvFORDON
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
            string regNr = tbxRegNr.Text;
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
                string message = "Reg.nr: " + fordon.Regnr + "\nMärke: " + fordon.Marke + "\nModell: " + fordon.Modell;
                MessageBox.Show(message);
            }
        }

        private void btnRadera_Click(object sender, EventArgs e)
        {
            if (lbxFordon.SelectedItems.Count > 0)
            {
                string regnr = (string)lbxFordon.SelectedItem;
                if (fordonDictionary.ContainsKey(regnr))
                {
                    fordonDictionary.Remove(regnr);
                    lbxFordon.Items.Remove(regnr);
                }
            }
        }

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
    }
}
