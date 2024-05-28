namespace BlackjackAPI.Classes
{
    public class GameManager
    {
        private Deck deck;
        public Player player;
        public Dealer dealer;
        public bool gameInProgress { get; private set; }
        private GameResult gameResult;

        public GameManager()
        {
            deck = new Deck();
            player = new Player();
            dealer = new Dealer();
            gameInProgress = false;
        }

        public void StartGame()
        {
            deck.Shuffle();
            player.Hand.Clear();
            dealer.Hand.Clear();

            DealInitialCards();

            gameInProgress = true;
            gameResult = GameResult.NoResult;
        }

        public string GetPlayerHand()
        {
            return player.Hand.ToString();
        }

        public string GetDealerHand(bool hideFirstCard)
        {
            return dealer.Hand.ToString(hideFirstCard);
        }

        public void Hit()
        {
            if (gameInProgress)
            {
                player.Hand.Add(deck.DrawCard());
            }
        }

        public GameResult Stand()
        {
            if (gameInProgress)
            {
                dealer.PlayHand(deck);
                gameResult = DetermineWinner();
                gameInProgress = false;
            }

            return gameResult;
        }

        public GameResult GetGameResult()
        {
            return gameResult;
        }

        private void DealInitialCards()
        {
            player.Hand.Add(deck.DrawCard());
            player.Hand.Add(deck.DrawCard());
            dealer.Hand.Add(deck.DrawCard());
            dealer.Hand.Add(deck.DrawCard());
        }

        private GameResult DetermineWinner()
        {
            int playerScore = player.GetScore();
            int dealerScore = dealer.GetScore();

            if (playerScore > 21)
            {
                return GameResult.PlayerBusted;
            }
            else if (dealerScore > 21)
            {
                return GameResult.DealerBusted;
            }
            else if (playerScore == dealerScore)
            {
                return GameResult.Tie;
            }
            else if (playerScore > dealerScore)
            {
                return GameResult.PlayerWins;
            }
            else
            {
                return GameResult.DealerWins;
            }
        }
    }

    public enum GameResult
    {
        PlayerWins,
        DealerWins,
        Tie,
        PlayerBusted,
        DealerBusted,
        NoResult
    }
}
