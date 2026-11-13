public interface IGameState
{
    void StartGame();
    void WinGame(int count);
    void LossGame(int number);
    void GameResult();
}