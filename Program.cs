namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
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

        }

    }
}
    