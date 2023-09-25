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
            Console.WriteLine("___1___");

            myList.ForEach(Console.WriteLine);
            
            Console.WriteLine("___2___");
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
            Console.WriteLine("___3___");

            foreach(int item in myList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("___4___");

            myList.Insert(2, 99);

            myList.ForEach(Console.WriteLine);
            Console.WriteLine("___5___");

            myList.AddRange(new int []
                {
                91,92,93});

            myList.ForEach(Console.WriteLine);
            Console.WriteLine("___6___");

            myList.RemoveAt(0);
            myList.ForEach(Console.WriteLine);
            Console.WriteLine("___7___");

            myList.Remove(99);
            myList.ForEach(Console.WriteLine);
            Console.WriteLine("___8___");

            myList.RemoveAt(myList.Count -1);
            myList.ForEach(Console.WriteLine);
            Console.WriteLine("___9___");

            myList.Sort();
            myList.ForEach(Console.WriteLine);
            Console.WriteLine("___9___");

            myList.Reverse();
            myList.ForEach(Console.WriteLine);
            Console.WriteLine("___9___");

            Console.WriteLine(myList.Contains(2));
            Console.WriteLine("___10___");

            for(int item = 0; item < myList.Count; item++)
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

            
         


