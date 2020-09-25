using System;

namespace AllProjectsInOne
{
    // Mathias Madsen Code
    public class Pund
    {
        public static void PundTilDK()
        {
            Console.WriteLine("What amount do you want to convert in pund ? ");

            var pund = Console.ReadLine(); // får input fra brugeren

            var pundConv = double.Parse(pund); //Laver Pund fra string til double

            var danskekroner = pundConv * 8.15; // Her konventere jeg pund til danske kroner 

            Console.WriteLine(pund + "Pund is " + danskekroner + "kr");
        }
    }
}