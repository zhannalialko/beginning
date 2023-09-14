using System.ComponentModel.DataAnnotations;
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
            Console.WriteLine("Gib mir eine Zahl");
            string eingabe = Console.ReadLine();

            int zahl = Convert.ToInt16(eingabe);
            int i = 1;
            var reihe = new List<int> {};

            while (i < zahl)
            {
                foreach(var item in reihe)
                {
                    
                    Console.WriteLine(item);
                    if(item%3==0)
                    {
                        Console.WriteLine("Fizz");
                    }
                    else if(item%5==0)
                    {
                        Console.WriteLine("Buzz");
                    }
                    else if (item %3==0 && i%5==0)
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                }
                foreach(var item in reihe)
                {
                    reihe.Add(i);
                }
                i++;
            }

        }
    }
}



