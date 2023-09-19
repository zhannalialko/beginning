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
            int amountSeconds = Convert.ToInt32(Console.ReadLine());

            int amountDays = amountSeconds / 24 / 60 / 60;
            Console.WriteLine("Anzahl Tage:" + amountDays);
            int restSeconds = amountSeconds % ( 24 * 60 * 60);
            int amountHours = restSeconds / 60 / 60;
            restSeconds = restSeconds % (60 * 60);
            int amountMinutes = restSeconds / 60 ;
            restSeconds = restSeconds % 60;
            
            Console.WriteLine($@"Aus der Anzahl {amountSeconds} wird {amountDays} Tage, {amountHours}
                                Stunden, {amountMinutes} Minuten, {restSeconds} Sekunden");
        
        }

    }
    
}




