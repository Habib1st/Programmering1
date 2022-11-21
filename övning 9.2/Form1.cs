using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace övning_9._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVisa_Click(object sender, EventArgs e)
        {
            double antalKorn = 1;
            double antalRutor = 64;
            double ruta = 1;

            while (ruta <= antalRutor)
            {
                tbxKorn.Text = tbxKorn.Text + "Ruta " + ruta + "\t" + antalKorn + "\r\n";
                antalKorn = antalKorn * 2;
                ruta++;
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
