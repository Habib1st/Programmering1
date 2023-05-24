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

        public char Kryptering7(char detSkrivna)
        {
            char svaret ;
            char varjeChar = detSkrivna;

        
            if (Char.IsLetter(varjeChar) && varjeChar >= 65 && varjeChar <= 90)
            {
                char detEnkrypterade = (char)((int)varjeChar + 7);
                if (detEnkrypterade > 'Z')
                {
                    detEnkrypterade = (char)(((int)varjeChar - 19));
                    Console.WriteLine(detEnkrypterade);


                }
                svaret = detEnkrypterade;

            }

            else if (Char.IsLetter(varjeChar) && varjeChar >= 97 && varjeChar <= 122)
            {
                char detEnkrypterade = (char)(((int)varjeChar + 7));
                if (detEnkrypterade > 'z')
                {
                    detEnkrypterade = (char)(((int)varjeChar - 19));
                    Console.WriteLine(detEnkrypterade);

                }
                svaret = detEnkrypterade;
            }



            else
            {
                svaret = varjeChar;
            }
            

            return svaret;

        }

        public char DeKryptering7(char detSkrivna)
        {
            char svaret;
            char varjeChar = detSkrivna;
            
            if (Char.IsLetter(varjeChar) && varjeChar >= 65 && varjeChar <= 90)
            {
                char detEnkrypterade = (char)((int)varjeChar - 7);
                if (detEnkrypterade < 'A')
                {
                    detEnkrypterade = (char)(((int)varjeChar + 19));
                    Console.WriteLine(detEnkrypterade);


                }
                svaret = detEnkrypterade;

            }

            else if (Char.IsLetter(varjeChar) && varjeChar >= 97 && varjeChar <= 122)
            {
                char detEnkrypterade = (char)(((int)varjeChar - 7));
                if (detEnkrypterade < 'a')
                {
                    detEnkrypterade = (char)(((int)varjeChar + 19));
                    Console.WriteLine(detEnkrypterade);

                }
                svaret = detEnkrypterade;
            }



            else
            {
                svaret = varjeChar;
            }
            

            return svaret;

        }
        public char Kryptering13(char detSkrivna)
        {
            char svaret;
            char varjeChar = detSkrivna;
            
            if (Char.IsLetter(varjeChar) && varjeChar >= 65 && varjeChar <= 90)
            {
                char detEnkrypterade = (char)(((int)varjeChar + 13));
                if (detEnkrypterade > 'Z')
                {
                    detEnkrypterade = (char)(((int)varjeChar - 13));
                    Console.WriteLine(detEnkrypterade);


                }
                svaret = detEnkrypterade;

            }

            else if (Char.IsLetter(varjeChar) && varjeChar >= 97 && varjeChar <= 122)
            {
                char detEnkrypterade = (char)(((int)varjeChar + 13));
                if (detEnkrypterade > 'z')
                {
                    detEnkrypterade = (char)(((int)varjeChar - 13));
                    Console.WriteLine(detEnkrypterade);

                }
                svaret = detEnkrypterade;
            }



            else
            {
                svaret = varjeChar;
            }
            

            return svaret;

        }

        public char Dekryptering13(char detSkrivna)
        {
            char svaret;
            char varjeChar = detSkrivna;

            
            if (Char.IsLetter(varjeChar) && varjeChar >= 65 && varjeChar <= 90)
            {
                char detEnkrypterade = (char)(((int)varjeChar - 13));
                if (detEnkrypterade < 'A')
                {
                    detEnkrypterade = (char)(((int)varjeChar + 13));
                    Console.WriteLine(detEnkrypterade);


                }
                svaret = detEnkrypterade;

            }

            else if (Char.IsLetter(varjeChar) && varjeChar >= 97 && varjeChar <= 122)
            {
                char detEnkrypterade = (char)(((int)varjeChar - 13));
                if (detEnkrypterade < 'a')
                {
                    detEnkrypterade = (char)(((int)varjeChar + 13));
                    Console.WriteLine(detEnkrypterade);

                }
                svaret = detEnkrypterade;
            }



            else
            {
                svaret = varjeChar;
            }
            

            return svaret;

        }


        



        private void btnDekrypt_Click(object sender, EventArgs e)
        {

            string dekryptera = tbxDekrypt.Text;
            if (dekryptera != "")
            {

                string svaret = "";
                for (int i = 0; i < dekryptera.Length; i++)
                {
                    if ((i / 5) % 2 != 0)
                    {
                        svaret += Dekryptering13(dekryptera[i]);


                    }
                    else
                    {
                        svaret += DeKryptering7(dekryptera[i]);
                    }

                }
                tbxKryptering.Text = svaret;
                btnDekrypt.Enabled = false;
                btnRot7o13.Enabled = true;
                tbxDekrypt.Clear();
            }
        }

        private void rot7o13_Click(object sender, EventArgs e)
        {
            string kryptera = tbxKryptering.Text;
            if (kryptera != "")
            {
                
                string svaret = "";
                for (int i = 0; i < kryptera.Length; i++)
                {
                    if((i/5)%2 != 0)
                    {
                        svaret += Kryptering13(kryptera[i]);
                    }
                    else
                    {
                        svaret += Kryptering7(kryptera[i]);
                    }
               
                }
                tbxDekrypt.Text = svaret;
                btnRot7o13.Enabled = false;
                btnDekrypt.Enabled = true;
                tbxKryptering.Clear();
            }
        }
    }
}
