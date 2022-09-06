using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_3._6t
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            string engleska = tbxEngleska.Text;
            string svenska = tbsSvenska.Text;
            string info = engleska  +  " betyder "  +  svenska  +  " på svenska ";
            string text = info.ToString();
            lblSvar.Text = text;


        }
    }
}
