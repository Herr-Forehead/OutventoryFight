namespace OutventoryFight;

public class Shop
{
    public string shopChoice;
    public static void openShop(Player player, Item peasant, Item potion, Item talisman, Item superUltraNuke)
    {
        string shopChoice;
        Console.Clear();
        Console.WriteLine(player.name + player.money);
        Console.WriteLine("");
        Console.WriteLine("1. Peasant                         2g");
        Console.WriteLine("2. Potion                          10g");
        Console.WriteLine("3. Talisman                        25g");
        Console.WriteLine("4. Super Ultra Nuke                50g");
        Console.WriteLine("What do you want to buy??");
        shopChoice = Console.ReadLine();
        if (shopChoice == "Peasant" || shopChoice == "peasant" || shopChoice == "1")
        {
            player.money -= peasant.cost;
            player.Inventory.Add(peasant);
            Console.WriteLine("Congrats, you bought a Peasant!!");
        }
        else if (shopChoice == "Potion" || shopChoice == "potion" || shopChoice == "2")
        {
            player.money -= potion.cost;
            player.Inventory.Add(potion);
        }
        else if (shopChoice == "Talisman" || shopChoice == "talisman" || shopChoice == "3")
        {
            player.money -= talisman.cost;
            player.Inventory.Add(talisman);
        }
        else if (shopChoice == "Nuke" || shopChoice == "nuke" || shopChoice == "4")
        {
            player.money -= superUltraNuke.cost;
            player.Inventory.Add(superUltraNuke);
        }
        else if (shopChoice == "no")
        {

        }
        else
        {

        }
    }
}
