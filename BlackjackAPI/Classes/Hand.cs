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
                handString.AppendLine(card.ToString());
            }
            return handString.ToString();
        }

        public string ToString(bool hideFirstCard)
        {
            StringBuilder handString = new StringBuilder();
            if (hideFirstCard)
            {
                handString.AppendLine("Hidden");
            }
            else
            {
                handString.AppendLine(this[0].ToString());
            }

            for (int i = 1; i < Count; i++)
            {
                handString.AppendLine(this[i].ToString());   
            }

            return handString.ToString();
        }
    }
}
