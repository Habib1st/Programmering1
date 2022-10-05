using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_5._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            double taletA = double.Parse(tbxA.Text);    
            double taletB = double.Parse(tbxB.Text);
            double taletC = double.Parse(tbxC.Text);    

            bool talföljd = taletA < taletB && taletB < taletC;

            lblSvar.Text = " Är talen i ordningsföljd? " + talföljd;
        }
    }
}
