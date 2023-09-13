using System.Reflection.PortableExecutable;
﻿namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
             //Frage den Nutzer nach der ersten Zahl
            Console.WriteLine("Gebe uns deine erste Zahl!");
            string eingabe1 = Console.ReadLine();

            //Frage den Nutzer nach der zweiten Zahl
            Console.WriteLine("Gebe uns deine zweite Zahl!");
            string eingabe2 = Console.ReadLine();
            
            //Frage den Nutzer nach der dritten Zahl
            Console.WriteLine("Gebe uns deine dritte Zahl!");
            string eingabe3 = Console.ReadLine();

            //Gebe das Ergebnis auf der Console aus
            int zahl1 = Convert.ToInt16(eingabe1);
            int zahl2 = Convert.ToInt16(eingabe2);
            int zahl3 = Convert.ToInt16(eingabe3);

            int ergebnis1 = zahl1+zahl2;
            Console.WriteLine($"Das Ergebnis aus {zahl1} + {zahl2} = {ergebnis1}");

            int ergebnis2 = zahl1-zahl2;
            Console.WriteLine($"Das Ergebnis aus {zahl1} - {zahl2} = {ergebnis2}");

            int ergebnis3 = zahl1*zahl2;
            Console.WriteLine($"Das Ergebnis aus {zahl1} * {zahl2} = {ergebnis3}");

            int ergebnis4 = zahl1/zahl2;
            Console.WriteLine($"Das Ergebnis aus {zahl1} / {zahl2} = {ergebnis4}");

            int ergebnis5 = zahl1%zahl2;
            Console.WriteLine($"Das Ergebnis aus {zahl1} % {zahl2} = {ergebnis5}");

            int ergebnis6 = zahl1++;
            Console.WriteLine($"Das Ergebnis aus {ergebnis6} ++ = {zahl1}");

            int ergebnis7 = zahl2--;
            Console.WriteLine($"Das Ergebnis aus {ergebnis7} --  = {zahl2}");

            int ergebnis8 = zahl1+=zahl3;
            Console.WriteLine($"Das Ergebnis aus {ergebnis8} += {zahl3} = {zahl1}");
        }
    }
}