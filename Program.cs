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
            string[] myH = myAquarium.myHeigth(myAquarium.heigth);
            foreach(var item in myH)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new string(myAquarium.width, 50));
        }

        class Aquarium
        {
            public string heigth;

            public char width;
            public Aquarium()
            {
                heigth = "|                                                |";
                width = '-';
            } 
            
            public string [] myHeigth (string str)
            {
                string [] newstr = new string[10];
                for(int i=0; i<newstr.Length; i++)
                {
                    newstr[i] = str;
                }
                return newstr;
            }
            
        }

    }
}