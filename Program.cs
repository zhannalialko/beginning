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
            Console.WriteLine("Schreib die Geschwindigkeit");
            int zahl = Convert.ToInt32(Console.ReadLine());
            string result = Fahren(zahl);
            Console.WriteLine($"Das Auto {result}");
        }

        static string Fahren(int geschwindigkeit)
        {
            
            if(geschwindigkeit<1)
            {
                return "steht.";
            }
            else if(geschwindigkeit<10)
            {
                return "schleicht";
            }
            else if(geschwindigkeit<20)
            {
                return "fährt";
            }
            else if(geschwindigkeit<50)
            {
                return "fährt schneller";
            }
            else if(geschwindigkeit>=50)
            {
                return "schnell";
            }
            else
            {
                return "ist kaputt";
            }
        }
    }
    
}




