namespace ConsoleApp1;

/// <summary>
/// Класс, описывающий производственный цех пекарни.
/// </summary>
public class Workshop
{
    private string _name;
    private string _head;

    public int Id { get; }

    public string Name
    {
        get { return _name; }
        private set { _name = value; }
    }

    public string Head
    {
        get { return _head; }
        private set { _head = value; }
    }

    /// <summary>
    /// Конструктор класса Workshop со всеми параметрами.
    /// </summary>
    public Workshop(int id, string name, string head)
    {
        Id = id;
        _name = name;
        _head = head;
    }

    /// <summary>
    /// Свойство, проверяющее, является ли цех кондитерским.
    /// </summary>
    public bool IsConfectionery => Name == "Кондитерский";

    /// <summary>
    /// Возвращает текстовую информацию о цехе в соответствии с заданием.
    /// </summary>
    public string GetInfo()
    {
        return Name + " (зав.: " + Head + ")";
    }
}
