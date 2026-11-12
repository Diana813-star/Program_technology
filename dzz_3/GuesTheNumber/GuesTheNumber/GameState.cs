using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class GameState
{
    public void StartGame()
    {
        Console.WriteLine("Игра началась");
    }
    public void WinGame()
    {
        Console.WriteLine("Поздравляю! Ты угадал число!");
    }
    public void LossGame(int number)
    {
        Console.WriteLine("Попытки закончились");
        Console.WriteLine("Правильный ответ: " + number);
    }
    public void GameResult()
    {
        Console.WriteLine("Игра закончена");
    }
}