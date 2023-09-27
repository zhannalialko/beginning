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
using System.IO;
using System.Text;
using System.Dynamic;
using System.Reflection.Metadata.Ecma335;
using System.Drawing;
using System.Net.Http.Headers;
using System.Xml.Schema;
using System.Security.Cryptography;
namespace HelloWorld
{
    class Programm
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Wie viele Anträge möchtest du hinzufügen?");
            int zahl = Convert.ToInt32(Console.ReadLine());
            int [] numbers = new int[zahl];
            int [] result = new int[zahl];

            for(int i = 0; i <numbers.Length; i++)
            {
                Console.WriteLine("Schreib eine Zahl");
                int wert = Convert.ToInt32(Console.ReadLine());
                result[i] = wert;
            }
            
            Console.WriteLine("Schreib eine durchnittliche Zahl");
            int durchnitt = Convert.ToInt32(Console.ReadLine());

            var ergebnis = result.Where(x => x>durchnitt).ToArray();

                foreach(int item in ergebnis)
                {
                    Console.Write($" {item} ");
                } 
        } 
             
    }
}