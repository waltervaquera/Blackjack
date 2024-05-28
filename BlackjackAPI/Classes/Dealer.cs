namespace BlackjackAPI.Classes
{
    public class Dealer : Player
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
