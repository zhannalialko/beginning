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
           Console.WriteLine("Gib eine Zahl");
           int eingabe = Convert.ToInt32(Console.ReadLine());

            
            for(; eingabe>=0; eingabe--)
            {
                Console.WriteLine(eingabe);
            }

            while(eingabe>0)
            {
                Console.WriteLine(eingabe);
                eingabe--;
            }
        
        }

    }
    
}




