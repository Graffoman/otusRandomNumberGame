using Game.Support;

namespace Game.Interfaces
{
    public interface ISettings
    {
        int MaxRetryCount { get; set; }
        NumberRange Range { get; set; }
    }
}