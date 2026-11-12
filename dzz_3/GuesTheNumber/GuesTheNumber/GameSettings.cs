public class GameSettings
{
    public int MinNumber = 1 ;
    public int MaxNumber ;
    public int MaxAttempts ;
    public void OptionDifficulty()
    {
        Console.WriteLine("Сыграем в игру УГАДАЙ ЧИСЛО!");
        Console.WriteLine("Выбери сложность:");
        Console.WriteLine("1-Легкая");
        Console.WriteLine("2-Средняя");
        Console.WriteLine("3-Сложная");
        Console.WriteLine("4-Настрой сам");

        string option = Console.ReadLine();

        if (option == "1")
        {
            MaxNumber = 80;
            MaxAttempts = 7;
        }
        else if (option == "2")
        {
            MaxNumber = 150;
            MaxAttempts = 7;
        }
        else if (option == "3")
        {
            MaxNumber = 250;
            MaxAttempts = 5;
        }
        else if (option == "4")
        {        
            Console.WriteLine("Конечное число:");
            MaxNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Количество попыток:");
            MaxAttempts = Convert.ToInt32(Console.ReadLine());
        }
        else
        {
            Console.WriteLine("Неправильный выбор");
            Console.WriteLine("Выбрал средний уровень сложности");
            MaxNumber = 150;
            MaxAttempts = 7;

        }
    }
}