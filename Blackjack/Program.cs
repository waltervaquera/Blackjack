using BlackjackConsoleGame.Classes;
using System;

namespace BlackjackConsoleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Welcome to the Blackjack Console Game!");
                GameManager gameManager = new GameManager();
                gameManager.PlayGame();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
//release branch of the project
