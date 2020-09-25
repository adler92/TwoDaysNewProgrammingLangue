using System;

namespace AllProjectsInOne
{
    // Mathias Madsen Code
    public class Converter
    {
        public static void Valuta()
        {
            Console.WriteLine("Med dette program kan du konventere Euro, USD eller Pund til DKK");
            Console.WriteLine("1 for Euro 2 for USD eller 3 for Pund");
            Console.ReadLine();
            if (Console.ReadLine() == "1")
            {
                Euro.EurotilDK();
            }
            else if (Console.ReadLine() == "2")
            {
                USD.USDtilDK();
            }
            else if (Console.ReadLine() == "3")
            {
                Pund.PundTilDK();
            }
        }
    }
}