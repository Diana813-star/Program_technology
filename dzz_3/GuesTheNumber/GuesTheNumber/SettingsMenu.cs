using System;

public class SettingsMenu
{
    public GameSettings OptionDifficulty()
    {
        GameSettings settings = new GameSettings();

        Console.WriteLine("Сыграем в игру УГАДАЙ ЧИСЛО!");
        Console.WriteLine("Выбери сложность:");
        Console.WriteLine("1-Легкая");
        Console.WriteLine("2-Средняя");
        Console.WriteLine("3-Сложная");
        Console.WriteLine("4-Настрой сам");

        string option = Console.ReadLine();

        if (option == "1")
        {
            settings.MaxNumber = 80;
            settings.MaxAttempts = 7;
        }
        else if (option == "2")
        {
            settings.MaxNumber = 150;
            settings.MaxAttempts = 7;
        }
        else if (option == "3")
        {
            settings.MaxNumber = 250;
            settings.MaxAttempts = 5;
        }
        else if (option == "4")
        {
            Console.WriteLine("Конечное число:");
            settings.MaxNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Количество попыток:");
            settings.MaxAttempts = Convert.ToInt32(Console.ReadLine());
        }
        else
        {
            Console.WriteLine("Выбрана средняя сложность");
            settings.MaxNumber = 150;
            settings.MaxAttempts = 7;
        }

        return settings;
    }
}