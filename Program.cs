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
namespace HelloWorld
{
    class Programm
    {
        static void Main(string[] args)
        {   
            Quadrat figure1 = new Quadrat();
            figure1.laenge = 4;

            Console.WriteLine(figure1.Umfang());
            Console.WriteLine(figure1.Flaeche());

            Rechteck figure2 = new Rechteck();
            figure2.laenge = 5;
            figure2.breite = 4;

            Console.WriteLine(figure2.Umfang());
            Console.WriteLine(figure2.Flaeche());

            Dreieck figure3 = new Dreieck();
            figure3.a = 3;
            figure3.b = 4;
            figure3.c = 5;
            figure3.hoehe = 4;

            Console.WriteLine(figure3.Umfang());
            Console.WriteLine(figure3.Flaeche());
        }

        public class Quadrat
        {
            public int laenge{get;set;}

            public int Umfang()
            {
                int ergebnis = 4*laenge;
                return ergebnis;
            }

            public int Flaeche()
            {
                int ergebnis = laenge*laenge;
                return ergebnis;
            }
        } 

        public class Rechteck
        {
            public int breite {get;set;}
            public int laenge{get;set;}

            public int Umfang()
            {
                int ergebnis = 2*laenge + 2*breite;
                return ergebnis;
            }

            public int Flaeche()
            {
                int ergebnis = breite*laenge;
                return ergebnis;
            }
            
        }

        public class Dreieck
        {
            public int a {get;set;}
            public int b {get;set;}
            public int c {get;set;}

            public int hoehe {get;set;}


            public int Umfang()
            {
                int ergebnis = a + b + c;
                return ergebnis;
            }

            public int Flaeche()
            {
                int ergebnis = a * hoehe / 2;
                return ergebnis;
            }
        }      
    }
}