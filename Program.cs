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
namespace HelloWorld
{
    class Programm
    {
        static void Main(string[] args)
        {   
           Auto auto1 = new Auto();
           auto1.Color = "red";
           auto1.Geschwindigkeit = 40;
           auto1.motorLauf = true;
           auto1.Gang = 2;
           auto1.Räder = 5;
           auto1.Türen = 4;
           auto1.Klasse = 1;
           
           
           Auto auto2 = new Auto();
           auto2.Color = "blue";
           auto2.Geschwindigkeit = 0;
           auto2.motorLauf = false;
           auto2.Gang = 1;
           auto2.Räder = 4;
           auto2.Türen = 2;
           auto2.Klasse = 2;


           auto1.GiveMeYourColor();
           auto1.WelcheGeschwindigkeit();
           Console.WriteLine(auto1.ToString());
           auto2.GiveMeYourColor();
           auto2.WelcheGeschwindigkeit();
           Console.WriteLine(auto2.ToString());
           auto1.Fahren();
           auto1.Bremsen();
           auto1.Fahren();
        }
    }

    public class Auto
    {
        public int Geschwindigkeit {get;set;}
        public bool motorLauf {get;set;}

        public int Gang{get;set;}

        public string Color {get; set;}

        public int Klasse{get;set;}

        public int Türen{get;set;}

        public int Räder{get;set;}


        
        public override string ToString()
        {
            return $"Klasse:{Klasse}, Räder:{Räder}, Türen:{Türen}, Color:{Color}".ToString();
        }
    
        public void GiveMeYourColor()
        {
            Console.WriteLine($"My Color is: {Color}" );
        }

        public void WelcheGeschwindigkeit()
        {
            Console.WriteLine($"My speed is {Geschwindigkeit}");
        }

        public void Start()
        {
            if(motorLauf == false)
            {
                motorLauf = true;
                Console.WriteLine($"the car gets started");
            }
             else
            {
                Console.WriteLine("the car has already started");
            }   
        }

        public void Stop()
        {
            if(motorLauf == true)
            {
                motorLauf = false;
                Console.WriteLine($"the car gets stopped");
            }
             else
            {
                Console.WriteLine("the car has already stopped");
            }   
        }

        public void SpeedUp()
        {
            if(motorLauf == true)
            {
                Geschwindigkeit +=10;
                Console.WriteLine($"We speed up to {Geschwindigkeit}");
                int Gang1 = Gang++;
                Console.WriteLine($"Gear has changed from {Gang1} to {Gang}");  
            }
            else
            {
                Console.WriteLine("We cannot speed up");
                Console.WriteLine("Gear cannot change");
            }
            
        }

        public void Break()
        {

        if(motorLauf == true && Gang !=0)
        {
            Geschwindigkeit -=10;
            Console.WriteLine($"We break up to {Geschwindigkeit}");
            int Gang1 = Gang--;
            Console.WriteLine($"Gear has changed from {Gang1} to {Gang}");
        }
         else
        {
            Console.WriteLine("We cannot break");
            Console.WriteLine("Gear cannot change");
        }
        }

        public void Fahren()
        {
            if(motorLauf == true)
            {
                Console.WriteLine("Das Auto fährt");
            }
            else
            {
                Console.WriteLine("Das Auto fährt nicht");
            }
        }
            public void Bremsen()
        {
            if(motorLauf == false)
            {
                Console.WriteLine("Das Auto steht");
            }
            else
            {
                motorLauf = false;
                Console.WriteLine("Das Auto hat gebremst");
            }
        }
    }
}