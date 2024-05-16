namespace BlackjackConsoleGame.Classes
{
    class Player
    {
        public Hand Hand { get; set; }

        public Player()
        {
            Hand = new Hand();
        }

        public int GetScore()
        {
            int score = 0;
            int acesCount = 0;

            foreach (Card card in Hand)
            {
                if (card.Value == Values.Ace)
                {
                    acesCount++;
                }
                else if (card.Value >= Values.Jack)
                {
                    score += 10;
                }
                else
                {
                    score += (int)card.Value;
                }
            }

            while (acesCount > 0)
            {
                if (score + 11 <= 21)
                {
                    score += 11;
                }
                else
                {
                    score += 1;
                }
                acesCount--;
            }

            return score;
        }
    }
}
