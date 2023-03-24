using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms.VisualStyles;

namespace PokerLite
{
    // Jag lägger in flitigt med kommentarer här för er hjälp. Behövs mer
    // information finns även utförliga beskrivningar i instruktionerna på 
    // Classroom.
    class Uppgift
    {
        Queue<string> kortlek;              //  Korleken är en kö, eftersom dess enda funktion är att nästa kort ska dras. 
        public string[] handSpelare1;       //  Spelarnas händer består alltid av fem kort eller "empty". Därför passar Array bra.
        public string[] handSpelare2;
        public Stack<string> slängHög;      //  Slänghögen tar emot kort som slängs. En hög med kort, så stack är bra.
        public Stack<string> öppnaKort;     //  Korten i slänghögen ska hämna här till nästa runda. Här tas det senaste kortet först, så stack är bra.

        public int spelaresTur;

        public void StartaSpelet(List<string> allaKort)
        {
            /*
             * Denna metod kör när spelaren trycker på startknappen. Bra tillfälle 
             * att förbereda de samlingar vi deklarerat. Fördelen med att göra det 
             * här och inte i deklarerandet av medlemsvariabler ovan är att detta 
             * då görs om från början varje omgång. 
             * 
             * Parametern "allaKort" i metoden är en lista med alla 52 kort blandade. 
             */

            //  Initiera kön "kortlek" med nyckelordet "new" 

            kortlek = new Queue<string>();
           
            
            //  Köa alla kort från listan "allaKort" till "kortlek" (använd for-loop)
            for(int i = 0;i < allaKort.Count;i++)
            {
                kortlek.Enqueue(allaKort[i]);
            }


            //  Initiera arrayerna "handSpelare1" och "handSpelare2" med 5 i längd och ge sedan
            //  varje index innehåller "empty" (en tom hand)
            handSpelare1 = new string[5];
            handSpelare2 = new string[5];

            for (int i = 0;i<handSpelare1.Length; i++)
            { 
                handSpelare1[i] = "empty"; 
            
            }

            for (int i = 0; i < handSpelare1.Length; i++)
            {
                handSpelare2[i] = "empty";
            }
            //  Initiera stackarna "slängHög" och "öppnaKort".

            slängHög= new Stack<string>();
            öppnaKort = new Stack<string>();




            //  Lägg ett kort från kortleken på stacken "öppnaKort"
            öppnaKort.Push(kortlek.Dequeue());
          

            DraNyaKort();
            spelaresTur = 1;
        }

        public void DraNyaKort()
        {
            
          
            /*
                Denna metod hämtar ett nytt kort till spelaren vars tur det är, eller fem kort
                till båda spelarna ifall spelet just startar. Detta kontrolleras genom variabeln
                "spelaresTur"
            
                Loopa igenom spelarnas händer (fem gånger) och, beroende på vems tur det är,
                kolla om spelarens hand har plats för ett kort (handSpelare#[i] == "empty").
                I så fall, dra nästa kort från kortleken och placera i spelarens hand.
                
                När det kontrollerats vems tur det är läggs en "else" till (när spelet startar är 
                "spelaresTur" = 0) som lägger till ett kort i båda spelares händer. På så vis dras 
                en full hand när spelet startar.
            */

            
            for(int i = 0; i < 5; i++)
            {
                if (spelaresTur == 1)
                {
                    if (handSpelare1[i] == "empty")
                    {
                        handSpelare1[i] = kortlek.Dequeue();
                    }
                }
                else if (spelaresTur == 2)
                {
                    if (handSpelare2[i] == "empty")
                    {
                        handSpelare2[i] = kortlek.Dequeue();
                    }
                }
                else
                {

                    handSpelare1[i] = kortlek.Dequeue();
                    handSpelare2[i] = kortlek.Dequeue();
                }

            }
        }

        public void SlängKort(string kort, int index)
        {
            /*  
                När en spelare klickar på ett kort ska det kastas. Det tar denna metod hand om. 
                Kortet som klickas på skickas som parameter till denna metod ("kort") och ska
                tas bort från handSpelare# () och köas i "slängHög".

                Kolla först vems tur det är och att "kort" inte är "empty".
            */

            if (spelaresTur == 1 && kort != "empty")
            {
                slängHög.Push(kort);
                handSpelare1[index] = "empty";
                //  Lägg till kortet (från parametern ovan) i slänghögen
                //  Ta sedan bort det ur handen på Spelare 1 genom att lägg till "empty" på parametern "index"s position
            }
            else if (spelaresTur == 2 && kort != "empty")
            {

                slängHög.Push(kort);
                handSpelare2[index] = "empty";
            }

        }

        public bool DraGammaltKort()
        {
            /*
                I detta spel ska det vara möjligt att antingen ta ett kort ur kortleken (som 
                DraNyaKort() tar hand om) eller det översta kortet i "öppnaKort" stacken. 
                Denna metod behöver kolla så att aktuell spelare har plats för ett kort och i 
                så fall hämta översta kortet i stacken. 
                
                Notera att den bara ska ta ett kort, om möjligt. 

                Den behöver även kolla ifall "öppnaKort" är tom och i så fall ta ett kort från 
                kortleken dit.    

                Logiken är i princip densamma som när ett nytt kort dras ur kortleken.
            */

            bool fannsTomt = false;
            if (spelaresTur == 1)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (handSpelare1[i] == "empty")
                    {
                        handSpelare1[i] = öppnaKort.Pop();
                        fannsTomt = true;
                        break;
                    }
                }
            }
            else
            {
                for (int i = 0; i < 5; i++)
                {
                    if (handSpelare2[i] == "empty")
                    {
                        handSpelare2[i] = öppnaKort.Pop();
                        fannsTomt = true;
                        break;
                    }
                }
            }

            if (öppnaKort.Count == 0)
            {
                öppnaKort.Push(kortlek.Dequeue());
            }

            return fannsTomt;

        }

        public void SlängdaTillÖppna()
        {
            for(int i = 0; i < slängHög.Count; i++)
            {
                öppnaKort.Push(slängHög.Pop());
            }
           
            
            //    Loopa igenom slänghögen och flytta dem till öppnakort-stacken.
            
        }
    }
}
