using Game.Interfaces;
using Game.Support;
using System.Text.Json;

namespace Game.Implementations
{
    public class RandomNumberGame() : IGame
    {
        public ISettings GameSettings;
        private UserInteractions userInteractions => new UserInteractions(GameSettings);

        public void Init()
        {
            try
            {
                var jsonSettings = File.ReadAllText("Settings.json");

                GameSettings = JsonSerializer.Deserialize<Settings>(jsonSettings);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine("Default setting applied");
                GameSettings = new Settings(10, new NumberRange(10, 20));
            }
        }

        public void Start()
        {
            var numberGenerator = new NumberGenerator(GameSettings);

            while (true)
            {
                userInteractions.NotifyAboutStartOfNewGame();

                RunOneRound(numberGenerator.GetNewNumber());

                userInteractions.OfferNewRound();

                if (!Convert.ToBoolean(userInteractions.GetUserAnswer()))
                {
                    Stop();

                    break;
                }
            }
        }

        public void Stop()
        {
            userInteractions.NotifyAboutEndOfTheGame();
        }

        private void RunOneRound(int currentNumberToGuess)
        {
            int i = 0;
            int userAnswer;

            while (i < GameSettings.MaxRetryCount)
            {
                userAnswer = userInteractions.GetUserAnswer();

                if (userAnswer == currentNumberToGuess)
                {
                    userInteractions.NotifyAboutWin();

                    break;
                }

                if (userAnswer > currentNumberToGuess)
                {
                    userInteractions.NotifyYourNumberIsGreater();
                }

                if (userAnswer < currentNumberToGuess)
                {
                    userInteractions.NotifyYourNumberIsLess();
                }

                i++;
            }

            if (i == GameSettings.MaxRetryCount)
            {
                userInteractions.NotifyAboutMaxRetry(currentNumberToGuess);
            }
        }
    }
}
