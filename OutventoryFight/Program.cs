using OutventoryFight;

string restart = "yes";
Player p = new();
Enemy Bandit = new();
Item potion = new();
Item peasant = new();
Item talisman = new();
Item superUltraNuke = new();

potion.cost = 10;
peasant.cost = 2;
talisman.cost = 25;
superUltraNuke.cost = 50;

Console.WriteLine("What is your name??");
p.name = Console.ReadLine();

while (restart == "yes")
{
    Menu.MainMenu();
}

Console.ReadLine();