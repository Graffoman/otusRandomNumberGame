using Game.Interfaces;

namespace Game.Support
{
    public class NumberGenerator(ISettings settings)
    {
        private readonly ISettings _settings = settings;

        public int GetNewNumber()
        {
            return new Random().Next(_settings.Range.Start, _settings.Range.End);
        }
    }
}
