using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_3._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Tal1 = int.Parse(tbxA.Text);
            int Tal2 = int.Parse(tbxB.Text);
            int Tal3 = int.Parse(tbxC.Text);

            int summa = Tal1 + Tal2 + Tal3;
            string text = summa.ToString();
            lblSumma.Text = text;

            
            int medel = (Tal1 + Tal2 + Tal3) / 3;
            lblMedel.Text = medel.ToString();
             

        }
    }
}
