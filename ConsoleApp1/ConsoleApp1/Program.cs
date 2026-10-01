using System;
using System.Collections.Generic;
using System.IO;
using ConsoleApp1;

namespace ConsoleApp1;

internal class Program
{
    static void Main(string[] args)
    {
        if (args == null) return;

        Console.OutputEncoding = System.Text.Encoding.UTF8;

        List<Workshop> workshops = null;
        List<Baker> bakers = null;
        List<Bakery> bakeryItems = null;

        Console.WriteLine("1 — InMemoryRepository");
        Console.WriteLine("2 — CsvRepository");
        Console.Write("выбор:");

        string input = Console.ReadLine();
        if (input == null)
        {
            Console.WriteLine("Ошибка ввода. Программа завершена.");
            return;
        }

        if (!int.TryParse(input, out int choice))
        {
            Console.WriteLine("Неверно введено Программа завершена.");
            return;
        }

        switch (choice)
        {
            case 1:
                InMemoryRepository inMemRepository = new InMemoryRepository();
                workshops = inMemRepository.GetWorkshops();
                bakers = inMemRepository.GetBakers();
                bakeryItems = inMemRepository.GetBakery();
                break;

            case 2:
                string basePath = @"C:\Users\Пользователь\source\repos\ConsoleApp1\ConsoleApp1\data";
                CsvRepository csvRepository = new CsvRepository(basePath);
                try
                {
                    workshops = csvRepository.GetWorkshops();
                    bakers = csvRepository.GetBakers();
                    bakeryItems = csvRepository.GetBakery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при чтении CSV файлов: {ex.Message}");
                    Console.ReadLine();
                    return;
                }
                break;
        }

        if (bakeryItems == null || bakers == null || workshops == null)
        {
            Console.WriteLine("Данные отсутствуют (один из списков равен null).");
            Console.ReadLine();
            return;
        }

        Console.WriteLine("\nРезультаты обработки данных ");

        Console.Write("1. FindBaker(\"Круассан\"): ");
        Bakery foundItem1 = null;
        foreach (Bakery b in bakeryItems)
        {
            if (b != null && b.Name == "Круассан")
            {
                foundItem1 = b;
                break;
            }
        }

        Baker baker1 = null;
        if (foundItem1 != null)
        {
            foreach (Baker bk in bakers)
            {
                if (bk != null && bk.Id == foundItem1.BakerId)
                {
                    baker1 = bk;
                    break;
                }
            }
        }
        Console.WriteLine(baker1 != null ? baker1.GetInfo() : "null");

        Console.Write("2. FindWorkshop(item \"Круассан\"): ");

        Bakery foundItem2 = null;
        foreach (Bakery b in bakeryItems)
        {
            if (b != null && b.Name == "Круассан")
            {
                foundItem2 = b;
                break;
            }
        }

        Workshop workshop1 = null;
        if (foundItem2 != null)
        {
            foreach (Workshop w in workshops)
            {
                if (w != null && w.Id == foundItem2.WorkshopId)
                {
                    workshop1 = w;
                    break;
                }
            }
        }
        Console.WriteLine(workshop1 != null ? workshop1.GetInfo() : "null");

        int totalWeight = 0;
        foreach (Bakery b in bakeryItems)
        {
            if (b != null)
            {
                totalWeight += b.Weight;
            }
        }
        Console.WriteLine("3. GetTotalWeight(): " + totalWeight + " г");

        Console.Write("4. GetBakerWithMaxWeight: ");
        Dictionary<int, int> weightMap = new Dictionary<int, int>();
        foreach (Bakery b in bakeryItems)
        {
            if (b == null) continue;

            if (weightMap.ContainsKey(b.BakerId))
            {
                weightMap[b.BakerId] += b.Weight;
            }
            else
            {
                weightMap.Add(b.BakerId, b.Weight);
            }
        }

        int maxBakerId = -1;
        int maxWeight = -1;
        foreach (KeyValuePair<int, int> kvp in weightMap)
        {
            if (kvp.Value > maxWeight)
            {
                maxWeight = kvp.Value;
                maxBakerId = kvp.Key;
            }
        }

        Baker maxBaker = null;
        if (maxBakerId != -1)
        {
            foreach (Baker bk in bakers)
            {
                if (bk != null && bk.Id == maxBakerId)
                {
                    maxBaker = bk;
                    break;
                }
            }
        }

        string maxBakerName = (maxBaker != null && maxBaker.FullName != null) ? maxBaker.FullName : "null";
        Console.WriteLine(maxBaker != null ? maxBakerName + " (" + maxWeight + " г)" : "null");

        Console.WriteLine("5. PrintAllBakery:");
        List<string> uniqueNames = new List<string>();
        List<Bakery> uniqueItems = new List<Bakery>();

        foreach (Bakery b in bakeryItems)
        {
            if (b != null && b.Name != null && !uniqueNames.Contains(b.Name))
            {
                uniqueNames.Add(b.Name);
                uniqueItems.Add(b);
            }
        }

        foreach (Bakery item in uniqueItems)
        {
            if (item == null) continue;

            Baker currentBaker = null;
            foreach (Baker bk in bakers)
            {
                if (bk != null && bk.Id == item.BakerId)
                {
                    currentBaker = bk;
                    break;
                }
            }

            Workshop currentWorkshop = null;
            foreach (Workshop w in workshops)
            {
                if (w != null && w.Id == item.WorkshopId)
                {
                    currentWorkshop = w;
                    break;
                }
            }

            string bakerName = (currentBaker != null && currentBaker.FullName != null) ? currentBaker.FullName : "-";
            string workshopName = (currentWorkshop != null && currentWorkshop.Name != null) ? currentWorkshop.Name : "-";
            string itemInfo = item.GetInfo() != null ? item.GetInfo() : "";

            Console.WriteLine(itemInfo + " — пекарь " + bakerName + ", цех \"" + workshopName + "\"");
        }

        Console.Write("\nНе найдено: FindBaker(\"Неизвестное изделие\") -> ");
        Bakery missingItem = null;
        foreach (Bakery b in bakeryItems)
        {
            if (b != null && b.Name == "Неизвестное изделие")
            {
                missingItem = b;
                break;
            }
        }
        Console.WriteLine(missingItem == null ? "null" : "found");

        Console.ReadLine();
    }
}
