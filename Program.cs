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
namespace HelloWorld
{
    class Programm
    {
        static void Main(string[] args)
        {   
            var arr1 = new[] {3, 9, 2, 8, 6, 5};
            List<int> arr2 = new List<int>();
            Func<int, int> squareF = (x) => x*x;
            
            foreach(int num in arr1)
            {
                int result = squareF(num);
                if (result >20)
                {
                    arr2.Add(result);
                }
            } 
            arr2.ForEach(Console.WriteLine);
        } 
             
    }
}