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
namespace HelloWorld
{
    class Programm
    {
        static void Main(string[] args)
        {   
           string[,] my2dimArray = new string[5,5];
           
           for(int i = 0; i<my2dimArray.GetLength(0); i++)
           {
                for(int j = 0; j<my2dimArray.GetLength(1); j++)
                {
                    Random r = new Random();
                    string number = Convert.ToString(r.Next(1,10));
                    Console.Write(number, my2dimArray[i,j]);
                }
                Console.WriteLine();
           }
        } 
             
    }
}