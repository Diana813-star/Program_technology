using System;

public class Game
{
    public event Action? GameStart;
    public event Action<int>? PlayerWin;
    public event Action<int>? PlayerLoss;
    public event Action? GameFinish;


    private GameSettings settings;
    private IGameHints hints;
    private IAssociationNumber association;
    private IGameHistory history;
    private IGameState state;

    public Game(GameSettings settings, IGameHints hints,
        IAssociationNumber association, IGameHistory history,
        IGameState state)
    {
        this.settings = settings;
        this.hints = hints;
        this.association = association;
        this.history = history;
        this.state = state;
    }

    public void Start()
    {
        Random random = new Random();

        int number = random.Next(
            settings.MinNumber, settings.MaxNumber + 1);

        int userInp = 0;
        int count = 0;

        GameStart?.Invoke();

        Console.WriteLine("Загадал число от " +
            settings.MinNumber + " до " + settings.MaxNumber);

        while (userInp != number && count < settings.MaxAttempts)
        {
            Console.WriteLine("Введите число:");
            string text = Console.ReadLine();

            if (!int.TryParse(text, out userInp))
            {
                Console.WriteLine("Введите число правильно!");
                continue;
            }

            count++;

            if (userInp < number)
            {
                Console.WriteLine("Загаданное число больше!");
                hints.ShowHint(userInp, number);
                association.Association(number);
            }
            else if (userInp > number)
            {
                Console.WriteLine("Загаданное число меньше!");
                hints.ShowHint(userInp, number);
                association.Association(number);
            }
            else
            {
                PlayerWin?.Invoke(count);
            }
        }

        bool win = userInp == number;

        if (!win)
        {
            PlayerLoss?.Invoke(number);
        }

        history.SaveResult(number, win);

        GameFinish?.Invoke();
    }
}