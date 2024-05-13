using Game.Interfaces;
using Game.Support;

namespace Game.Implementations
{
    public class Settings : ISettings
    {
        public int MaxRetryCount { get; set; }
        public NumberRange Range { get; set; }

        public Settings(int maxRetryCount, NumberRange range)
        {
            MaxRetryCount = maxRetryCount;
            Range = range;
        }
    }
}
