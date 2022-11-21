using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift_9._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRäkna_Click(object sender, EventArgs e)
        {
            double papp = 0.1;
            double avst = 384000000000;
            int vikn = 0;
            while (papp <= avst)
            {
                papp = papp * 2;
                vikn++;
            }
            tbxSlut.AppendText(vikn.ToString());
        }
    }
}
