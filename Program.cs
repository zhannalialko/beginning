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
            Console.WriteLine("Schreib die erste Zahl");
            int zahl1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Schreib die zweite Zahl");
            int zahl2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Schreib den Operator");
            string operators = Console.ReadLine();
            
            switch(operators)
            {
                case "+":
                {
                    Console.WriteLine(zahl1 + zahl2);
                    break;
                }
                case "-":
                {
                    Console.WriteLine(zahl1 - zahl2);
                    break;
                }
                case "*":
                {
                    Console.WriteLine(zahl1*zahl2);
                    break;
                }
                case "/":
                {
                    if(zahl2!=0)
                    {
                        Console.WriteLine(zahl1/zahl2);
                    }
                    else
                    {
                        Console.WriteLine("Kaputt");
                    }
                break;
                    }
                case "%":
                {
                    if(zahl2!=0)
                    {
                        Console.WriteLine(zahl1/zahl2);
                    }
                    else
                    {
                        Console.WriteLine("Kaputt");
                    }
                    break;
                }

            }

        }    
    }
} 

            
         


