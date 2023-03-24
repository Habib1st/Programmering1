using System.Collections.Generic;
using System.Drawing.Text;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace Bankautomat
        
{
    
    public class BANKappLogic
    {
       

        int saldo = 0;
        string inmatat = "";

        /*Den här metoden, "hämtainmatat", är ansvarig för att hämta den inmatade strängen och göra den tillgänglig 
        för användning och läsning i andra delar av programmet.*/
        public string HämtaInmatat()
        {
            return inmatat;  
        }

        /* Denna kod beskriver en metod i C# som är ansvarig för att hantera sifferknappar på appen. 
        Metoden har två parametrar, varav den första representerar vilket läge användaren befinner sig i, 
        och den andra representerar värdet som användaren har tryckt på. Metoden kan hantera olika användaråtgärder, 
        såsom att lägga till eller ta bort siffror, avbryta eller godkänna en åtgärd genom att trycka på lämpliga knappar. */
        public void Inmatning(Läge läge , int värde)
        {
            if (värde < 0)
            {
                if (inmatat != "")
                {
                
                    inmatat = inmatat.Remove(inmatat.Length - 1);

                }

            }

            else if (läge == Läge.Inloggning)
            {
                if(inmatat.Length < 4)
                {

                     inmatat += värde;
                
                }

            }


          
            else if(läge != Läge.Inloggning)
            {
                if (inmatat == "" && värde == 0)
                {
                    
                }
                else
                {
                    inmatat += värde;
                } 
            }
         

        }

        /* Den här koden har en metod som heter "KontrolleraPinkod" och dess syfte är att kontrollera om en given PIN-kod är korrekt.
        Om koden är korrekt kommer metoden att returnera "true", annars kommer den att returnera "false" */
        private bool KontrolleraPinkod(string pin)
        {
            switch (pin)
            {
                case "1234":
                    return true;
                case "9876":
                    return true;
                case "4548":
                    return true;
                case "1337":
                    return true;
                case "4892":
                    return true;
                    default: 
                  return false;
            }
                
        }
        /* Den här metoden ska se till om det är true eller false när man trycker på den gröna knappen.
        Exempelvis om man skriver in pin kod och bekräftar så kommer den att se om koden är true eller false och
        kommer då att skcika ett meddelande. Det finns också två parametrar parametern Läge som visar vilket läge man är i
        och msg. */
        public bool Bekräfta(Läge läge, out string msg )
        {
            if (läge == Läge.Inloggning)
            {
                if (inmatat.Length == 4)
                {
                  
                    if (KontrolleraPinkod(inmatat))
                    {
                        inmatat = "";
                        msg = "PIN ok";
                        return true;
                    }
                    else
                    {
                        inmatat = "";
                        msg = "Felaktig PIN";
                        return false;
                    }
                }
                else
                {
                    inmatat = "";
                    msg = "Felaktig PIN";
                    return false;
                }
            }
            else
            {
                if (inmatat == "")
                {
                    msg = "";
                    return true;
                }
                else if (läge == Läge.Insättning)
                {
                    Insättning(int.Parse(inmatat));
                    msg = "Insättning: " + inmatat + "kr";
                    inmatat = "";
                    SparaInfo(msg);
                    return true;
                }
                else if (läge == Läge.Uttag)
                {
                   
                    if (Uttag(int.Parse(inmatat)))
                    {
                        msg = "Uttag: " + inmatat + "kr";
                        inmatat = "";
                        SparaInfo(msg);
                        return true;
                    }
                    else
                    {
                        msg = "Otillräckligt saldo";
                        inmatat = "";
                        return false;
                    }
                }
                else
                {
                    msg = "";
                    return true;
                }

                
            }
            
   
        }   
        // Den här metoden tar en ett värde och den läger den i saldot som kan sedan visas genom att trycka på läget saldo.
         
        private void Insättning(int värde)
        {
            saldo += värde;
        }
        // Den här tar ut pengar från saldot om den är tillräcklig
        private bool Uttag(int värde)
        {
            if(saldo >= värde)
            {
                saldo -=värde;
                return true;
            }
            else
            {
                return false;
            }
        }
        // Den här metoden visar saldot om man är i inloggat läge
        public string VisaSaldo(Läge läge)
        {
            if(läge != Läge.Inloggning)
            {
                return "Saldo: " + saldo + "kr";
            }
            else
            {
                return "";
            }
        }
        // Den här metoden är för att logga ut om man trycker på den röda knappen
        public bool Avbryt()
        {
            if( (MessageBox.Show("Är du säker?", "Avsluta", MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
                saldo = 0;
                inmatat = "";
                return true;
            }
            else
            {
                return false;

            }
            
          

            

        }

        List<string> historikInfo = new List<string>();

        // Denna metod retunerar hur många saker som finns i historikinfot
        public int HämtaHistorikInfoCount()
        {
            return historikInfo.Count;
        }
       
        // Denna metoden tar in en sträng, alltså det man vill spara, och lägger den i historiken.
        private void SparaInfo(string info)
        {
            historikInfo.Add(info);
        }

        // Den här metoden som man ser på namnet "VisaHistorik" visar och skriver ut historiken
        public void VisaHistorik(ListBox lbHistorik)
        {
            lbHistorik.Items.Clear();
            
            for (int i = 0; i < historikInfo.Count; i++) 
            {
                lbHistorik.Items.Add(historikInfo[i]);
            }

        }
        
        // Den här metoden tar bort det som är markerat historiken lbHistorik 
        public void TaBortEnstaka(ListBox lbHistorik)
        {
            if(lbHistorik.SelectedIndices.Count != 0)
            {
               int index = lbHistorik.SelectedIndex;
               historikInfo.RemoveAt(index);
            }
            VisaHistorik(lbHistorik);
        }

        // Denna metod tar bort allt som är i historiken 
        public void TaBortAlla(ListBox lbHistorik)
        {
            historikInfo= new List<string>();
            VisaHistorik(lbHistorik);
        }

        // Denna metoden låter andra delar av programmet rensa listboxen 
        public void RensaListbox(ListBox lbHistorik)
        {
            lbHistorik.Items.Clear();
        }


    }
}

