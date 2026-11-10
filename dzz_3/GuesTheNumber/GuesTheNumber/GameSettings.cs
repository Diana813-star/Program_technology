public class GameSettings
{
    public int MinNumber = 1 ;
    public int MaxNumber ;
    public int MaxAttempts ;
    public void OptionDifficulty()
    {
        string option = Console.ReadLine();

        if (option == "1")
        {
            MaxNumber = 80;
            MaxAttempts = 17;
        }
        else if (option == "2")
        {
            MaxNumber = 150;
            MaxAttempts = 12;
        }
        else if (option == "3")
        {
            MaxNumber = 250;
            MaxAttempts = 8;
        }
        else
        {
            Console.WriteLine("Неправильный выбор");
            Console.WriteLine("Выбрал средний уровень сложности");
            MaxNumber = 150;
            MaxAttempts = 12;

        }
    }
}