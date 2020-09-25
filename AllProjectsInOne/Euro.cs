using System;

namespace AllProjectsInOne
{
    // Mathias Madsen Code
    public class Euro
    {
        public static void EurotilDK()
        {
            Console.WriteLine("What amount do you want to convert in Euro ? ");

            var euro = Console.ReadLine(); // får input fra brugeren

            var euroConv = double.Parse(euro); //Laver euro fra string til double

            var danskekroner = euroConv * 7.44; // Her konventere vi euro til danske kroner 

            Console.WriteLine(euro + " euro is " + danskekroner + "kr");
        }
    }
}