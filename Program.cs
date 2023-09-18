using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
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
            Console.WriteLine("Gib eine große Zahl");
            int eingabe = Convert.ToInt32(Console.ReadLine());

            float Tag = eingabe / 24 / 60 / 60;
            float restVonTagen = eingabe - Tag;
            float Stunde = restVonTagen / 60 / 60;
            float restVonStunden = eingabe - Tag - Stunde;
            float Minuten = restVonStunden / 60;
            float restVonMinuten = eingabe - Tag - Stunde - Minuten;
            float Sekunden = restVonMinuten;

            Console.WriteLine($"{eingabe} => {Tag}, {Stunde}, {Minuten}, {Sekunden}");
        
        }

    }
    
}




