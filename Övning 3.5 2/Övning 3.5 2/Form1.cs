using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_3._5_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            string namn = tbxNamn.Text;
            int född = int.Parse(tbxFödd.Text);
            int femtio = född + 50;

            string info = femtio + " fyller " + namn + " 50 år";
            string text = info.ToString();
            lblInfo.Text = text;
        }   

    }
}
