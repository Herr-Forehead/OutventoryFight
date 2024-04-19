namespace OutventoryFight;

public class Inventory
{
    public List<Item> items = new();

    public void Add(Item item)
    {
        items.Add(item);
    }

    public static void viewInventory(Player player)
    {
        Console.Clear();
        Console.WriteLine(p.name             p.money);
        Console.WriteLine("");
        Console.WriteLine(p.Inventory.items);
        Console.ReadLine();
    }
}
