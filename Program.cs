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
            Console.WriteLine("Gib eine Zahl");
            int eingabe = Convert.ToInt32(Console.ReadLine());
            int fib1 = 1;
            int fib2 = 1;
            int ergebnis = 0;
            
            while(eingabe>=(fib1 + fib2))
            {
                ergebnis = fib1+fib2;
                Console.WriteLine(ergebnis);
                fib1 = fib2;
                fib2 = ergebnis;
            }
        
        }

    }
    
}




