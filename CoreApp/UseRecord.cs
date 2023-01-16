namespace CoreApp;

public class UseRecord
{
    public decimal CalculateDiscount(Order order)
    {
        return order switch
        {
            { Item.Name.Length: > 10, Item.Name.Length: > 1000 } => 0.10m,
            { Item.Count: > 5, Cost: > 500.00m } => 0.05m,
            { Cost: > 250.00m } => 0.02m,
            null => throw new ArgumentNullException(nameof(order), "Can't calculate discount on null order"),
            var someObject => 0m
        };
    }

    public decimal CalculateDiscount2(Order2 order)
    {
        return order switch
        {
            { Item: > 10, Cost: > 1000.00m } => 0.10m,
            (> 5, > 50.00m) => 0.05m,
            { Cost: > 250.00m } => 0.02m,
            null => throw new ArgumentNullException(nameof(order), "Can't calculate discount on null order"),
            var someObject => 0m
        };
    }

    public void Test(Order order1, Order order2)
    {
        var s = (order1, order2) switch
        {
            ({ Item.Name: not null, Item.Count: 1 }, { Item.Name: not null, Item.Count: 1 }) => "",
            ({ Item.Name: null, Item.Count: 1 }, { Item.Count: 1, Item.Name: not null,  }) => "",
        };
    }
}

public record Order(Item Item, decimal Cost);

public record Order2(int Item, decimal Cost);

public struct Item
{
    public int Count;
    public string Name;
}