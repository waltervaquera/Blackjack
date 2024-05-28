using System.Text;

namespace BlackjackAPI.Classes
{
    public class Hand : List<Card>
    {
        public override string ToString()
        {
            StringBuilder handString = new StringBuilder();
            foreach (Card card in this)
            {
                handString.AppendLine($"{card.Value} of {card.Suit}");
            }
            return handString.ToString();
        }
    }
}
