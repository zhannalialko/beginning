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
using System.IO;
using System.Text;
using System.Dynamic;
using System.Reflection.Metadata.Ecma335;
using System.Drawing;
using System.Net.Http.Headers;
using System.Xml.Schema;
using System.Security.Cryptography;
using System.Collections.Immutable;
using System.Runtime.InteropServices;
namespace HelloWorld
{
    class Programm
    {
        static void Main(string[] args)
        { 
            Aquarium myAquarium = new Aquarium();
            Fish victim = new Fish();
            

            char[] arr = new char[] {};
            arr = myAquarium.myHeigth(myAquarium.heigth);
            string result = "";
            char[] superresult = new char[]{};
            char empty = ' ';
            var emptiness = string.Empty.PadRight(50, empty);

                       
            for(int i=0; i<arr.Length; i++)
            {
                result = arr[i].ToString() + emptiness + arr[i].ToString();
            }
            superresult = result.ToCharArray();
            int j = 0;


            /*while(j < 10)
            {
                for(int i = 0; i<superresult.Length; i++)
                {
                    Console.Write(superresult[i]);
                }
                Console.WriteLine();
                j++;
            }
            */
            char[,] superAquarium = new char [10,52];

            
            for(int i = 0; i<superAquarium.GetLength(0); i++)
            {
                for(int k = 0; k<superAquarium.GetLength(1); k++)
                {
                    superAquarium[i,k] = superresult[k];
                    Console.Write(superAquarium[i,k]);
                }
                Console.WriteLine();
            }
            
            for(int k=0; k<superAquarium.GetLength(1); k++)
            {
                for(int i = 0; i<victim.carp.Length; i++)
                {
                    superAquarium[5,k] = victim.carp[0];
                    superAquarium[5,k] = victim.carp[1];
                    superAquarium[5,k] = victim.carp[2];
                }
            }

            Thread.Sleep(millisecondsTimeout: 100);
           
            for(int i = 0; i<superAquarium.GetLength(0); i++)
            {
                for(int k = 0; k<superAquarium.GetLength(1); k++)
                {
                    Console.Write(superAquarium[i,k]);
                }
                Console.WriteLine();
            }

            Console.Write(myAquarium.ecke);
            Console.Write(new string(myAquarium.width, 50));
            Console.WriteLine(myAquarium.ecke);
  
        }

        class Aquarium
        {
            public char heigth;
            public char ecke;
            public char width;
            public Aquarium()
            {
                heigth = '|';
                width = '-';
                ecke = '+';
            } 

            public char [] myHeigth (char str)
            {
                char [] newchar = new char[10];
                for(int i=0; i<newchar.Length; i++)
                    newchar[i] = str;
                return newchar;
            }
        }
        class Fish : Aquarium
        {
            public string carp;
            public string shark;
            public string blowfish;
            public string swordfish;

            public Fish()
            {
                carp = "<><";
                shark = "<<///====><";
                blowfish = "<()><";
                swordfish = "-<><";
            }
        }
           

    }
}