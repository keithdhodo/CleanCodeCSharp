using System;

namespace Chapter02
{
    public class GuessStatistics
    {
        public string Number { get; private set; }
        public string Verb { get; private set; }
        public string PluralModifier { get; private set; }

        public string PrintGuessStatistics(char candidate, int count)
        {
            CreatePluralDependentMessageParts(count);

            return $"There {Verb} {Number} {candidate}{PluralModifier}";
        }

        private void CreatePluralDependentMessageParts(int count)
        {
            if (count == 0)
            {
                ThereAreNoLetters();
            }
            else if (count == 1)
            {
                ThereIsOneLetter();
            }
            else
            {
                ThereAreManyLetters(count);
            }
        }

        private void ThereAreManyLetters(int count)
        {
            Number = count.ToString();
            Verb = "are";
            PluralModifier = "s";
        }

        private void ThereIsOneLetter()
        {
            Number = "1";
            Verb = "is";
            PluralModifier = string.Empty;
        }

        private void ThereAreNoLetters()
        {
            Number = "no";
            Verb = "are";
            PluralModifier = "s";
        }
    }
}
