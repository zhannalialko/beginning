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
        //Aufgabe 13: Frage den Nutzer  wie viele Einträge er in einem int-Array haben möchte. 
        //Initialisiere ein int-Array von dieser Größe und befülle dieses Int Array in einer Schleife, 
        //indem du den Nutzer jedes Mal frägst, welche Zahl eingetragen werden soll.  

        Console.WriteLine("Schreib, wie viele Einträge du in einem int-Array haben möchtest ");
        string eingabe = Console.ReadLine();

        int zahl = Convert.ToInt16(eingabe);
        int i = 0;
        var reihe = new List<int>{};

        while(i < zahl)
        {
            Console.WriteLine("Scheib eine Zahl");
            string eingabe1 = Console.ReadLine();
            int zahl1 = Convert.ToInt16(eingabe1);
            reihe.Add(zahl1);
            i++;
        }
        
        foreach(var item in reihe)
        {
            Console.WriteLine(item);
        }
    }

        
        
    }      
}



