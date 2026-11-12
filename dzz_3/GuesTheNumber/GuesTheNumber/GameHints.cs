using System;

public class GameHints:IGameHints
{
    public void ShowHint(int userInp, int number)
    {
        int raznica = Math.Abs(userInp - number);

        if (raznica <= 3)
        {
            Console.WriteLine("Очень близко! Число на расстоянии меньше либо равно 3");
        }
        else if (raznica <= 8)
        {
            Console.WriteLine("Уже рядом! Число на расстоянии меньше либо равно 8");
        }
        else
        {
            Console.WriteLine("Пока далеко! Число на расстоянии больше 9");
        }
    }
}