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
           List<string> listOfString = new List<string>(); 
           listOfString.Add("m"); 
           listOfString.Add("n"); 
           listOfString.Add("o"); 
           listOfString.Add("p"); 
           listOfString.Add("q"); 
            
           var badO = listOfString
                        .Where(a => a == "o")
                        .FirstOrDefault();
                        
        listOfString = Removing(listOfString, badO);

        listOfString.ForEach(Console.WriteLine);


        static List<string> Removing(List<string> str, string item)
        {
            if(item !=  null)
            {
                str.Remove(item);
                return str;
            }
            else{
                return str;
            }
        }
    
    }
                         
    }
}