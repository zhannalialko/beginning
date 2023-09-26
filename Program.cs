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
    }
}