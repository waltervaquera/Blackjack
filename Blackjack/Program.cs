using BlackjackConsoleGame.Classes;

namespace BlackjackConsoleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Blackjack Console Game!");
            GameManager gameManager = new GameManager();
            gameManager.PlayGame();
        }
    }
}
