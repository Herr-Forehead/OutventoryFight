﻿namespace OutventoryFight;

public class Character
{
    //  all base stats for characters
    public string name;
    public Inventory Inventory = new();
    public int Maxhp;
    public int currentHp;
    public int MaxMp;
    public int currentMp;
    public int Int;
    public int money = 50;
    public int luck;
}
