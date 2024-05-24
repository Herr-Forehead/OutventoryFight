namespace OutventoryFight;

public class Menu
{
    public static void MainMenu(Player player, Item item, Enemy enemy)
    {
        string mainMenuChoice;
        Console.Clear();
        Console.WriteLine(item.Getinfo());
        Console.WriteLine("Welcome to Inventory fight!!! Now that you've made the stupid mistake off starting this stupid game, what do you wish to do? Do you wish to prepare for battle, like a coward? Or do you want to jump right into the fray and win glory in the Wastelands!!!");
        Console.WriteLine("a) view Inventory");
        Console.WriteLine("b) view shop");
        Console.WriteLine("c) enter the Arena");
        Console.WriteLine("d) Quit");
        mainMenuChoice = Console.ReadLine();
        if (mainMenuChoice == "a)" || mainMenuChoice == "a" || mainMenuChoice == "inventory")
        {
            Inventory.viewInventory(player);
        }
        else if (mainMenuChoice == "b)" || mainMenuChoice == "b" || mainMenuChoice == "shop")
        {
            Shop.openShop(player, item);
        }
        else if (mainMenuChoice == "c)" || mainMenuChoice == "c" || mainMenuChoice == "fight")
        {
            Arena.arenaFight(player, enemy);
        }
        else if (mainMenuChoice == "d)" || mainMenuChoice == "d" || mainMenuChoice == "quit")
        {
            Quit.Quitting();
        }
    }
}
