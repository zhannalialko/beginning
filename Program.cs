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
        static void Addition(int zahl1, int zahl2)
        {
            Console.WriteLine(zahl1 + zahl2);
        }
        static void Substract(int zahl1, int zahl2)
        {
            Console.WriteLine(zahl1 - zahl2);
        }  
        static void Multiplikation(int zahl1, int zahl2)
        {
            Console.WriteLine(zahl1 * zahl2);
        }  
        static void Division(int zahl1, int zahl2)
        {
            Console.WriteLine(zahl1 / zahl2);
        }
        static void Teil(int zahl1, int zahl2)
        {
            Console.WriteLine(zahl1 % zahl2);
        }
        
        
        int a = 10;
        Console.WriteLine(a);
        int b = 20;
        Console.WriteLine(b);
        string operators ="";

        do
        {
            Console.WriteLine("Schreib den operator (+, -, *, / oder %)");
            operators = Console.ReadLine();
        } while(operators != "+" && operators != "-" && operators != "*" && operators != "/" && operators != "%");
        
        switch(operators)
        {
            case "+":
                Addition(a, b);
                break;
            case "-":
                Substract(a, b);
                break;
            case "*":
                Multiplikation(a, b);
                break;
             case "/":
                Division(a, b);
                break;
            case "%":
                Teil(a, b);
                break;
            default:
                Console.WriteLine("Ich kenne diesen Operator nicht");
                 break;
        }
        }
        
    }
}



