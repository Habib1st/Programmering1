using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift_9._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnBer_Click(object sender, EventArgs e)
        {
            double start = int.Parse(tbxStart.Text);
            double tid = int.Parse(tbxTid.Text);
            int räknare = 0;
            while (räknare<tid)
            {
                start *= 2;
                räknare++;
            }

            tbxSlut.Text = start.ToString();
            

        }
    }
}
