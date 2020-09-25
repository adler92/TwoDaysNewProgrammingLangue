using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
/*
         _                         _
        |_|                       |_|
        | |         /^^^\         | |
       _| |_      (| "o" |)      _| |_
     _| | | | _    (_---_)    _ | | | |_ 
    | | | | |' |    _| |_    | `| | | | |
    \          /   /     \   \          /
     \        /  / /(. .)\ \  \        /
       \    /  / /  | . |  \ \  \    /
         \  \/ /    ||Y||    \ \/  /
           \_/      || ||      \_/
                    () ()
                    || ||
                   ooO Ooo
*/
namespace AllProjectsInOne
{
    // Lukas Andersen Code
    public class RockPaperScissors
    {
        public static void RockPaperScissor()
        {
            do
            {
                Console.WriteLine("Do you choose rock, paper or scissors?");
                string userChoice = Console.ReadLine();

                if (userChoice == "rock")
                {
                    Console.WriteLine(
                        "You chose rock\n    _______\n---'   ____)\n      (_____)\n      (_____)\n      (____)\n---.__(___)");
                }

                else if (userChoice == "paper")
                {
                    Console.WriteLine(
                        "You chose paper\n    _______\n---'   ____)____\n          ______)\n          _______)\n         _______)\n---.__________)");
                }

                else if (userChoice == "scissors")
                {
                    Console.WriteLine(
                        "You chose scissors\n    _______\n---'   ____)____\n          ______)\n       __________)\n      (____)\n---.__(___)");
                }

                else
                {
                    continue;
                }


                Random r = new Random();
                int computerChoice = r.Next(4);

                if (computerChoice == 1)
                {
                    if (userChoice == "rock")
                    {
                        Console.WriteLine("The computer chose rock");
                        Console.WriteLine(
                            "    _______\n---'   ____)\n      (_____)\n      (_____)\n      (____)\n---.__(___)");
                        Console.WriteLine("It is a tie ");
                    }
                    else if (userChoice == "paper")
                    {
                        Console.WriteLine("The computer chose paper");
                        Console.WriteLine(
                            "    _______\n---'   ____)____\n          ______)\n          _______)\n         _______)\n---.__________)");
                        Console.WriteLine("It is a tie ");

                    }
                    else if (userChoice == "scissors")
                    {
                        Console.WriteLine("The computer chose scissors");
                        Console.WriteLine(
                            "    _______\n---'   ____)____\n          ______)\n       __________)\n      (____)\n---.__(___)");
                        Console.WriteLine("It is a tie ");
                    }
                    else
                    {
                        Console.WriteLine("You must choose rock, paper or scissors!");

                    }

                }

                else if (computerChoice == 2)
                {
                    if (userChoice == "rock")
                    {
                        Console.WriteLine("The computer chose paper");
                        Console.WriteLine(
                            "    _______\n---'   ____)____\n          ______)\n          _______)\n         _______)\n---.__________)");
                        Console.WriteLine("Sorry you lose, paper beat rock");

                    }
                    else if (userChoice == "paper")
                    {
                        Console.WriteLine("The computer chose scissors");
                        Console.WriteLine(
                            "    _______\n---'   ____)____\n          ______)\n       __________)\n      (____)\n---.__(___)");
                        Console.WriteLine("Sorry you lose, scissors beat paper ");

                    }
                    else if (userChoice == "scissors")
                    {
                        Console.WriteLine("The computer chose rock");
                        Console.WriteLine(
                            "    _______\n---'   ____)\n      (_____)\n      (_____)\n      (____)\n---.__(___)");
                        Console.WriteLine("Sorry you lose, rock beats scissors");
                    }
                    else
                    {
                        Console.WriteLine("You must choose rock, paper or scissors!");
                    }
                }
                else if (computerChoice == 3)
                {
                    if (userChoice == "rock")
                    {
                        Console.WriteLine("The computer chose scissors");
                        Console.WriteLine(
                            "    _______\n---'   ____)____\n          ______)\n       __________)\n      (____)\n---.__(___)");
                        Console.WriteLine("You win, rock beats scissors");

                    }
                    else if (userChoice == "paper")
                    {
                        Console.WriteLine("The computer chose rock");
                        Console.WriteLine(
                            "    _______\n---'   ____)\n      (_____)\n      (_____)\n      (____)\n---.__(___)");
                        Console.WriteLine("You win, paper beats rock");

                    }
                    else if (userChoice == "scissors")
                    {
                        Console.WriteLine("The computer chose paper");
                        Console.WriteLine(
                            "    _______\n---'   ____)____\n          ______)\n          _______)\n         _______)\n---.__________)");
                        Console.WriteLine("You win, scissors beat paper");

                    }
                    else
                    {
                        Console.WriteLine("You must choose rock, paper or scissors!");

                    }

                }

                Console.WriteLine("----------- \nWanna play again? \nyes or no?");
            } while (Console.ReadLine() == "yes");

            Console.WriteLine("Goodbye.");

        }
    }
}