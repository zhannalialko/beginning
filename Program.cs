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
using System.IO;
using System.Text;
namespace HelloWorld
{
    class Programm
    {
        static void Main(string[] args)
        {   
            int geschwindgkeit = 0;
            bool motorLaeuft = false;
            int aktuellerGang = 1;

            geschwindgkeit = Beschleunigen(motorLaeuft, geschwindgkeit, aktuellerGang);
            motorLaeuft = Starten(motorLaeuft);
            motorLaeuft = Starten(motorLaeuft);

            motorLaeuft = Ausschalten(motorLaeuft);
            motorLaeuft = Ausschalten(motorLaeuft);
            motorLaeuft = Starten(motorLaeuft);
            geschwindgkeit = Beschleunigen(motorLaeuft, geschwindgkeit, aktuellerGang);
            geschwindgkeit = Beschleunigen(motorLaeuft, geschwindgkeit, aktuellerGang);
            geschwindgkeit = Beschleunigen(motorLaeuft, geschwindgkeit, aktuellerGang);
            geschwindgkeit = Bremsen(motorLaeuft, geschwindgkeit, aktuellerGang);
            geschwindgkeit = Beschleunigen(motorLaeuft, geschwindgkeit, aktuellerGang);
            geschwindgkeit = Bremsen(motorLaeuft, geschwindgkeit, aktuellerGang);
            geschwindgkeit = Bremsen(motorLaeuft, geschwindgkeit, aktuellerGang);
            geschwindgkeit = Bremsen(motorLaeuft, geschwindgkeit, aktuellerGang);


            

            //Wir erstellen Methoden wie ein Auto fährt

            //Erstelle eine Methoden um das Auto zu starten
            //   - Wenn das auto schonmal gestartet wurde, soll die Meldung kommen, Auto läuft bereits

            //Auto ausschalten

            //erstelle eine Methode Beschleunigen, welche die Geschwindigkeit um 10 erhöht.
            //erstellen eine Methode Bremsen

            // Erstelle eine Methode Hochschalten und eine Methode Runterschalten
            // um die Gänge zu erhöhen bzw. reduzieren

            // Gebe immer innerhalb der Methode aus was der aktuelle Status ist.
            // z.B. Hochgeschalten von Gang 3 auf 4
            // z.B. Runtergeschalten von Gang 5 auf 4

        }

        static bool Starten(bool motorLaeuft)
        {
            if(motorLaeuft == false)
            {
                Console.WriteLine("Wir starten das Auto");
                return true;
            }
            else{
                Console.WriteLine("Motor läuft bereits");
                return true;
            }
        }

        static bool Ausschalten(bool motorLaeuft)
        {
            if(motorLaeuft == false)
            {
                Console.WriteLine("Das auto ist bereits aus");
                return false;
            }
            else{
                Console.WriteLine("Motor wird gestoppt");
                return false;
            }
        }

        static int Beschleunigen(bool motorLauft, int geschwindgkeit, int aktuellerGang)
        {
            if(motorLauft == false)
            {
                Console.WriteLine("Können nicht beschleunigen Auto ist aus.");
                return 0;
            }
            else
            {
                geschwindgkeit = geschwindgkeit + 10;
                Console.WriteLine($"Wir beschleunigen auf {geschwindgkeit}");
                Console.WriteLine("das Auto wird hochgeschaltet");
                int aktuellerGang1 = aktuellerGang++;
                Console.WriteLine($"Wir schalten von {aktuellerGang} auf {aktuellerGang1} hoch");
                return aktuellerGang1;  
            }

        }

        static int Bremsen(bool motorLauft, int geschwindgkeit, int aktuellerGang)
        {
            if(motorLauft == false)
            {
                Console.WriteLine("Können nicht beschleunigen Auto ist aus.");
                return 0;
            }
            else
            {
                geschwindgkeit = geschwindgkeit - 10;
                Console.WriteLine($"Wir bremsen auf {geschwindgkeit}");
                Console.WriteLine("das Auto wird hochgeschaltet");
                int aktuellerGang1 = aktuellerGang--;
                Console.WriteLine($"Wir schalten von {aktuellerGang} auf {aktuellerGang1} runten");
                return aktuellerGang1; 
            }

        }

    
        
    }
}