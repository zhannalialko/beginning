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
                    Console.WriteLine(a + b);
                    break;
                case "-":
                    Console.WriteLine(a - b);
                    break;
                case "*":
                    Console.WriteLine(a * b);
                    break;
                case "/":
                    Console.WriteLine(a / b);
                    break;
                case "%":
                    Console.WriteLine(a % b);
                    break;
                default:
                    Console.WriteLine("Ich kenne diesen Operator nicht");
                    break;

            }
        }
    }
}



