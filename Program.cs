using System.ComponentModel.DataAnnotations;
using System.Numerics;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;
namespace HelloWorld
{
    class Programm
    {
        static void Main(string[] args)
        {
            // Aufgabe: Zahlenraten
            // Frage den Nutzer nach einer zahl zwischen 1 bis 100
            // Erstelle eine RandomZahl => Hinweis
            //Überprüft die zahl ob es numberToGuess ist
            //wenn ja => hat der Spieler gewonnen
            //Wenn nein => sage ob die gesuchte Zahl kleiner oder größer als die eingegebene Zahl ist.
            
            

            Console.WriteLine("Schreib eine Zahl von 0 bis 100");
            string userstring = Console.ReadLine();

            int usernumber = Convert.ToInt16(userstring);

            Random random = new Random();
            int numberToGuesss = random.Next(0, 101);
            string ergebnis = "";
            while(ergebnis != "Genau!")
            {
                ergebnis = Vergleich(usernumber, numberToGuesss);
                if(ergebnis == "Genau!") {
                    break;
                }
                Console.WriteLine("Schreib eine Zahl von 0 bis 100");
                userstring = Console.ReadLine();
                usernumber = Convert.ToInt16(userstring);
            }

        }

        static string Vergleich(int zahl1, int zahl2)
        {
            if(zahl1>zahl2)
            {
                Console.WriteLine("zu groß");
                Console.WriteLine("Versuch noch einmal");
                return "zu groß";
            }
            else if(zahl1<zahl2)
            {
                Console.WriteLine("zu klein");
                Console.WriteLine("Versuch noch einmal");
                return "zu klein";            
            }
            else
            {
                Console.WriteLine("Genau!");
                return "Genau!";
                
            }
        }
    }
    
}




