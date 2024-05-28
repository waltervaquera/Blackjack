namespace BlackjackAPI.Classes
{
    public class Deck
    {
        private List<Card> cards;
        private Random random;

        public Deck()
        {
            cards = new List<Card>();
            random = new Random();

            for (int suit = 0; suit <= 3; suit++)
            {
                for (int value = 1; value <= 13; value++)
                {
                    cards.Add(new Card((Suits)suit, (Values)value));
                }
            }
        }

        public void Shuffle()
        {
            List<Card> shuffledCards = new List<Card>(cards);
            cards.Clear();

            while (shuffledCards.Count > 0)
            {
                int randomIndex = random.Next(shuffledCards.Count);
                cards.Add(shuffledCards[randomIndex]);
                shuffledCards.RemoveAt(randomIndex);
            }
        }

        public Card DrawCard()
        {
            if (cards.Count == 0)
            {
                throw new Exception("Out of cards!");
            }

            Card cardToDraw = cards[0];
            cards.RemoveAt(0);
            return cardToDraw;
        }
    }
}
