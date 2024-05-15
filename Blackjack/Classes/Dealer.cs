namespace BlackjackConsoleGame.Classes
{
    class Dealer : Player
    {
        public void PlayHand(Deck deck)
        {
            while (GetScore() < 17)
            {
                Hand.Add(deck.DrawCard());
            }
        }
    }
}
