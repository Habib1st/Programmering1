using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_9._9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] tecken = new string[3];
            tecken[0] = tbxTe1.Text;
            tecken[1] = tbxTe2.Text;
            tecken[2] = tbxTe3.Text;

            tbxTe1.Text =  tecken[2];
            tbxTe2.Text =  tecken[0];
            tbxTe3.Text =  tecken[1];
        }
    }
}
