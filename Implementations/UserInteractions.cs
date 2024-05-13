using Game.Interfaces;

namespace Game.Implementations
{
    public class UserInteractions : IUserInteractions
    {
        private readonly ISettings settings;

        public UserInteractions(ISettings settings)
        {
            this.settings = settings;
        }

        public void NotifyAboutStartOfNewGame()
        {
            Console.WriteLine("__________");
            Console.WriteLine();
            Console.WriteLine("Hi gays");
            Console.WriteLine("Welcome to the game \"Guess the number\"");
            Console.WriteLine($"You have {settings.MaxRetryCount} retries");
            Console.WriteLine($"Guess the number from {settings.Range.Start} to {settings.Range.End}");
            Console.WriteLine("Input your guess and press Enter");
            Console.WriteLine("__________");
        }

        public void NotifyAboutEndOfTheGame()
        {
            Console.WriteLine("__________");
            Console.WriteLine();
            Console.WriteLine("It's sad");
            Console.WriteLine("By gay");
            Console.WriteLine("__________");
        }

        public void NotifyAboutMaxRetry(int numberToGuess)
        {
            Console.WriteLine("__________");
            Console.WriteLine();
            Console.WriteLine($"It's sad, but you reached Max retry limit");
            Console.WriteLine($"The number was {numberToGuess}");
            Console.WriteLine("__________");
        }

        public void NotifyAboutWin()
        {
            Console.WriteLine("__________");
            Console.WriteLine();
            Console.WriteLine("Gay, you won!");
            Console.WriteLine("__________");
        }

        public void NotifyAboutLoss()
        {
            Console.WriteLine("__________");
            Console.WriteLine();
            Console.WriteLine("No gay. You lost");
            Console.WriteLine("__________");
        }

        public void NotifyYourNumberIsLess()
        {
            Console.WriteLine("Sorry, your number is less than comp's number");
        }

        public void NotifyYourNumberIsGreater()
        {
            Console.WriteLine("Sorry, your number is greater than comp's number");
        }

        public void OfferNewRound()
        {
            Console.WriteLine("__________");
            Console.WriteLine();
            Console.WriteLine("Want more?");
            Console.WriteLine("1 - Yes");
            Console.WriteLine("0 - No");
            Console.WriteLine("__________");
        }

        public int GetUserAnswer()
        {
            string answer = Console.ReadLine();

            bool correct = int.TryParse(answer, out int result);

            if (!correct)
            {
                Console.WriteLine("Please input int number");
                GetUserAnswer();
            }

            return result;
        }

    }
}
