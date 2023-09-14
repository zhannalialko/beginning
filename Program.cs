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
        //Aufgabe 9: Frage den Nutzer nach einer Eingabe mit Semikolons ( ; ) und Splitte die Eingabe an diesem Zeichen. Gebe die einzelnen Werte auf der Console aus.

        Console.WriteLine("Schreib etwas mit ;");
        string eingabe = Console.ReadLine();
        
            while(eingabe.Contains(';') == false)
            {
                Console.WriteLine("Schreib bitte etwas mit ;");
                eingabe = Console.ReadLine();
            }
        string[] ergebnis = eingabe.Split(";");

        Console.Write("Ergebnis: ");
        foreach(string str in ergebnis)
        {
            Console.WriteLine(str + "\n");
        }    
        }
    }
}


