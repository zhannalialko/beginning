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
            List<int> myList = new List<int>(){5,3,7};
            myList.ForEach(Console.WriteLine);

            Console.WriteLine("Schreib andere Zahlen, zu Aufhören schreib bitte 0");

            while(true)
            {
                string eingabeText = Console.ReadLine();
                if(eingabeText == "")
                {
                    break;
                }
                int zahlEingabe = Convert.ToInt32(eingabeText);
                 myList.Add(zahlEingabe);
            }
            
            foreach(int item in myList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("______________");

            myList.Insert(2, 99);

            myList.ForEach(Console.WriteLine);
            Console.WriteLine("______________");

            myList.AddRange(new int []
                {
                91,92,93});

            myList.ForEach(Console.WriteLine);
            Console.WriteLine("______________");

            myList.RemoveAt(0);
            myList.ForEach(Console.WriteLine);
            Console.WriteLine("______________");

            myList.Remove(99);
            myList.ForEach(Console.WriteLine);
            Console.WriteLine("______________");

            myList.RemoveAt(myList.Count -1);
            myList.ForEach(Console.WriteLine);
            Console.WriteLine("______________");

            myList.Sort();
            myList.ForEach(Console.WriteLine);
            Console.WriteLine("______________");

            myList.Reverse();
            myList.ForEach(Console.WriteLine);
            Console.WriteLine("______________");

            myList.Contains(2);

            for(int item =0; item <myList.Count; item++)
            {
                if(myList[item] > 80)
                {
                    myList.RemoveAt(item);
                    item--;
                }
            }
            myList.ForEach(Console.WriteLine);
        }    
    }
} 

            
         


