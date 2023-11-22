using System;
namespace Uppgift5_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Detta program fungerar som en Magic 8-ball, ställ en fråga! Programmet avslutas om du skriver in 'a'");
            string fråga ="";
            string aaa = "a";
            string[] svar = new string[10] { "Ja", "Nej", "Kanske", "Definitivt", "Definitivt inte", "Antagligen", "Antagligen inte", "Utan tvekan", "Räkna inte på det", "Det kan du räkna med" };
            while (fråga != "a")
            {
                fråga = Console.ReadLine();
                Random random= new Random();
                if (fråga == "a")
                {
                    break;
                }
                else
                {
                    Console.WriteLine(svar[random.Next(11)]);
                    Console.WriteLine();
                    Console.WriteLine("Fråga igen!");
                }
            }
        }
    }
}