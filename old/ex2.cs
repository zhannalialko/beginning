using System.ComponentModel.DataAnnotations;

namespace HelloWorld
{
    class Program4
    {
        void Method4(string[] args)
        {
            Console.WriteLine("Gib mir deinen Namen");
            string name = Console.ReadLine();

            if(name.Length > 10)
            {
                Console.WriteLine("Oh, dein Name ist doch sehr lang");
            }
            else if (name.Length > 5)
            {
                Console.WriteLine("Der name ist mittellang");
            }
            else
            {
                Console.WriteLine("Der Name ist ja kurz");
            }

            for(int zahlvariable=0;zahlvariable<10;zahlvariable++)
            {
                Console.WriteLine(zahlvariable);
            }

            string[] emails = new string[3] 
            {
                "christian@tecalliance.net",
                "zhanna@tecalliance.net",
                "abc@tecalliance.net"
            };
            foreach (string email in emails)
            {
                Console.WriteLine($"Die Email lautet: {email}");
            }
            for(int position=0; position< emails.Length; position++)
            {
                Console.WriteLine($"Die Email lautet {emails[position]}");
            }

            List<int> myNumberList = new List<int>();

            Console.WriteLine("Sage mir, wie vile Zahlen du in deine Liste hinzufügen möchtest");
            int ammountNumbers = Convert.ToInt32(Console.ReadLine());
            
            while(myNumberList.Count < ammountNumbers)
            {

                Console.WriteLine("Gebe mir eine Zahl");
                myNumberList.Add(Convert.ToInt32(Console.ReadLine()));

                int ergebnis = 0;
                foreach(int zahl in myNumberList)
                {
                    ergebnis += zahl;
                }
                Console.WriteLine($"Das ergebnis ist {ergebnis}");
            }
            
            }
        }

    }
    