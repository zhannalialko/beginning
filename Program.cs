using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;

// Aufgabe 1: Initialisiere 2 Zahlen und gebe die Summe auf der Console aus
namespace Example{
    class Programm
    {
        static void Main(string[] args)
        {
        //Aufgabe 7: Frage den Nutzer nach einem Text und ersetze im Text alle vorkommenden „U“ und „u“ durch „G“ und „g“
        Console.WriteLine("Schreib etwas!");
        string eingabe = Console.ReadLine();
        
        Console.WriteLine(eingabe.Replace('U', 'G').Replace('u', 'g'));
        }
    }
}


