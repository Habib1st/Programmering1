using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace övning_3._7_Unicode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            char tecken = tbxTecken.Text[0];
            int kod = (int)tecken;


            lblSvar.Text = tecken.ToString() + " har koden" + kod.ToString();
            

        }
    }
}
