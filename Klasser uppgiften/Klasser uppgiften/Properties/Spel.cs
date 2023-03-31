using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Klasser_uppgiften.Properties
{
    
    internal class Spel
    {
        private string namnPåSpelet;
        private string speltyp;
        private int publiceringsår;
    
        public string NamnPåSpel
        {
            get { return namnPåSpelet; }

        }

        public string Speltyp
        {
            get { return speltyp; }
        }

        public int Publiceringsår
        {
            get { return publiceringsår; }
        }

        
        

        public override string ToString()
        {
            string str = "Spelet heter " + namnPåSpelet + " och är av typen" + speltyp + ". Den publicerades år " + publiceringsår;

            return str;
        }

        public Spel(string _namnPåSpel, string _speltyp, int _publiceringsår)
        {
            namnPåSpelet = _namnPåSpel;
            speltyp = _speltyp;
            publiceringsår = _publiceringsår;
        }

    }

    

}
