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
namespace HelloWorld
{
    class Programm
    {
        static void Main(string[] args)
        {
            List<int> zahlen = new List<int>() {45, 65, 34, 89, 99}; 
            int summeFromMethod = Sum(zahlen);
            Console.WriteLine(summeFromMethod);
        }

        static int Sum(List<int> toCalculate)
        {
            int result = 0;
            foreach(int value in toCalculate)
            {
               result += value; 
            }
            return result;
        }
    }
} 

            
         


