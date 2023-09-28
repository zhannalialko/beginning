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
using System.Collections.Immutable;
using System.Runtime.InteropServices;
namespace HelloWorld
{
    class Programm
    {
        static void Main(string[] args)
        { 
            var set1 = new string[] { "X", "Y", "Z" }; 
            var set2 = new int[] { 1, 2, 3 };

            var set3 = Array.ConvertAll(set2, x=>x.ToString());

            for(int i=0; i<set1.Length; i++)
            {
                    var result = set1[i] + set3[i].ToString();

                        Console.WriteLine(result);
            }

        }
                         
    }
}