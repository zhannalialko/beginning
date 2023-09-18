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
            string miss = "MissiSsiPpi";
            miss = miss.ToLower();

            foreach(char item in miss)
            {    
                Console.WriteLine($" {item} = {miss.Count(c => c== item)}");
            }
            Console.WriteLine ("---------");

            char p = 'p';
            char m = 'm';
            char i = 'i';
            char s = 's';
            Console.WriteLine($" {p} = {miss.Count(c => c == p)}");
            Console.WriteLine($" {m} = {miss.Count(c => c == m)}");
            Console.WriteLine($" {i} = {miss.Count(c => c == i)}");
            Console.WriteLine($" {s} = {miss.Count(c => c == s)}");
        
        }

    }
    
}




