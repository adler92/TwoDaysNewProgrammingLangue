using System;

namespace AllProjectsInOne
{
    // Mathias Madsen Code
    public class USD
    {
        public static void USDtilDK()
        {
            Console.WriteLine("What amount do you want to convert in USD ? ");

            var usd = Console.ReadLine(); // får input fra brugeren

            var usdConv = double.Parse(usd); //Laver usd fra string til double

            var danskekroner = usdConv * 6.38; // Her konventere vi usd til danske kroner 

            Console.WriteLine
                (usd + " USD is " + danskekroner + "kr");
        }
    }
}