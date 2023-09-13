using System.ComponentModel.DataAnnotations;

internal class Program
{
    private static void Main(string[] args)
    {
        List<int> myNumberList = new List<int>();
        
        Console.WriteLine("Bis zu welcher Zahl soll hinzugefügt werden?");
        int untilNumber = Convert.ToInt32(Console.ReadLine());

        int ergebnis = 0;
        for(int i = 0; i <= untilNumber; i++)
        {
            ergebnis +=i;
            Console.WriteLine($"Added Number{i}, current result {ergebnis}");
        }
    
        List<int> myNumberList2 = new List<int>();

        Console.WriteLine("Bis zu welcher Zahl soll hinzugefügt werden? (Versuch2)");
        int untilNumber2 = Convert.ToInt32(Console.ReadLine());

        int zahl = 0;
        int ergebnis2 = 0;
        while(zahl < untilNumber2)
        {
            zahl +=1;
            ergebnis2 += zahl;
            Console.WriteLine($"Added Number{zahl}, current result {ergebnis2}");
        }
    
    }
}
