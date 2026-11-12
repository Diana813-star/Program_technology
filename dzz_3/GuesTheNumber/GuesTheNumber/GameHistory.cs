using System;
using System.IO;

public class GameHistory
{
    public void SaveResult(int number, bool win)
    {
        string result = "Проигрыш";

        if (win)
        {
            result = "Победа";
        }

        File.AppendAllText("history.txt",
            "Число: " + number + " результат: " + result + "\n");
    }
}