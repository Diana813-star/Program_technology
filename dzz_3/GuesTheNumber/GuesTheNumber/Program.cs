using System;

class Program
{
    static void Main(string[] args)
    {
        SettingsMenu menu = new SettingsMenu();

        GameSettings settings = menu.OptionDifficulty();

        IGameHints hints = new GameHints();

        IAssociationNumber association = new AssociationNumber();

        IGameHistory history = new GameHistory();

        IGameState state = new GameState();

        Game game = new Game(settings, hints, association, history, state);

        game.Start();

        game.GameStart += state.StartGame;

        game.PlayerWin += state.WinGame;

        game.PlayerLoss += state.LossGame;

        game.GameFinish += state.GameResult;

        game.Start();
    }

}