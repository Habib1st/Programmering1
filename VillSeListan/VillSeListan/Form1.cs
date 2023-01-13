using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace VillSeListan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<String> lista = new List<string>();

        private void btnLäggTill_Click(object sender, EventArgs e)
        {
            string serie = tbxSerie.Text;
            lista.Add(serie);
        }

        private void btnVisa_Click(object sender, EventArgs e)
        {
            int index = int.Parse(tbxVisa.Text);
            bool lyckat = int.TryParse(tbxVisa.Text, out int resultat);

            if (index < lista.Count && index >= 0)
            {
                lblVisa.Text = lista[index];
            }
            else
            {
                lblVisa.Text = "Högt eller lågt försökt igen";
            }
        }
    }
}
