using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift_5._2
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

        private void button1_Click(object sender, EventArgs e)
        {
            double skriv = int.Parse(tbxSkriv.Text);
            double avr = skriv / 1000;
            double avr1 = Math.Round(avr);
            double svar = avr1 * 1000;

            lblSvar.Text = svar.ToString();  
        }
    }
}
