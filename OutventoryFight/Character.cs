namespace OutventoryFight;

public class Character
{

    public string name;
    public Inventory Inventory = new();
    public int Maxhp;
    public int currentHp;
    public int MaxMp;
    public int currentMp;
    public int strength;
    public int money = 50;
    public int luck;
}
