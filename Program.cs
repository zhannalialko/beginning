using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

// Aufgabe 1: Initialisiere 2 Zahlen und gebe die Summe auf der Console aus
namespace Example{
    class Programm
    {
        static void Main(string[] args)
        {
        //Aufgabe 10: Frage den Nutzer nach einer Eingabe und überprüfe die Texteingabe des Nutzers, ob die Zeichen „abc“ in der Eingabe enthalten sind. Gebe true oder false auf der Konsole aus.

        Console.WriteLine("Schreib etwas: ");
        string eingabe = Console.ReadLine();
        string str = "abc";

        Console.WriteLine(eingabe.Contains(str));
        }
    }
}


