﻿using System.ComponentModel;
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
namespace HelloWorld
{
    class Programm
    {
        static void Main(string[] args)
        {   
            string[] cities = { "ROME","LONDON","NAIROBI","CALIFORNIA","ZURICH","NEW DELHI","AMSTERDAM","ABU DHABI", "PARIS" };
            
            for(int i = 0; i< cities.Length; i++)
            {
                Console.WriteLine($"{cities[i]} => {cities[i].First()} and {cities[i].Last()}");
            }
            
                
            
        } 
             
    }
}