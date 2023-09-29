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
            char[,] superAquarium = myAquarium.AquariumBuilder();
            Fish victim = new Fish();
            Fish victim1 = new Fish();
            char[,] victimInAquarium = victim.FishinAquarium(superAquarium, victim.carp, victim.reversedcarp, 16, 5);
            victimInAquarium = victim1.FishinAquarium(superAquarium, victim.shark, victim.reversedshark, 17, 5);

            for(int i=0; i<victimInAquarium.GetLength(0); i++)
            {
                for(int j=0; j<victimInAquarium.GetLength(1); j++)
                {
                    Console.WriteLine(victimInAquarium[i,j]);
                }
            }

        Thread.Sleep(millisecondsTimeout: 100);
        }

        class Aquarium
        {
            public char heigth;
            public char angle;
            public char width;
            
            public char[,] AquariumBuilder()
            {
                heigth = '|';
                width = '-';
                angle = '+';
                char [] myHeigth = new char[10];
                for(int i=0; i<myHeigth.Length; i++)
                    myHeigth[i] = heigth;

                string result = "";
                char[] superresult = new char[]{};
                char empty = ' ';
                var emptiness = string.Empty.PadRight(50, empty);
                
                       
            for(int i=0; i<myHeigth.Length; i++)
            {
                result = myHeigth[i].ToString() + emptiness + myHeigth[i].ToString();
            }
            superresult = result.ToCharArray();
            

            char[,] superAquarium = new char [10,52];

            
            for(int i = 0; i<superAquarium.GetLength(0); i++)
            {
                for(int k = 0; k<superAquarium.GetLength(1); k++)
                {
                    superAquarium[i,k] = superresult[k];
                }
            }
            return superAquarium;
            }
        }
        class Fish : Aquarium
        {
            public string carp;
            public string reversedcarp;
            public string shark;
            public string reversedshark;
            public string blowfish;
            public string reversedblowfish;
            public string swordfish;
            public string reversedswordfish;

            public Fish()
            {
                carp = "<><";
                reversedcarp = "><>";
                shark = "<<///====><";
                reversedshark = "><====///>>";
                blowfish = "<()><";
                reversedblowfish = "><()>";
                swordfish = "-<><";
                reversedswordfish = "><>-";
            }

            public char[,] FishinAquarium(char[,] aquarium, string fish, string reverse, int j, int o)
            {
            int m = j + fish.Length;
            char empty = ' ';
            width = '-';
            angle = '+';

            while(j!=0 && m!=3)
            {
                if(j%4==0)
                {
                    o++;
                    j--;
                }
                else if(j%2==0)
                {
                    o--;
                    j--;
                }
                else
                {
                    j--;
                }
                for(int l=0; l<fish.Length; l++)
                {
                    aquarium[o,j+l] = empty;
                    aquarium[o, m] = empty;  
                }

                for(int l=0; l<fish.Length; l++)
                {
                    aquarium[o,j+l] = fish[l];
                    aquarium[o, m] = empty;  
                }
                
                for(int i = 0; i<aquarium.GetLength(0); i++)
                    {
                        for(int k = 0; k<aquarium.GetLength(1); k++)
                        {
                            Console.Write(aquarium[i,k]);
                        }
                        Console.WriteLine();
                    }
                Console.Write(angle);
                Console.Write(new string(width, 50));
                Console.WriteLine(angle);
                

                for(int l=0; l<fish.Length; l++)
                {
                    aquarium[o,j+l] = empty;
                    aquarium[o, m] = empty;  
                }

                j--;
                m--;

            }
            
            if(j==1 && m==4)
            {
                j +=2;
                m -=2;
            }

                while(j!=48 && m!=46)
                {
                    if(j%4==0)
                    {
                        o++;
                        j++;
                    }
                    else if(j%2==0)
                    {
                        o--;
                        j++;
                    }
                    else
                    {
                        j++;
                    }
                    
                    for(int l=0; l<reverse.Length; l++)
                    {
                        aquarium[o,j+l] = empty;
                        aquarium[o, m] = empty;
                    }   
                    for(int l=0; l<reverse.Length; l++)
                    {
                        aquarium[o,j+l] = reverse[l];
                        aquarium[o, m] = empty;
                    }   

                    for(int i = 0; i<aquarium.GetLength(0); i++)
                    {
                        for(int k = 0; k<aquarium.GetLength(1); k++)
                        {
                            Console.Write(aquarium[i,k]);
                        }
                        Console.WriteLine();
                    }
                Console.Write(angle);
                Console.Write(new string(width, 50));
                Console.WriteLine(angle);
                    
                    for(int l=0; l<reverse.Length; l++)
                    {
                        aquarium[o,j+l] = empty;
                        aquarium[o, m] = empty;
                    }
                    j++;
                    m++;
                }
                return aquarium; 
            }
            
            
        }   

    }
}