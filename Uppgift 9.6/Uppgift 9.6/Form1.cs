using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift_9._6
{
    public partial class Form1 : Form
    {
        readonly Random tärningar = new Random();
        int[] nrSex;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBer_Click(object sender, EventArgs e)
        {
            btnBer_Click(sender, e, nrSex);
        }

        private void btnBer_Click(object sender, EventArgs e, int[] nrSex)
        {
            int hurMångase = 0;
           
            nrSex = new int[1000];

            for (int i = 0; i < nrSex.Length; i++) 
            {
                nrSex[i] = tärningar.Next(1, 7);


                if (nrSex[i] == 6)
                {
                    hurMångase++;
                }
                         
            }
            tbxRes.AppendText(hurMångase.ToString());
        }
    }
}
