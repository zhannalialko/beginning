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
namespace HelloWorld
{
    class Programm
    {
        static void Main(string[] args)
        {  
            List<Students> stulist = new List<Students>(); 
            stulist.Add(new Students { StuId = 1, StuName = " Joseph ", GrPoint = 800 });
            stulist.Add(new Students { StuId = 2, StuName = "Alex", GrPoint = 458 }); 
            stulist.Add(new Students { StuId = 3, StuName = "Harris", GrPoint = 900 }); 
            stulist.Add(new Students { StuId = 4, StuName = "Taylor", GrPoint = 900 }); 
            stulist.Add(new Students { StuId = 5, StuName = "Smith", GrPoint = 458 }); 
            stulist.Add(new Students { StuId = 6, StuName = "Natasa", GrPoint = 700 }); 
            stulist.Add(new Students { StuId = 7, StuName = "David", GrPoint = 750 }); 
            stulist.Add(new Students { StuId = 8, StuName = "Harry", GrPoint = 700 }); 
            stulist.Add(new Students { StuId = 9, StuName = "Nicolash", GrPoint = 597 });
            stulist.Add(new Students { StuId = 10, StuName = "Jenny", GrPoint = 750 });

            Console.WriteLine("Schreib den Zahl von 1 bis 6");
            int zahl = Convert.ToInt16(Console.ReadLine()); 
            var groups = stulist.OrderByDescending(g => g.GrPoint)
                                .GroupBy(g => g.GrPoint).ToList();

            var entry = groups[zahl-1];
            foreach(Students s in entry)
            {
                Console.WriteLine(s.StuName);
            }          
        } 
          
        public class Students 
        { 
            public string StuName { get; set; } 
            public int GrPoint { get; set; } 
            public int StuId { get; set; } 
        } 
             
    }
}