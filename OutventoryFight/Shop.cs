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
            Character.money -= peasant.cost;
            Character.Inventory.Add(peasant);
            Console.WriteLine("Congrats, you bought a Peasant!!");
        }
        else if (shopChoice == "Potion" || shopChoice == "potion" || shopChoice == "2")
        {
            Character.money -= potion.cost;
            Character.Inventory.Add(potion);
        }
        else if (shopChoice == "Talisman" || shopChoice == "talisman" || shopChoice == "3")
        {
            Character.money -= talisman.cost;
            Character.Inventory.Add(talisman);
        }
        else if (shopChoice == "Nuke" || shopChoice == "nuke" || shopChoice == "4")
        {
            Character.money -= superUltraNuke.cost;
            Character.Inventory.Add(superUltraNuke);
        }
        else if (shopChoice == "no")
        {

        }
        else
        {

        }
    }
}
