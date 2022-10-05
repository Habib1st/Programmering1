using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace övnong_5._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            double pengar = double.Parse(tbxPengar.Text);   
            double pris = double.Parse(tbxPris.Text);
            bool harRåd = pengar >= pris;

            lblSvar.Text = "Jag har råd: " + harRåd;
        }
    }
}
