using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();

        int number = random.Next(1, 101);
        int userInp = 0;
        int count = 0;

        Console.WriteLine("Сыграем в игру УГАДАЙ ЧИСЛО!");
        Console.WriteLine("Загаданное число от 1 до 100");

        while (userInp != number)
        {
            Console.WriteLine("Введи число: ");
            string text = Console.ReadLine();

            if (!int.TryParse(text, out userInp))
            {
                Console.WriteLine("Введите обычное число!");
                continue;
            }

            count++;

            if (userInp < number)
            {
                Console.WriteLine("Загаданное число больше!");
            }
            else if (userInp > number)
            {
                Console.WriteLine("Загаданное число меньше!");
            }
            else
            {
                Console.WriteLine("Поздравляю! Ты угадал!");
                Console.WriteLine("Количество попыток: " + count);
            }
        }

        Console.WriteLine("Игра окончена!");
    }
}