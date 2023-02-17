using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace Bankautomat
{
    public class BANKappLogic
    {
       

        int saldo = 0;
        string inmatat = "";

       
        public string HämtaInmatat()
        {
            return inmatat;  
        }
        public void Inmatning(Läge läge , int värde)
        {
            if (värde < 0)
            {
                if (inmatat.Length >0)
                {
                
                    inmatat = inmatat.Remove(inmatat.Length - 1);

                }

            }

            else if (läge == Läge.Inloggning && inmatat.Length < 4 )
            {
                inmatat += värde;
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

        public bool Bekräfta(Läge läge, out string msg )
        {
            if (läge == Läge.Inloggning)
            {
                if (inmatat.Length == 4)
                {
                    KontrolleraPinkod(inmatat);
                    if (true)
                    {
                        inmatat = "";
                        msg = "PIN OK";
                        return true;
                    }
                    else
                    {
                        inmatat = "";
                        msg = "PIN FELAKTIG";
                        return false;
                    }
                }
                else
                {
                    inmatat = "";
                    msg = "";
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
                    return true;
                }
                else if (läge == Läge.Uttag)
                {
                    Uttag(int.Parse(inmatat));
                    if (true)
                    {
                        msg = "Uttag; " + inmatat + "kr";
                        inmatat = "";
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
        
        private void Insättning(int värde)
        {
            saldo += värde;
        }
        private bool Uttag(int värde)
        {
            if(saldo > värde)
            {
                saldo -=värde;
                return true;
            }
            else
            {
                return false;
            }
        }
        public string VisaSaldo(Läge läge)
        {
            if(läge == Läge.Inloggning)
            {
                return "Saldo: ****kr";
            }
            else
            {
                return "";
            }
        }
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
    }
}
