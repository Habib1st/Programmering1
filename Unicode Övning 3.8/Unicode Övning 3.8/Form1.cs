using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unicode_Övning_3._8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            char versal = tbxVersal.Text[0];
            int teckenKod = (int)versal + 32;
            char gemen = (char) teckenKod;

            lblSvar.Text = gemen.ToString();   
        }
    }
}
