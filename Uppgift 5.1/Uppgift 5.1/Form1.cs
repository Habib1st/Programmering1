using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift_5._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int skriv = int.Parse(tbxSkriv.Text);
            int add1 = skriv + 1;
            int mult2 = add1 * 2;
            int sub6 = mult2 - 6;
            int halv = sub6 / 2;
            int add3 = halv + 3;
            int subTal = add3 - skriv;
            lblSvar.Text = "Du har fått svaret " + subTal.ToString();
        }
    }
}
