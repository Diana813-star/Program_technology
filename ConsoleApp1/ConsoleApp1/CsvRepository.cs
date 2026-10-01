using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp1;

/// <summary>
/// Репозиторий для чтения данных сущностей пекарни из CSV-файлов.
/// </summary>
public class CsvRepository
{
    private string _basePath;

    /// <summary>
    /// Конструктор репозитория с указанием пути к папке с файлами.
    /// </summary>
    public CsvRepository(string basePath)
    {
        _basePath = basePath;
    }

    /// <summary>
    /// Вспомогательный метод для проверки существования и валидации файлов.
    /// </summary>
    private string[] ReadValidCsvLines(string filePath)
    {
        if (!File.Exists(filePath))
        {
            throw new FileNotFoundException($"Файл отсутствует по пути: {filePath}");
        }

        if (new FileInfo(filePath).Length == 0)
        {
            throw new Exception($"Файл пуст: {Path.GetFileName(filePath)}");
        }

        return File.ReadAllLines(filePath, System.Text.Encoding.UTF8);
    }

    /// <summary>
    /// Считывает список цехов из файла Workshop.csv.
    /// </summary>
    public List<Workshop> GetWorkshops()
    {
        List<Workshop> result = new List<Workshop>();

        string filePath = Path.Combine(_basePath, "Workshop.csv");

        string[] lines = ReadValidCsvLines(filePath);
        if (lines.Length < 2) return result;

        for (int i = 1; i < lines.Length; i++)
        {
            if (string.IsNullOrWhiteSpace(lines[i])) continue;

            string[] parts = lines[i].Split(',');
            if (parts.Length < 3) continue;

            int id = int.Parse(parts[0]);
            string name = parts[1];
            string head = parts[2];

            result.Add(new Workshop(id, name, head));
        }
        return result;
    }

    /// <summary>
    /// Считывает список пекарей из файла Baker.csv.
    /// </summary>
    public List<Baker> GetBakers()
    {
        List<Baker> result = new List<Baker>();

        string filePath = Path.Combine(_basePath, "Baker.csv");

        string[] lines = ReadValidCsvLines(filePath);
        if (lines.Length < 2) return result;

        for (int i = 1; i < lines.Length; i++)
        {
            if (string.IsNullOrWhiteSpace(lines[i])) continue;

            string[] parts = lines[i].Split(',');
            if (parts.Length < 4) continue;

            int id = int.Parse(parts[0]);
            string fullName = parts[1];
            int experience = int.Parse(parts[2]);
            string shift = parts[3];

            result.Add(new Baker(id, fullName, experience, shift));
        }
        return result;
    }

    /// <summary>
    /// Считывает список изделий из файла Bakery.csv.
    /// </summary>
    public List<Bakery> GetBakery()
    {
        List<Bakery> result = new List<Bakery>();

        string filePath = Path.Combine(_basePath, "Bakery.csv");

        string[] lines = ReadValidCsvLines(filePath);
        if (lines.Length < 2) return result;

        for (int i = 1; i < lines.Length; i++)
        {
            if (string.IsNullOrWhiteSpace(lines[i])) continue;

            string[] parts = lines[i].Split(',');
            if (parts.Length < 6) continue;

            int id = int.Parse(parts[0]);
            string name = parts[1];
            int workshopId = int.Parse(parts[2]);
            int bakerId = int.Parse(parts[3]);
            double price = double.Parse(parts[4], System.Globalization.CultureInfo.InvariantCulture);
            int weight = int.Parse(parts[5]);

            result.Add(new Bakery(id, name, workshopId, bakerId, price, weight));
        }
        return result;
    }
}

