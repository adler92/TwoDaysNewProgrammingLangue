using System;
using System.Security;

namespace AllProjectsInOne
{
    // Mathias madsen / Andreas Ravn code
    internal class MainSite
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome! With this program you can choose between fun games or applications");
            Console.WriteLine("1: Random number guessing game");
            Console.WriteLine("2: HangMan");
            Console.WriteLine("3: Count your Inputs");
            Console.WriteLine("4: Rock, Paper and Scissors");
            Console.WriteLine("5: Valuta Converter (only for; Euro / $ / £)");
            Console.WriteLine("Choose what you want!");
            Console.ReadLine();
            if (Console.ReadLine() == "1"){
                 RngGuess.RandomGuess();
            }else if (Console.ReadLine() == "2") {
                HangMan.GameHangMan();
            }else if (Console.ReadLine() == "3") {
                CountInputs.Counting();
            }else if (Console.ReadLine() == "4") {
                RockPaperScissors.RockPaperScissor();
            }else if (Console.ReadLine() == "5") {
                Converter.Valuta();
            }
        }
    }
}

 /* Grp Project C# Learning
    Lukas Andersen
    Mathias Madsen
    Andreas Ravn
*/