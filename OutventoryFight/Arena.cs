namespace OutventoryFight;

public class Arena
{
    public static void arenaFight()
    {
        string arenaChoice;
        Console.Clear();
        Console.WriteLine("Welcome to the Arena!");
        Console.WriteLine("Do you wish to fight?");
        arenaChoice = Console.ReadLine();
        if(arenaChoice == "yes" || arenaChoice == "y")
        {
            Console.WriteLine();
        }
    }
}