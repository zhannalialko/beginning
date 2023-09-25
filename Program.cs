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
namespace HelloWorld
{
    class Programm
    {
        static void Main(string[] args)
        {
            string filepath = "C:/TraineeOffice/fff/copy_data.csv";
            string filepath2 = "C:/TraineeOffice/fff/New Text Document.csv";
            FileInfo f1 = new FileInfo(filepath);
            FileInfo f2 = new FileInfo(filepath2);
            
            if(f1.Exists)
            {
                StreamReader reader = new StreamReader(filepath, Encoding.UTF8);
                List<string[]> myList = new List<string[]>();
                reader.ReadLine();
                while(!reader.EndOfStream)
                {
                    myList.Add(reader.ReadLine().Split(';'));
                }
                Console.WriteLine(myList[0]);
                Console.WriteLine(myList.Count);

                
                int endAlter = 100;
                for(int alter = 18; alter<=endAlter; alter++ )
                {
                    Console.WriteLine("Aktuell bin ich bei Alter:" + alter);
                    List<string[]> gefilterteEintraege =  myList
                                    .Where(w => Convert.ToInt32(w[2]) == alter)
                                    .ToList();
                    using(StreamWriter writer = new StreamWriter($"C:/TraineeOffice/fff/New Text Document{alter}.csv", true, Encoding.UTF8))
                    {
                        foreach(string[] entry in gefilterteEintraege)
                        {
                            writer.WriteLine(string.Join('\t', entry));
                        }
                    }
                }

            }    
            else
            {
                Console.WriteLine("Diese Datei existiert nicht");
            }


         
        } 
        
    }
} 

            
         


