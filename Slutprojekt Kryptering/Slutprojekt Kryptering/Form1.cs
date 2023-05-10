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
                if (Char.IsLetter(nummer) && nummer >= 65 && nummer <= 90 )
                {
                    char detEnkrypterade = (char)(((int)nummer + 3));
                    if (detEnkrypterade > 'Z')
                    {
                        detEnkrypterade = (char)(((int)nummer - 23));
                        Console.WriteLine(detEnkrypterade);
                       

                    }
                    svaret += detEnkrypterade;

                }

                else if (Char.IsLetter(nummer) && nummer >= 97 && nummer <= 122)
                {
                    char detEnkrypterade = (char)(((int)nummer + 3));
                    if (detEnkrypterade > 'z')
                    {
                        detEnkrypterade = (char)(((int)nummer - 23));
                        Console.WriteLine(detEnkrypterade);

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

        public string Dekrypt3 (string detSkrivna)
        {
            string svaret = "";

            foreach (char nummer in detSkrivna)
            {
                if (Char.IsLetter(nummer) && nummer >= 65 && nummer <= 90)
                {
                    char detEnkrypterade = (char)(((int)nummer - 3));
                    if (detEnkrypterade < 'A')
                    {
                        detEnkrypterade = (char)(((int)nummer + 23));
                        Console.WriteLine(detEnkrypterade);


                    }
                    svaret += detEnkrypterade;

                }

                else if (Char.IsLetter(nummer) && nummer >= 97 && nummer <= 122)
                {
                    char detEnkrypterade = (char)(((int)nummer - 3));
                    if (detEnkrypterade < 'a')
                    {
                        detEnkrypterade = (char)(((int)nummer + 23));
                        Console.WriteLine(detEnkrypterade);

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
            btnDekrypt.Enabled = true;
            string kryptera = tbxKryptering.Text;
            tbxDekrypt.Text = Kryptering3(kryptera);
            
        }


        private void btnDekrypt_Click(object sender, EventArgs e)
        {
            btnDekrypt.Enabled = false;
            string dekrypt = tbxDekrypt.Text;
            tbxDekrypt.Text = Dekrypt3(dekrypt);
        }
    }
}
