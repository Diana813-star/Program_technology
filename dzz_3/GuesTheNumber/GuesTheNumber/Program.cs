using System;

class Program
{
    static void Main(string[] args)
    {
        GameSettings settings = new GameSettings();

        GameState state = new GameState();

        AssociationNumber association = new AssociationNumber();

        settings.OptionDifficulty();

        Random random = new Random();

        int number = random.Next(settings.MinNumber, settings.MaxNumber + 1);

        int userInp = 0;
        int count = 0;

        GameHints hints = new GameHints();

        state.StartGame();

        Console.WriteLine("Загадал число от "+ settings.MinNumber + " до " + settings.MaxNumber);


        while (userInp != number && count < settings.MaxAttempts)
        {
            Console.WriteLine("Введите число: ");
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
                state.WinGame(count);
            }
        }

        if (userInp != number)
        {
            state.LossGame(number);
        }

        state.GameResult();
    }
}