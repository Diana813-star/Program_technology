using System.Collections.Generic;

namespace ConsoleApp1;

public class InMemoryRepository
{
    private List<Workshop> _workshops;
    private List<Baker> _bakers;
    private List<Bakery> _bakeryItems;

    public InMemoryRepository()
    {
        _workshops = new List<Workshop>()
        {
            new Workshop(1, "Кондитерский", "Петрова А.А."),
            new Workshop(2, "Хлебный", "Иванов И.И."),
            new Workshop(3, "Булочный", "Сидоров С.С."),
            new Workshop(4, "Слоеный", "Кузнецов П.П."),
            new Workshop(5, "Мелкоштучный", "Попова Е.В.")
        };

        _bakers = new List<Baker>()
        {
            new Baker(1, "Петрова А.А.", 5, "Дневная"),
            new Baker(2, "Иванов И.И.", 2, "Ночная"),
            new Baker(3, "Сидоров С.С.", 4, "Дневная"),
            new Baker(4, "Кузнецов П.П.", 1, "Ночная"),
            new Baker(5, "Попова Е.В.", 6, "Дневная")
        };

        _bakeryItems = new List<Bakery>()
        {
            new Bakery(1, "Круассан", 1, 1, 80.0, 100),   
            new Bakery(2, "Батон", 2, 2, 40.0, 400),     
            new Bakery(3, "Булочка", 3, 3, 50.0, 90),
            new Bakery(4, "Пирожок", 4, 4, 60.0, 120),
            new Bakery(5, "Ватрушка", 5, 5, 70.0, 130)
        };
    }

    public List<Workshop> GetWorkshops() => _workshops;
    public List<Baker> GetBakers() => _bakers;
    public List<Bakery> GetBakery() => _bakeryItems;
}
