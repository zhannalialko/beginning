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
        //Aufgabe 11: Frage den Nutzer nach einer Zahl und zähle von dieser Rückwärts bis 0

        Console.WriteLine("Schreib ein Zahl");
        string eingabe = Console.ReadLine();

        int zahl = Convert.ToInt16(eingabe);

        while(zahl>=0)
        {
            Console.WriteLine(zahl);
            zahl--;
        }
        }
    }
}


