namespace OutventoryFight;

public class Shop
{
    public string shopChoice;
    public static void openShop()
    {
        string shopChoice;
        Console.Clear();
        Console.WriteLine($"{p.name}             {p.money}");
        Console.WriteLine("");
        Console.WriteLine("1. Peasant                         2g");
        Console.WriteLine("2. Potion                          10g");
        Console.WriteLine("3. Talisman                        25g");
        Console.WriteLine("4. Super Ultra Nuke                50g");
        Console.WriteLine("What do you want to buy??");
        shopChoice = Console.ReadLine();
        if (shopChoice == "Peasant" || shopChoice == "peasant" || shopChoice == "1")
        {
            p.money -= peasant.cost;
            p.Inventory.Add(peasant);
            Console.WriteLine("Congrats, you bought a Peasant!!");
        }
        else if (shopChoice == "Potion" || shopChoice == "potion" || shopChoice == "2")
        {
            p.money -= potion.cost;
            p.Inventory.Add(potion);
        }
        else if (shopChoice == "Talisman" || shopChoice == "talisman" || shopChoice == "3")
        {
            p.money -= talisman.cost;
            p.Inventory.Add(talisman);
        }
        else if (shopChoice == "Nuke" || shopChoice == "nuke" || shopChoice == "4")
        {
            p.money -= superUltraNuke.cost;
            p.Inventory.Add(superUltraNuke);
        }
        else if (shopChoice == "no")
        {

        }
        else
        {

        }
    }
}
