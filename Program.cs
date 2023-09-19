using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Globalization;
using System.Net.WebSockets;
using System.Numerics;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Xml.XPath;
using Microsoft.VisualBasic;
namespace HelloWorld
{
    class Programm
    {
        static void Main(string[] args)
        {
            /* 
           Erzeuge eine ganzzahlige Zufallszahl k im Bereich[0...36]. die Zahl k ist das Ergebnis 
           eines Roulette-Wurf. Simuliere nun das Spiel: 
            •   Sie gehen mit $10.000 in ein Spielkasino und setzen $10 auf Pair: 
                o   Wenn k gerade ist und k ungleich 0 ist, erhalten Sie nach dem nächsten Spiel $20 (Gewinn = doppelter Einsatz bei Erfolg). 
                o   Wenn k=0, bleibt Ihr Einsatz bestehen.
                o   Wenn k ungerade ist, verlieren Sie Ihren Einsatz. 
            •   Du machst n Spiele mit der folgenden Strategie: 
                o   Wenn du mindestens $10.000 besitzt und das letzte Spiel gewonnen hast, setze $10. 
                o   Wenn du mindestens 10.000 $ besitzt, aber das letzte Spiel verloren hast, verdoppelst du deinen Einsatz. 
                o   Wenn du weniger als 10.000 $ hast, verdoppelst du deinen Gesamtverlust. 
                o   Wenn dein Geld für den geplanten Zug nicht ausreicht, wird das komplette Restkapital eingesetzt. 
                o   Wenn du den maximal zulässigen Einsatz von $1.000 überschreiten würdest, setzt du nur $1.000. 
            Gebe für jedes Spiel die folgenden Informationen an: 
            Anzahl des Spiels, die geworfene Zahl, Kapital davor, Kapital danach, Verwende dazu die Methode String. Format mit dem $ -Operator.

            */
            Random random = new Random();
            
            int kapital = 10000;
            int anzahlSpiele = 0; 
            bool lostLastGame = false;
            int lastInset = 10;
            int geworfeneZahl = 0;
            while(kapital>0 || kapital > 20000) 
            {
                lastInset = BerechneEinsatz(kapital, lostLastGame, lastInset, geworfeneZahl);

                if(lastInset > kapital)
                {
                    lastInset = kapital;
                }

                kapital -= lastInset;
                geworfeneZahl = random.Next(0,37);
                anzahlSpiele += 1;

                if(geworfeneZahl % 2 == 0 && geworfeneZahl != 0) 
                {
                    kapital = kapital + 2*lastInset;
                    lostLastGame = false;
                }
                else
                {
                    lostLastGame = true;
                }
                Console.WriteLine($"Anzahl Spiel: {anzahlSpiele}, Geworfene Zahl {geworfeneZahl}, Aktuelles Kapital: {kapital}, Letzter Einsatz: {lastInset}");

                Thread.Sleep(10);
            }
        }

        static int BerechneEinsatz(int kapital, bool lostLastGame, int lastInset, int geworfeneZahl)
        {
            if(geworfeneZahl == 0)
            {
                return lastInset;
            }

            if(lostLastGame == false && kapital > 10000)
            {
                return 10;
            }
            else if (lostLastGame == true && kapital > 10000)
            {
                return Math.Min(lastInset*2,1000);
            }

            if(kapital < 10000)
            {
                int gesamtVerlust = 10000-kapital;
                return Math.Min(gesamtVerlust *2, 1000);
            }

            //Trifft nie zu aber C# will den case.
            return 10;
        }

        
    }
} 

            
         


