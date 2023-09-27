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
            string[] arr1 = { "aaa.frx", "bbb.TXT", "xyz.dbf","abc.pdf",
             "aaaa.PDF","xyz.frt", "abc.xml", "ccc.txt", "zzz.txt" };
            
            
            var arr2 = arr1.Select(s => s.Split('.')[1].ToLower()).GroupBy(g => g);
            

            foreach(var item in arr2)
            {
                Console.WriteLine($"{item.Count()} File(s) with {item.Key} Extension");
            }
                      
        } 
         
             
    }
}