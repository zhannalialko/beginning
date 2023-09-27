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
            List<int> numbers = new List<int>(){1, 2, 3, 4, 5, 6, 7, 8, 9};
            List<int> evenNumbers = numbers.FindAll(x => (x%2) == 0);

            foreach(int num in evenNumbers)
            {
                Console.WriteLine(num);
            } 
        } 
             
    }
}