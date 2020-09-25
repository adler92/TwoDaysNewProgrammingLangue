using System;
using System.Data.SqlTypes;

namespace AllProjectsInOne
{
    //Andreas Ravn Code
    public class HangMan
    {
        public static void GameHangMan()
        {
            Console.ForegroundColor = ConsoleColor.Cyan; // Just to put some color in it
            Console.WriteLine("Let's play Hangman!"); // intro to what game it is.
            var wordlist = new string[5]; // making a "wordlist" so there can be some different variats of words.
            wordlist[0] = "shootingstar";
            wordlist[1] = "school";
            wordlist[2] = "programming"; // the different type of words to be used
            wordlist[3] = "java";
            wordlist[4] = "helloworld";
            var generateRandom = new Random(); // making so it's random which word you get of 0-4
            var id = generateRandom.Next(0, 4); // --||--
            var rngword = wordlist[id]; // --||--
            var guess = new char[rngword.Length]; // --||--
            Console.WriteLine("Try your guess!"); // here on out the game begins!

            for (var p = 0; p < rngword.Length; p++) // making sure that the rng word isent shown
                guess[p] = '*';                                      

            while (true)
            {
                var playerGuess = char.Parse(Console.ReadLine());  // checking if input is matching with rng word.
                for (var j = 0; j < rngword.Length; j++)  // --||--
                    if (playerGuess == rngword[j])        // --||--
                        guess[j] = playerGuess;            // --||--


                Console.WriteLine(guess);
            }
        }

        private void asciiHandman()
        {
            
            Console.WriteLine("  +---+");
            Console.WriteLine("  |   |");
            Console.WriteLine("  O   |");
            Console.WriteLine("      |");
            Console.WriteLine("      |");
            Console.WriteLine("      |");
            Console.WriteLine("=========''', '''");
        } 
            
        }
    }
