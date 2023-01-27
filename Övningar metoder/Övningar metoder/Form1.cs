using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Övningar_metoder
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
        int Beräkna(int t1, int t2, char räknesätt)
        {
            switch (räknesätt)
            {
                case '+':
                    return t1 + t2;
                    
                    case '*':
                    return t1 * t2;
                    case '-':   
                        return t1 - t2;
                default: return 0;
                    
            }

        }


        int[] hämtaut()
        {
            int[] värden = { int.Parse(tbxT1.Text), int.Parse(tbxT2.Text) };
            return värden;
        }   

        private void btnAd_Click(object sender, EventArgs e)
        {

            int t1 = hämtaut()[0];
            int t2 = hämtaut()[1];
            
            int res = Beräkna(t1, t2,'+');

            SkrivUt(res);

        }
        void SkrivUt(int res)
        {
            lblRes.Text = res.ToString();
        }
private void btnMulti_Click(object sender, EventArgs e)
        {
            int t1 = hämtaut()[0];
            int t2 = hämtaut()[1];
            int resm = Beräkna(t1, t2, '*');
            SkrivUt(resm);
        }

        private void tbxT2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Sub_Click(object sender, EventArgs e)
        {
            int t1 = hämtaut()[0];
            int t2 = hämtaut()[1];
            int resm = Beräkna(t1, t2, '-');
            SkrivUt(resm);
        }
    }
}
