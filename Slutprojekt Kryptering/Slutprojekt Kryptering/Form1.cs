using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slutprojekt_Kryptering
{
 
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        public string Kryptering3(string detSkrivna)
        {
            string svaret = "";

            foreach (char nummer in detSkrivna)
            {
                if (Char.IsLetter(nummer) && nummer <= 90 && nummer<=122)
                {
                    char detEnkrypterade = (char)(((int)nummer + 3));
                    if (detEnkrypterade > 'Z')
                    {
                        detEnkrypterade = (char)(((int)nummer - 23));
                    }
                    if (detEnkrypterade > 'z')
                    {
                        detEnkrypterade = (char)(((int)nummer - 23));
                    }

                    svaret += detEnkrypterade;
                }
               
                else
                {
                    svaret += nummer;
                }
            }

            return svaret;

        }
        private void btnSkicka_Click(object sender, EventArgs e)
        {
            string kryptera = tbxKryptering.Text;
            tbxDekrypt.Text = Kryptering3(kryptera);
            
        }

        private void btnDekrypt_Click(object sender, EventArgs e)
        {
            tbxDekrypt.Text = tbxKryptering.Text;
        }
    }
}
