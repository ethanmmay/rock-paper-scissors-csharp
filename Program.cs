using System;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rochambeau");
            // Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Enter your choice (r, p or s): ");
            var playerInput = Console.Read();
            var randomNum = new Random().Next(3);
            var gameResult = "Undetermined";
            switch (playerInput)
            {
                case 'r':
                    switch (randomNum)
                    {
                        case 0:
                          gameResult = "Tied.";
                          break;
                        case 1:
                          gameResult = "You Lost.";
                          break;
                        case 2:
                          gameResult = "You won!";
                          break;
                        default:
                          gameResult = "Oops. It broke.";
                          break;
                    }
                    break;
                case 'p':
                    switch (randomNum)
                    {
                        case 0:
                            gameResult = "You won!";
                            break;
                        case 1:
                            gameResult = "Tied.";
                            break;
                        case 2:
                            gameResult = "You Lost.";
                            break;
                        default:
                            gameResult = "Oops. It broke.";
                            break;
                    }
                    break;
                case 's':
                    switch (randomNum)
                    {
                        case 0:
                            gameResult = "You lost.";
                            break;
                        case 1:
                            gameResult = "You won!";
                            break;
                        case 2:
                            gameResult = "Tied.";
                            break;
                        default:
                            gameResult = "Oops. It broke.";
                            break;
                    }
                    break;
                default:
                    gameResult = "Hmm. Something happened.";
                    break;
            }
            var playerChoice = "unset";
            switch (playerInput)
            {
                case 'r':
                    playerChoice = "Rock";
                    break;
                case 'p':
                    playerChoice = "Paper";
                    break;
                case 's':
                    playerChoice = "Scissors";
                    break;
                default:
                    playerChoice = "Invalid Input";
                    break;
            }
            string computerChoice = "unset";
            switch(randomNum)
            {
                case 0:
                  computerChoice = "Rock";
                  break;
                case 1:
                  computerChoice = "Paper";
                  break;
                case 2:
                  computerChoice = "Scissors";
                  break;
                default:
                  computerChoice = "ERROR";
                  break;
            }
            Console.Write($"{gameResult} You chose: {playerChoice} and they played {computerChoice}");
        }
    }
}
