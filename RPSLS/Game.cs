using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
        Player playerOne;
        Player playerTwo;
        public Game()
        {

        }
        private void RuleBook()
        {
            Console.WriteLine("Rules: \n Scissors cuts Paper \n Paper covers Rock \n Rock crushes Lizard \n Lizard poisons Spock \n Spock smashes Scissors \n Scissors decapitates Lizard \n Lizard eats Paper \n Paper disproves Spock \n Spock vaporizes Rock \n (and as it always has) Rock crushes Scissors");
            Console.WriteLine("Best 2 wins out of 3 possible matches");
        }
        private void SelectNumberOfPlayers()
        {
            playerOne = new Human();
            Console.WriteLine("Enter Player name: ");
            playerOne.name = Console.ReadLine();

            Console.WriteLine("How many players are in the Game? 1 = Human Vs AI, 2 = Human Vs Human");
            int NumberOfPlayers = int.Parse(Console.ReadLine());
            switch (NumberOfPlayers)
            {
                case 1:
                    playerTwo = new Computer();

                    break;

                case 2:
                    playerTwo = new Human();
                    break;
                default:
                    Console.WriteLine("Apparently you didn't want to play then. Goodbye.");
                    Console.ReadLine();
                    break;
            }
            Console.WriteLine("Enter 2nd Player name: ");
            playerTwo.name = Console.ReadLine();
        }

        private void CompareChoices(Player playerOne, Player playerTwo)
        {

            if (playerOne.ItemChoice == 1 && (playerTwo.ItemChoice == 3 || playerTwo.ItemChoice == 4))
            {
                Console.WriteLine($"{playerOne.name} wins the round.\n");
                playerOne.score++;
            }
            else if (playerOne.ItemChoice == 2 && (playerTwo.ItemChoice == 1 || playerTwo.ItemChoice == 5))
            {
                Console.WriteLine($"{playerOne.name} wins the round.\n");
                playerOne.score++;
            }
            else if (playerOne.ItemChoice == 3 && (playerTwo.ItemChoice == 2 || playerTwo.ItemChoice == 4))
            {
                Console.WriteLine($"{playerOne.name} wins the round.\n");
                playerOne.score++;
            }
            else if (playerOne.ItemChoice == 4 && (playerTwo.ItemChoice == 2 || playerTwo.ItemChoice == 5))
            {
                Console.WriteLine($"{playerOne.name} wins the round.\n");
                playerOne.score++;
            }
            else if (playerOne.ItemChoice == 5 && (playerTwo.ItemChoice == 1 || playerTwo.ItemChoice == 3))
            {
                Console.WriteLine($"{playerOne.name} wins the round.\n");
                playerOne.score++;
            }
            else if (playerOne.ItemChoice == playerTwo.ItemChoice)
            {
                Console.WriteLine("Tie Round\n");
            }
            else
            {
                Console.WriteLine($"{playerTwo.name} Wins the round.\n");
                playerTwo.score++;
            }
            DetermineMatchWinner(playerOne, playerTwo);
        }

        private void DetermineMatchWinner(Player playerOne, Player playerTwo)
        {
            if (playerOne.score == 2)
            {
                Console.WriteLine($"{playerOne.name} Wins the Game.");
            }
            else if (playerTwo.score == 2)
            {
                Console.WriteLine($"{playerTwo.name} Wins the Game.");
            }
        }

        public void BeginGame()
        {
            RuleBook();
            SelectNumberOfPlayers();
            while (playerOne.score < 2 && playerTwo.score < 2)
            {
                playerOne.ItemSelect();
                playerTwo.ItemSelect();
                CompareChoices(playerOne, playerTwo);
            }
            Console.WriteLine("That's the game. Goodbye.");
            Console.ReadLine();
        }
    }
}
