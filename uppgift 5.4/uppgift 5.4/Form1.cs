using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uppgift_5._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int skriv = int.Parse(tbxSkriv.Text);
            int timmar = skriv / 3600;
            int min = (skriv/60) % 60;
            int sek = skriv % 60 ;

            tbxTim.Text = timmar + " timmar";
            tbxMin.Text = min + " minuter";
            tbxSek.Text = sek + " sekunder";
        }   

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
