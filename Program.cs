using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Globalization;
using System.Net.WebSockets;
using System.Numerics;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Xml.XPath;
using Microsoft.VisualBasic;
namespace HelloWorld
{
    class Programm
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Scheir den Zahl");
            string eingabe1 = Console.ReadLine();

            Console.WriteLine($"Der Umfang des Kreises ist {UmfangKreis(eingabe1)}");

            Console.WriteLine($"Der Umfang des Quadrats ist {UmfangQuadrat(eingabe1)}");

            Console.WriteLine("Scheir den zweiten Zahl");
            string eingabe2 = Console.ReadLine();
            Console.WriteLine($"Der Umfang des Rechtecks ist {UmfangRechteck(eingabe1, eingabe2)}");

            Console.WriteLine($"Der Volumen des Wurfels ist {VolumenWuerfel(eingabe1)}");

            Console.WriteLine("Scheir den dritten Zahl");
            string eingabe3 = Console.ReadLine();
            Console.WriteLine($"Der Volumen des Quaders ist {VolumenQuader(eingabe1, eingabe2, eingabe3)}");

        }  

        static double UmfangKreis(string zahl)
        {
            double number = Convert.ToDouble(zahl);
            double result = 2 * 3.14 * number;
            return result;
        }  

        static double UmfangQuadrat(string zahl)
        {
            double number = Convert.ToDouble(zahl);
            double result = 4*number;
            return result;
        }

        static double UmfangRechteck(string zahl1, string zahl2)
        {
            double number1 = Convert.ToDouble(zahl1);
            double number2 = Convert.ToDouble(zahl2);
            double result = (2*number1)+(2*number2);
            return result;
        }

        static double VolumenWuerfel(string zahl)
        {
            double number = Convert.ToDouble(zahl);
            double result = number*number*number;
            return result; 
        }

        static double VolumenQuader(string zahl1, string zahl2, string zahl3)
        {
            double number1 = Convert.ToDouble(zahl1);
            double number2 = Convert.ToDouble(zahl2);
            double number3 = Convert.ToDouble(zahl3);
            double result = number1*number2*number3;
            return result;
        }
    }
} 

            
         


