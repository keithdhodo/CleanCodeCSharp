using Chapter05;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Chapter05Tests
{
    [TestClass]
    public class GuessingGameTests
    {
        public GuessingGame GuessingGame { get; private set; }

        [TestMethod]
        public void GuessingGame_RunSimulation_GuessWrong()
        {
            var actualNumber = 10;
            var numberOfGuesses = 9;
            GuessingGame = new GuessingGame(actualNumber, numberOfGuesses);
            var actualMessage = GuessingGame.RunSimulation(numberOfGuesses);
            var expectedMessage = $"You guessed {numberOfGuesses}. The number you're trying to guess is greater than {numberOfGuesses}";
            Assert.AreEqual(expectedMessage, actualMessage);
        }

        [TestMethod]
        public void GuessingGame_RunSimulation_GuessCorrectly()
        {
            var actualNumber = 1054;
            var numberOfGuesses = 9;
            GuessingGame = new GuessingGame(actualNumber, numberOfGuesses);
            var actualMessage = GuessingGame.RunSimulation(actualNumber);
            var expectedMessage = $"Congratulations!!! it took you {GuessingGame.GuessCount} guesses to guess the number {actualNumber}";
            Assert.AreEqual(expectedMessage, actualMessage);
        }

        [TestMethod]
        public void GuessingGame_RunSimulation_GuessesOverTheLimit()
        {
            var actualNumber = 1054;
            var numberOfGuesses = 9;
            GuessingGame = new GuessingGame(actualNumber, numberOfGuesses);

            for (int i = 0; i < numberOfGuesses; i++)
            {
                GuessingGame.RunSimulation(numberOfGuesses);
            }

            var actualMessage = GuessingGame.RunSimulation(numberOfGuesses);
            var expectedMessage = $"You guessed {numberOfGuesses}. I'm sorry but you have run out of guesses to guess {actualNumber}. Better luck next time!";
            Assert.AreEqual(expectedMessage, actualMessage);
        }
    }
}
