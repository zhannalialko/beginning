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
           int [] myNumbers = new int[5];

           for(int i = 0; i<5; i++)
           {
            Console.WriteLine("Gebe ein Zahl");
            int number = Convert.ToInt16(Console.ReadLine());
            myNumbers[i] = number;
           }
            int klein = myNumbers.Min();
            int groß = myNumbers.Max();
            double mitte = myNumbers.Average();
            
            Console.WriteLine($"Die kleinste Zahl ist {klein}");
            Console.WriteLine($"Die größte Zahl ist {groß}");
            Console.WriteLine($"Der Durchschnitt ist {mitte}");
        }

    }
    
}




