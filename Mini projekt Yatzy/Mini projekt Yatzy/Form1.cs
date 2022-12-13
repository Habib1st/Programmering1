using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_projekt_Yatzy
{
    public partial class Form1 : Form
    {
        Random dice = new Random();
        int[] tärningar = new int[5];
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKasta_Click(object sender, EventArgs e)
        {
            // I Image sparar vi de olika tärningar
            // I bool så får man hjälp av i nästa steg så man använder det
            for (int i = 0; i < tärningar.Length; i++)
            {
                tärningar[i] = dice.Next(1, 7);
            }
            Image[] tär = { diceGUI.d0, diceGUI.d1, diceGUI.d2, diceGUI.d3, diceGUI.d4, diceGUI.d5, diceGUI.d6 };
            dice1.Image = tär[tärningar[0]];
            dice2.Image = tär[tärningar[1]];
            dice3.Image = tär[tärningar[2]];
            dice4.Image = tär[tärningar[3]];
            dice5.Image = tär[tärningar[4]];

            int antalpar = 0;
            bool triss = false;
            bool fyrtal = false;
            bool yatzy = false;
            int poäng = 0;
            
            // Ger poäng till boolen , yatzy, par, två par, triss fyrtal... 
            for (int r = 1; r <= 6; r++)
            {
                int partal = 0;
                for (int j = 0; j < 5; j++)
                {
                    if (r == tärningar[j])
                    {
                        partal++;
                    }

                }
                switch (partal)
                {
                    case 2:
                        antalpar++;
                        poäng += r * 2;
                        break;
                    case 3:
                        triss = true;
                        poäng += r * 3;
                        break;
                    case 4:
                        fyrtal = true;
                        poäng += r * 4;
                        break;
                    case 5:
                        yatzy = true;
                        poäng += 50;
                        break;
                }
            }
            
            // Visar resultatet i form av poäng i en textbox. 
                if (yatzy == true)
                {
                    tbxRe.Text = "Yatzy: " + poäng.ToString();
                    btnKasta.Enabled = false;
                }
                else if (fyrtal == true)
                {
                    tbxRe.Text = "Fyrtal : " + poäng.ToString();
                }
                else if (triss == true && antalpar ==1)
                {
                    tbxRe.Text = "Kåk: " + poäng.ToString();
                }
                else if (triss == true)
                {
                    tbxRe.Text = "Triss :" + poäng.ToString();
                }
                else if (antalpar > 1)
                {
                    tbxRe.Text = "Två par : " + poäng.ToString();
                }
                else if (antalpar == 1)
                {
                    tbxRe.Text = "Par: " + poäng.ToString();
                }
                else if (!tärningar.Contains(6))
                {
                    poäng = 15;
                    tbxRe.Text = "Liten stege! " + poäng;
                }
                else if (!tärningar.Contains(1))
                {
                    poäng = 20;
                    tbxRe.Text = "Stor stege! " + poäng;
                }
                else
                {
                    tbxRe.Text = "Du fick inga poäng (Hehehe)";
                }
                
                
            




           
        }

    }
}
