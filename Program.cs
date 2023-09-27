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
            Console.WriteLine("Schreib den Satz mit UPPERCASE Wörter");
            string eingabe = Console.ReadLine();

            var uppercasewords = eingabe.Split(' ').Where(w => w == w.ToUpper());

            foreach(var item in uppercasewords)
            {
                Console.Write(item);
            } 
        } 
             
    }
}