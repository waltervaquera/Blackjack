namespace BlackjackConsoleGame.Classes
{
    class GameManager
    {
        private Deck deck;
        private Player player;
        private Dealer dealer;

        public GameManager()
        {
            deck = new Deck();
            player = new Player();
            dealer = new Dealer();
        }

        public void PlayGame()
        {
            bool playAgain = true;

            while (playAgain)
            {
                try
                {
                    deck.Shuffle();
                    player.Hand.Clear();
                    dealer.Hand.Clear();

                    DealInitialCards();

                    bool playerStands = false;

                    while (true)
                    {
                        Console.WriteLine("\nYour hand:");
                        Console.WriteLine(player.Hand.ToString());
                        Console.WriteLine("Your score: " + player.GetScore());

                        Console.WriteLine("\nDealer's hand:");
                        Console.WriteLine(dealer.Hand.ToString(true));

                        if (player.GetScore() > 21)
                        {
                            Console.WriteLine("You busted! Dealer wins.");
                            break;
                        }

                        Console.Write("\nWould you like to (h)it or (s)tand? ");
                        string input = Console.ReadLine().ToLower();

                        switch (input)
                        {
                            case "h":
                                player.Hand.Add(deck.DrawCard());
                                break;
                            case "s":
                                playerStands = true;
                                dealer.PlayHand(deck);
                                Console.WriteLine("\nDealer's hand:");
                                Console.WriteLine(dealer.Hand.ToString());
                                Console.WriteLine("Dealer's score: " + dealer.GetScore());

                                DetermineWinner();
                                break;
                            default:
                                Console.WriteLine("Invalid input. Please enter 'h' or 's'.");
                                break;
                        }

                        if (playerStands)
                            break;
                    }

                    Console.Write("\nWould you like to play again? (y/n) ");
                    string playAgainInput = Console.ReadLine().ToLower();

                    if (playAgainInput != "y")
                    {
                        playAgain = false;
                        Console.WriteLine("Thanks for playing!");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
        }

        private void DealInitialCards()
        {
            player.Hand.Add(deck.DrawCard());
            player.Hand.Add(deck.DrawCard());
            dealer.Hand.Add(deck.DrawCard());
            dealer.Hand.Add(deck.DrawCard());
        }

        private void DetermineWinner()
        {
            int playerScore = player.GetScore();
            int dealerScore = dealer.GetScore();

            if (playerScore > 21)
            {
                Console.WriteLine("You busted! Dealer wins.");
            }
            else if (dealerScore > 21)
            {
                Console.WriteLine("Dealer busted! You win!");
            }
            else if (playerScore == dealerScore)
            {
                Console.WriteLine("It's a tie!");
            }
            else if (playerScore > dealerScore)
            {
                Console.WriteLine("You win!");
            }
            else
            {
                Console.WriteLine("Dealer wins!");
            }
        }
    }
}
