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
           //Frage den Nutzer wieviele Texte er in einem Array speichern will.
            //Initalisiere das Array in der gewünschten größe
            
            //Lasse den Nutzer das Array nacheinander mit Texten befüllen.
            //Gebe die Texte mit mindestens 20 Zeichen aus, fülle den Text mit Leerzeichen auf von Links wenn kleiner. 

            Console.WriteLine("wie viele Texte willst du in einem Array speichern?");
            int texts = Convert.ToInt16(Console.ReadLine());

            string[] myText = new string[texts];

            for(int i=0; i<texts; i++)
            {
                string text1 = Console.ReadLine();
                myText[i] = text1;
            }

            foreach(string item in myText)
            {
                Console.WriteLine(item.PadLeft(20, ' '));
            }
        }
    }
    
}




