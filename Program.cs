using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

// Aufgabe 1: Initialisiere 2 Zahlen und gebe die Summe auf der Console aus

int a = 10;
Console.WriteLine(a);

int b = 20;
Console.WriteLine(b);

int summe = a + b;
Console.WriteLine(summe);

// Aufgabe 2: Lasse den Nutzer zwei Zahlen eingeben und gebe die Summe auf der Console aus:

Console.WriteLine("Gebe uns deine erste Zahl!");
string eingabe1 = Console.ReadLine();

//Frage den Nutzer nach der zweiten Zahl
Console.WriteLine("Gebe uns deine zweite Zahl!");
string eingabe2 = Console.ReadLine();

//Gebe das Ergebnis auf der Console aus
int zahl1 = Convert.ToInt16(eingabe1);
int zahl2 = Convert.ToInt16(eingabe2);

int ergebnis = zahl1 + zahl2;

Console.WriteLine($"Das Ergebnis ist: {ergebnis}");


//Aufgabe 3: Lasse den Nutzer eine Zahl eingeben und gebe alle Zahlen bis einschließlich der eingegeben Zahl aus

Console.WriteLine("Gebe uns deine Zahl!");
string eingabe3 = Console.ReadLine();

int zahl3 = Convert.ToInt16(eingabe3);
int i = 0;

while (i <= zahl3)
{
    Console.WriteLine(i);
    i++;
}
//Aufgabe 4: Lasse den Nutzer eine Zahl eingeben und gebe nur die geraden Zahlen aus.

Console.WriteLine("Gebe uns deine Zahl!");
string eingabe4 = Console.ReadLine();

int zahl4 = Convert.ToInt16(eingabe4);
int zahlx = 0;

while (zahlx <= zahl4)
{
    if (zahlx % 2 == 0)
    {
        Console.WriteLine(zahlx);
    }
    zahlx++;
}
//Aufgabe 5: Lasse den Nutzer eine Zahl eingeben und berechne von dieser Zahl die Fakultät.

Console.WriteLine("Gebe uns deine Zahl!");
string eingabe5 = Console.ReadLine();

int zahl5 = Convert.ToInt16(eingabe5);
int summes = 1;

for (int zahls = 1; zahls <= zahl5; zahls++)
{
    summes = summes*zahls;
    Console.WriteLine(summes);
}

//Aufgabe 6a: Lasse den Nutzer einen Text eingeben und gebe den Text nur in Großbuchstaben aus

Console.WriteLine("Schreib etwas!");
string eingabe6 = Console.ReadLine();

Console.WriteLine(eingabe6.ToUpper());

//Aufgabe 6b: Gebe die Länge des Textes aus

Console.WriteLine("Schreib etwas!");
string eingabe7 = Console.ReadLine();

Console.WriteLine("The length of the text is: " + eingabe7.Length);

//Aufgabe 6c: Zähle wie oft der Buchstabe a vorkommt.

Console.WriteLine("Schreib etwas!");
string eingabe8 = Console.ReadLine();
char ch = 'a';

int freq = eingabe8.Split(ch).Length - 1;
Console.WriteLine(freq);

//Aufgabe 6d: Gebe nur einen Teil des Textes aus. Ab Position 3, und dann die nächsten 5 Buchstaben

Console.WriteLine("Schreib etwas!");
string eingabe9 = Console.ReadLine();

if (eingabe9.Length < 9)
{
    Console.WriteLine("Scheib etwas noch!");
}
else
{
    Console.WriteLine(eingabe9.Substring(2, 5));
}

