using System;
using System.Numerics;

namespace Chapter05
{
    public class GuessingGame
    {
        int ActualNumber;
        public int NumberOfGuesses { get; private set; }
        public int GuessCount { get; private set; }

        public GuessingGame()
        {
            ActualNumber = new Random().Next();
        }

        public GuessingGame(int actualNumber, int numberOfGuesses)
        {
            ActualNumber = actualNumber;
            NumberOfGuesses = numberOfGuesses;
        }

        public string RunSimulation(int guess)
        {
            GuessCount++;

            if (guess != ActualNumber)
            {
                if (GuessCount >= NumberOfGuesses)
                {
                    return $"You guessed {guess}. I'm sorry but you have run out of guesses to guess {ActualNumber}. Better luck next time!";
                }

                if (guess > ActualNumber)
                {
                    return $"You guessed {guess}. The number you're trying to guess is less than {guess}";
                }
                else
                {
                    return $"You guessed {guess}. The number you're trying to guess is greater than {guess}";
                }
            }
            else
            {
                return $"Congratulations!!! it took you {GuessCount} guesses to guess the number {ActualNumber}";
            }
        }
    }
}
