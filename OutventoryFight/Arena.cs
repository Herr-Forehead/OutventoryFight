namespace OutventoryFight;

public class Arena
{
    public static void arenaFight(Player player, Enemy enemy, Spell Firebolt, Menu menu)
    {
        string arenaChoice;

        Console.Clear();
        Console.WriteLine("Welcome to the Arena!");
        Console.WriteLine("Do you wish to fight?");
        arenaChoice = Console.ReadLine();
        if(arenaChoice == "yes" || arenaChoice == "y")
        {
            string FightChoice;
            string spellChoice;
            while(player.currentHp > 0 && enemy.currentHp > 0)
            {
            FightChoice = Console.ReadLine();
            Console.Clear();
            Console.WriteLine(enemy.currentHp);
            Console.WriteLine("");
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("a) Attack");
            Console.WriteLine("b) Wait");
            Console.WriteLine("c) run");
            Console.WriteLine("");
            Console.WriteLine(player.currentHp);
            if(FightChoice == "a)" || FightChoice == "a" || FightChoice == "attack")
            {
                Console.Clear();
                Console.WriteLine(enemy.currentHp);
                Console.WriteLine("");
                Console.WriteLine("Which spell will you use?");
                Console.WriteLine("a) firebolt");
                Console.WriteLine("b) spark");
                spellChoice = Console.ReadLine();
                if(spellChoice == "a)" || spellChoice == "a" || spellChoice == "firebolt")
                {
                    player.HitChance;
                    if(player.HitChance() > 25)
                    {
                      Firebolt.damage();
                    }
                    else
                    {}
                }

            }
            }
        }
    }
}