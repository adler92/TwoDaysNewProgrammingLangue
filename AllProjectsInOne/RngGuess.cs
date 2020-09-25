using System;

namespace AllProjectsInOne
{
    //Andreas Ravn Code
    public class RngGuess
    {
        public static void RandomGuess()
        {
            Random rand = new Random();

            var rng = rand.Next(10);
            Console.WriteLine("Guess a number from 1 to 10!");

            var input = Console.ReadLine();
            var RNG = double.Parse(input);

            if (rng == RNG)
                Console.WriteLine("Right");
            else
                Console.WriteLine("Wrong!"); 
            
        }
    }
}