namespace Game.Interfaces
{
    public interface IUserInteractions
    {
        void NotifyAboutEndOfTheGame();
        void NotifyAboutLoss();
        void NotifyAboutStartOfNewGame();
        void NotifyAboutWin();
    }
}