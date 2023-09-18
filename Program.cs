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
           Console.WriteLine("Wie viel Zahlen möchtest du in einem Array eingeben?");
           int eingabe = Convert.ToInt32(Console.ReadLine());

           int[] numbers = new int[eingabe];

           for(int i = 0; i < numbers.Length; i++)
           {
                Console.WriteLine("Gib eine Zahl");
                int zahl = Convert.ToInt32(Console.ReadLine());
                numbers[i] = zahl;

           }
            int klein = numbers.Min();
            int groß = numbers.Max();
            double mitte = numbers.Average();
            
            Console.WriteLine($"Die kleinste Zahl ist {klein}");
            Console.WriteLine($"Die größte Zahl ist {groß}");
            Console.WriteLine($"Der Durchschnitt ist {mitte}");

        }

    }
    
}




