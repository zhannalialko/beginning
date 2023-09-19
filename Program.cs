using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Numerics;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;
namespace HelloWorld
{
    class Programm
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[] {20, 50, 11, 2, 49};

            foreach(int i in myArray)
            {
                Console.Write($"{i} ");
                Console.Write(" ");
            }

            Console.WriteLine("");

            var myArray1 = myArray.Reverse();
            foreach(int i in myArray1)
            {
                Console.Write($"{i} ");
                Console.Write(" ");
            }

            Console.WriteLine("");

            Array.Sort(myArray);
            foreach(int i in myArray)
            {
                Console.Write($"{i} ");
                Console.Write(" ");
            }

            Console.WriteLine("");
            
            Array.Sort(myArray);
            Array.Reverse(myArray);
            foreach(int i in myArray)
            {
                Console.Write($"{i} ");
                Console.Write(" ");
            }

        }
    }
    
}




