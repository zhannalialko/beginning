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
using System.Diagnostics.Contracts;
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
            int j = 16;
            int m = 19;
            int o = 5;
            int z = 0;

            char[,] superAquarium = new char [10,52];

            
            for(int i = 0; i<superAquarium.GetLength(0); i++)
            {
                for(int k = 0; k<superAquarium.GetLength(1); k++)
                {
                    superAquarium[i,k] = superresult[k];
                }
            }
            
            while(j!=0 && m!=3)
            {
                if(j%4==0)
                {
                    o++;
                    j--;
                    m--;
                }
                else if(j%2==0)
                {
                    o--;
                    j--;
                    m--;
                }
                else
                {
                    j--;
                    m--;
                }
                for(int l=0; l<victim.carp.Length; l++)
                {
                    superAquarium[o,j+l] = empty;
                    superAquarium[o, m] = empty;  
                }

                for(int l=0; l<victim.carp.Length; l++)
                {
                    superAquarium[o,j+l] = victim.carp[l];
                    superAquarium[o, m] = empty;  
                }
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
                

                for(int l=0; l<victim.carp.Length; l++)
                {
                    superAquarium[o,j+l] = empty;
                    superAquarium[o, m] = empty;  
                }

                j--;
                m--;

            }
            
            if(j==0 && m==3)
            {
                j +=2;
                m -=2;
            }

                while(j!=49 && m!=47)
                {
                    if(j%4==0)
                    {
                        o++;
                        j++;
                        m++;
                    }
                    else if(j%2==0)
                    {
                        o--;
                        j++;
                        m++;
                    }
                    else
                    {
                        j++;
                        m++;
                    }
                    
                    for(int l=0; l<victim.reversedcarp.Length; l++)
                    {
                        superAquarium[o,j+l] = empty;
                        superAquarium[o, m] = empty;
                    }   
                    for(int l=0; l<victim.reversedcarp.Length; l++)
                    {
                        superAquarium[o,j+l] = victim.reversedcarp[l];
                        superAquarium[o, m] = empty;
                    }   

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
                    
                    for(int l=0; l<victim.reversedcarp.Length; l++)
                    {
                        superAquarium[o,j+l] = empty;
                        superAquarium[o, m] = empty;
                    }
                    j++;
                    m++;
                } 
            
            /*
            while(j!=49 && m!=51) 
            {
                
                for(int l=0; l<=victim.carp.Length; l++)
                {
                    superAquarium[5,m+l] = victim.carp[l];
                    superAquarium[5, j] = empty;
                }  

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
  
                j++;
                m++;   
            }
          */
        Thread.Sleep(millisecondsTimeout: 100);
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
            public string reversedcarp;
            public string shark;
            public string blowfish;
            public string swordfish;

            public Fish()
            {
                carp = "<><";
                reversedcarp = "><>";
                shark = "<<///====><";
                blowfish = "<()><";
                swordfish = "-<><";
            }
        }
           

    }
}