using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exemplet_5._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            int allaMinuter = int.Parse(tbxSvar.Text);
            int timmar = allaMinuter / 12;
            int minuter = allaMinuter % 12;

            lblSvar.Text = timmar + " år " + " och " + minuter + "månader";

        }
    }
}
