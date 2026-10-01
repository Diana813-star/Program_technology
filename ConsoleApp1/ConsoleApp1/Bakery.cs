namespace ConsoleApp1;

public class Bakery
{
    public int Id { get;  }
    public string Name { get; private set; }
    public int WorkshopId { get; private set; }
    public int BakerId { get; private set; }
    public double Price { get; private set; }
    public int Weight { get; private set; }

    public Bakery(int id, string name, int workshopId, int bakerId, double price, int weight)
    {
        Id = id;
        Name = name;
        WorkshopId = workshopId;
        BakerId = bakerId;
        Price = price;
        Weight = weight;
    }

    public double PricePerGram => Weight > 0 ? Price / Weight : 0;
    public bool IsHeavy => Weight > 300;

    public string GetInfo()
    {
        return $"\"{Name}\" ({Price} руб., {Weight} г)";
    }
}
