namespace Kopplingsbräda
{
    public class Uppgift
    {
        public bool Uppgift1(bool knapp1, bool knapp2)
        {
            bool tänd = false;

            // Skriv din kod här:

            if (knapp1== true)
            {
                tänd = true;
            }
               else if (knapp2== true)
            {

                tänd=false;
            } 
            
                
            


            // Rör ej:
            return tänd;
        }

        public bool Uppgift2(bool tänt)
        {
            bool tänd = false;

            // Skriv din kod här:
            if ( tänt == false )
            {
                tänd =(true);
            }
            else if (tänt == true)
            {
                tänd=(false);
            }

            // Rör ej:
            return tänd;
        }


        public Färg Uppgift3(int värde)
        {
            Färg färg = Färg.Grå;

            //  Skriv din kod här:

            if (värde < 4)
            {
                färg = Färg.Röd;
            }
            else if (värde > 7)
            {
                färg = Färg.Grön;
            }
            else
            {
                färg = Färg.Gul;
            }

            //  Rör ej:
            return färg;
        }


        public bool Uppgift4(bool på, int värde)
        {
            bool tänd = false;

            //  Skriv din kod här:

            if (värde >= 4 && värde <= 6 && på == true)
            {
                tänd = true;
            }
            else
            {
                tänd=false;
            }
                 
            //  Rör ej:
            return tänd;
        }

        public bool Uppgift5(bool på, int värde)
        {
            bool tänd = false;

            //  Skriv din kod här:

            
            if (värde < 3 || värde > 7 && på == true)
            {
                tänd = true;
            }
            else
            {
                tänd = (false);
            }

            //  Rör ej:
            return tänd;
        }


        public Färg Uppgift6(int pin)
        {
            Färg färg = Färg.Grå;

            //  Skriv din kod här:

            


            //  Rör ej:
            return färg;
        }

        public bool[] Uppgift7(bool ett, bool två, bool tre, bool fyra, bool fem, bool sex,  bool sju)
        {
            bool lampaEtt = false, lampaTvå = false, lampaTre = false;

            //  Skriv din kod här:

            


           
            //  Rör ej:
            bool[] lampor = { lampaEtt, lampaTvå, lampaTre };
            return lampor;
        }

        public Färg Uppgift8(bool på)
        {
            Färg färg = Färg.Grå;

            //  Skriv din kod här:



            // Rör ej:
            return färg;
        }

    }
}
