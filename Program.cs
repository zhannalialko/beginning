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
        //Aufgabe 12: Laufe mit einer For-Schleife über die Namen der Azubis & Studenten. Wenn der Name des Azubis ein „e“ enthält, gebe den Namen aus, ansonsten nicht.
        Console.WriteLine("Schreib Namen von Studenten und teile die Namen mit ',': ");
        string eingabe = Console.ReadLine();

        string[] ergebnis = eingabe.Split(",");

            foreach(string name in ergebnis)
            {
                if(name.Contains('e'))
                {
                    Console.WriteLine($"Namen mit e : {name}");
                }
            }

            //Aufgabe 12b: Wiederhole das Ganze und lass den Nutzer einen Buchstaben bestimmen, nach dem gesucht wird.
            Console.WriteLine("Schreib Namen von Studenten und teile die Namen mit ',': ");
            string eingabe1 = Console.ReadLine();
            
            Console.WriteLine("Schreib eine Buchstabe: ");
            string buchstabe = Console.ReadLine();

            string[] ergebnis1 = eingabe1.Split(",");
            
            foreach(string name in ergebnis1)
            {
                if(name.Contains(buchstabe))
                {
                    Console.WriteLine($"Namen mit {buchstabe} : {name}");
                }
            }
        }

        
        
        
    }
}


