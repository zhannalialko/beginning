using System.ComponentModel;
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
           Console.WriteLine("Gib eine ersten Zahl");
           int zahl1 = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("Gib eine zweite Zahl");
           int zahl2 = Convert.ToInt32(Console.ReadLine());

           int ergebnis = zahl1 % zahl2;
           Console.WriteLine($"Die Division von {zahl1} und {zahl2} erzeugt den Rest {ergebnis}");

        }
    }
    
}




