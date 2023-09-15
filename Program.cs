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

        Console.WriteLine("Schreib eine Zahl");
        string numero1 = Console.ReadLine();

        Console.WriteLine("Schreib andere Zahl");
        string numero2 = Console.ReadLine();

        string operators ="";

        do
        {
            Console.WriteLine("Schreib den operator (+, -, *, / oder %)");
            operators = Console.ReadLine();
        } while(operators != "+" && operators != "-" && operators != "*" && operators != "/" && operators != "%");
        
        switch(operators)
        {
            case "+":
                int ergebnis = AdditionWithReturn(numero1, numero2);
                break;
            case "-":
                Substract(numero1, numero2);
                break;
            case "*":
                Multiplikation(numero1, numero2);
                break;
             case "/":
                Division(numero1, numero2);
                break;
            case "%":
                Teil(numero1, numero2);
                break;
            default:
                Console.WriteLine("Ich kenne diesen Operator nicht");
                 break;
        }

        }
        static int AdditionWithReturn(string zahl1, string zahl2)
        {
            int numero1 = Convert.ToInt32(zahl1);
            int numero2 = Convert.ToInt32(zahl2);
            return numero1 + numero2;
        }
        
        static void Addition(string zahl1, string zahl2)
        {
            int numero1 = Convert.ToInt32(zahl1);
            int numero2 = Convert.ToInt32(zahl2);
            Console.WriteLine(numero1 + numero2);
        }
        
        static void Substract(string zahl1, string zahl2)
        {
            int numero1 = Convert.ToInt32(zahl1);
            int numero2 = Convert.ToInt32(zahl2);
            Console.WriteLine(numero1 - numero2);
        }
        
        static void Multiplikation(string zahl1, string zahl2)
        {
            int numero1 = Convert.ToInt32(zahl1);
            int numero2 = Convert.ToInt32(zahl2);
            Console.WriteLine(numero1 * numero2);
        }

        static void Division(string zahl1, string zahl2)
        {
            int numero1 = Convert.ToInt32(zahl1);
            int numero2 = Convert.ToInt32(zahl2);
            Console.WriteLine(numero1 / numero2);
        }
        static void Teil(string zahl1, string zahl2)
        {
            int numero1 = Convert.ToInt32(zahl1);
            int numero2 = Convert.ToInt32(zahl2);
            Console.WriteLine(numero1 % numero2);
        }

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
        
    }
}



