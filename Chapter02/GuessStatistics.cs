using System;

namespace Chapter02
{
    public class GuessStatistics
    {
        public string PrintGuessStatistics(char candidate, int count)
        {
            string number;
            string verb;
            string pluralModifier;

            if (count == 0)
            {
                number = "no";
                verb = "are";
                pluralModifier = "s";
            }
            else if (count == 1)
            {
                number = "1";
                verb = "is";
                pluralModifier = string.Empty;
            }
            else
            {
                number = count.ToString();
                verb = "are";
                pluralModifier = "s";
            }

            string guessMessage = $"There {verb} {number} {candidate}{pluralModifier}";

            return guessMessage;
        }
    }
}
