using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift_3._4_a_och_b
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblBelopp_Click(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        { 
            int belopp = int.Parse(tbxBelopp.Text);
            int uttag = belopp / 500 * 500;
            
            int uttah = belopp / 100 * 100 - uttag;

            lblUttag.Text = "Uttag i 500 sedlar:" + uttag + " kr.";
            lblHundra.Text = "Uttag i 100-sedlar: " + uttah + " kr.";
            
            
        }
    }
}
