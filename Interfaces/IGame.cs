namespace Game.Interfaces
{
    public interface IGame
    {
        ISettings GameSettings { get; }
        void Start();
        void Stop();
    }
}