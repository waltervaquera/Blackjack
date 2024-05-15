using System.Collections.Generic;

namespace BlackjackConsoleGame.Classes
{
    class Hand : List<Card>
    {
        public override string ToString()
        {
            string handString = "";
            foreach (Card card in this)
            {
                handString += $"{card}\n";
            }
            return handString;
        }

        public string ToString(bool hideFirstCard)
        {
            string handString = "";
            if (hideFirstCard)
            {
                handString += "Hidden\n";
            }
            else
            {
                handString += this[0] + "\n";
            }

            for (int i = 1; i < this.Count; i++)
            {
                handString += this[i] + "\n";
            }

            return handString;
        }
    }
}
