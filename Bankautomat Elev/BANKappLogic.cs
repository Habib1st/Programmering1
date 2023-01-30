using System.Collections.Generic;
using System.Windows.Forms;

namespace Bankautomat
{
    public class BANKappLogic
    {
        //  Medlemsvariabler

        int saldo = 0;
        string inmatat = "";

        //  Metoder
        public string HämtaInmatat(string inmatat)
        {
            return inmatat;  
        }
        public void Inmatning(Läge läge , int värde)
        {
            if (värde < 0)
            {
                inmatat = inmatat.Remove(inmatat.Length - 1);

            }

            else if (läge == Läge.Inloggning && inmatat.Length < 4 )
            {
                inmatat += värde;
            }
            else
            {
                
                
            }


        }
    }
}
