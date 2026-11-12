using System;

public class AssociationNumber
{
    public void Association(int number)
    {
        string text = number.ToString();

        if (text.Contains("1"))
            Console.WriteLine("В числе есть цифра, которая ассоциируется с серым цветом");

        if (text.Contains("2"))
            Console.WriteLine("В числе есть цифра, которая ассоциируется с красным цветом");

        if (text.Contains("3"))
            Console.WriteLine("В числе есть цифра, которая ассоциируется с желтым цветом");

        if (text.Contains("4"))
            Console.WriteLine("В числе есть цифра, которая ассоциируется с ораньжевым цветом");

        if (text.Contains("5"))
            Console.WriteLine("В числе есть цифра, которая ассоциируется с розовым цветом");

        if (text.Contains("6"))
            Console.WriteLine("В числе есть цифра, которая ассоциируется с зеленым цветом");

        if (text.Contains("7"))
            Console.WriteLine("В числе есть цифра, которая ассоциируется с синим цветом");

        if (text.Contains("8"))
            Console.WriteLine("В числе есть цифра, которая ассоциируется с коричневым цветом");

        if (text.Contains("9"))
            Console.WriteLine("В числе есть цифра, которая ассоциируется с фиолетовым цветом");

        if (text.Contains("0"))
            Console.WriteLine("В числе есть цифра, которая ассоциируется с белым цветом");
    }
}