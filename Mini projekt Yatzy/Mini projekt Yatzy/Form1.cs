using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

         int antalSlag=0;
         int maxSlag = 3;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnKasta_Click(object sender, EventArgs e)
        {
            //hur många slag man får max göra
            if (antalSlag >= maxSlag)
            {
                tbxSlag.Text = "du har slagit max antal slag";
                return;
            }
            // I Image sparar vi de olika tärningar
            // I bool så får man hjälp av i nästa steg så man använder det
            for (int i = 0; i < tärningar.Length; i++)
            {
                if (håll[i])
                    continue;
                tärningar[i] = dice.Next(1, 7);
            }
          

            
            antalSlag++;
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
       
        // Håll tärningar som du vill ha kvar

        bool[] håll = new bool[5];
        private object die1Label;
        private object die2Label;
        private string die3Label;
        private string dice4Label;
        private object dice5Label;

        private void dice1_Click(object sender, EventArgs e)
        {
            if (håll[0] == true) håll[0] = false; else { håll[0] = true; }
            if (håll[0] == true) dice1.BorderStyle = BorderStyle.Fixed3D; else { dice1.BorderStyle = BorderStyle.None; }

        }

        private void dice2_Click(object sender, EventArgs e)
        {
            if (håll[1] == true) håll[1] = false; else { håll[1] = true; }
            if (håll[1] == true) dice2.BorderStyle = BorderStyle.Fixed3D; else { dice2.BorderStyle = BorderStyle.None; }
        }

        private void dice3_Click(object sender, EventArgs e)
        {
            if (håll[2] == true) håll[2] = false; else { håll[2] = true; }
            if (håll[2] == true) dice3.BorderStyle = BorderStyle.Fixed3D; else { dice3.BorderStyle = BorderStyle.None; }
        }

        private void dice4_Click(object sender, EventArgs e)
        {
            if (håll[3] == true) håll[3] = false; else { håll[3] = true; }
            if (håll[3] == true) dice4.BorderStyle = BorderStyle.Fixed3D; else { dice4.BorderStyle = BorderStyle.None; }
        }

        private void dice5_Click(object sender, EventArgs e)
        {
            if (håll[4] == true) håll[4] = false; else { håll[4] = true; }
            if (håll[4] == true) dice5.BorderStyle = BorderStyle.Fixed3D; else { dice5.BorderStyle = BorderStyle.None; }
        }

        private void btnRe_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }
    }
}
