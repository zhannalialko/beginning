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
namespace HelloWorld
{
    class Programm
    {
        static void Main(string[] args)
        {
            int initialmoney = 10000;
            int endKapital = initialmoney;
            int initialrate = 10;
            int anzahl = 0;

            while(endKapital > 0 && anzahl < 20)
            {
                Random random = new Random();
                int game = random.Next(0,37);
                int ergebnis = Games(initialmoney, game, initialrate);
                int rate = Gamerate(initialmoney, ergebnis, initialrate);
                
                for(int i = 0; i < 20; i ++)
                {
                    ergebnis = Games(ergebnis, game, rate);
                    endKapital = ergebnis;
                }
                anzahl++;
                Console.WriteLine($"Anzahl des Spieles {anzahl}, die geworfene Zahl {game}, Kapital davor {initialmoney}, Kapital danach {endKapital}");
            }
        }   

        static int Games(int money, int number, int rate)
        
        {
            if (number %2 == 0) 
            {
                return money + (rate*2);
            }
            else
            {
                return money - rate;
            }
        }

        static int Gamerate(int startMoney, int endMoney, int rates)
        {
            
            switch(endMoney)
            {
                case >=10000:
                {
                    if(endMoney<startMoney)
                    {
                        rates *=2;
                    }
                    return rates;
                }
                    
                case <10000:
                {
                    return rates *=2;
                }

            }
            
        }
      
    }
    
}




