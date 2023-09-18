using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
           Console.WriteLine("Schreib einen Text");
           string eingabe = Console.ReadLine();

           Console.WriteLine($"the length of the text is {eingabe.Length}");

           char ch = 'h';

           int freq = eingabe.Split(ch).Length - 1;
           Console.WriteLine($"there are {freq} h's");

           int count = 0;
           int count1 = 0;
           for(int i=0; i<eingabe.Length; i++)
           {
                if(eingabe[i] == 'h')
                {
                    count ++;
                }
           }

           Console.WriteLine($"Es gibt {count} h's in den Text");

           foreach(char c in eingabe)
           {
                if(c == 'h')
                {
                    count1 ++;
                }
            }
            Console.WriteLine($"Es gibt {count1} h's in den Text");

            int numberofh = eingabe.Count(c => c == 'h');

            Console.WriteLine($"Es gibt {numberofh} h's in den Text");

        }

    }
    
}




