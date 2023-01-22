using System;

namespace mbox
{
    internal class ToXicsgame 
    {
        static void Main(string[] args)
        {
            const string Rock = "Rock";
            const string Paper = "Paper";
            const string Scissors = "Scissors";
            string whoWins = string.Empty;
            string playerMove = string.Empty;
            int countToComputer = 0;
            int countToPlayer = 0;
            while (true)
            {
                Console.Write("Choose [r]ock,[p]aper or [s]cissors: ");
                playerMove = Console.ReadLine();
                if (playerMove == "r" || playerMove == "rock")
                {
                    playerMove = "Rock";
                }
                else if (playerMove == "p" || playerMove == "paper")
                {
                    playerMove = "Paper";
                }
                else if (playerMove == "s" || playerMove == "scissors")
                {
                    playerMove = "Scissors";
                }
                else
                {
                    Console.WriteLine("Invalid input. Try Again...");
                    return;
                }
                Random random = new Random();
                int computerRandomNumber = random.Next(1, 4);
                string computerMove = string.Empty;

                switch (computerRandomNumber)
                {
                    case 1:
                        computerMove = Rock;
                        break;
                    case 2:
                        computerMove = Paper;
                        break;
                    case 3:
                        computerMove = Scissors;
                        break;
                }
                Console.WriteLine($"the computer chose {computerMove}");
                if ((playerMove == Rock && computerMove == Scissors) || (playerMove == Scissors && computerMove == Paper) || (playerMove == Paper && computerMove == Rock))
                {
                    countToPlayer++;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("You win.");
                    Console.ResetColor();
                    Console.WriteLine($"The game score = Computer {countToComputer} : Player {countToPlayer}");
                    whoWins = "player";

                }
                else if ((playerMove == Rock && computerMove == Paper) || (playerMove == Scissors && computerMove == Rock) || (playerMove == Paper && computerMove == Scissors))
                {
                    countToComputer++;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("You lose.");
                    Console.ResetColor();
                    Console.WriteLine($"The game score = Computer {countToComputer} : Player {countToPlayer}");
                    whoWins = "computer";
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine("This game was a draw.");
                    Console.ResetColor();
                    Console.WriteLine($"The game score = Computer {countToComputer} : Player {countToPlayer}");
                    whoWins = "anyone";
                }
                if (whoWins == "player")
                {
                    Console.WriteLine("IM THE COMPUTER: - SAY [YES] TO COME IF YOU ARE NOT PUSSY! IF YOU ARE SAY [NO]!");
                }
                else if (whoWins == "computer")
                {
                    Console.WriteLine("HAHAHA I won if you wanna try agian say [yes] if you are going to ragequit say [no]!");
                }
                else
                {
                    Console.WriteLine("Please come again if you want say [yes] if you dont say [no]!");
                }
                playerMove = Console.ReadLine();
                if (playerMove == "no" || playerMove == "NO" || playerMove == "No")
                {
                    Console.WriteLine("From the computer -> WHYYYY YOU SAID NOO!? PUSSY! BYE!");
                    break;
                }
                else if (playerMove == "yes" || playerMove == "YES" || playerMove == "Yes")
                {
                    Console.WriteLine("Ok you are not pussy, let's try again this shit");
                }
                else
                {
                    Console.WriteLine("Invalid input ! ");
                    break;
                }
            }
            System.Console.WriteLine("Made By ToXic!");
        }
    }
}