﻿using OutventoryFight;

string restart = "yes";
Player p = new();
Enemy Bandit = new();
Item potion = new();
Item peasant = new();
Item talisman = new();
Item superUltraNuke = new();
Spell spark = new();
Spell Firebolt = new();

potion.cost = 10;
peasant.cost = 2;
talisman.cost = 25;
superUltraNuke.cost = 50;

Bandit.name = "Ugly";
Bandit.Maxhp = 150;
Bandit.Int = 25;
p.Int = 30;

spark.baseDmg = 5;
Firebolt.baseDmg = 20;

Console.WriteLine("What is your name??");
p.name = Console.ReadLine();

while (restart == "yes")
{
    Menu.MainMenu();
}

Console.ReadLine();