namespace OutventoryFight;

public class Item
{
    public string name;
    public int cost;
    public string Getinfo()
    {
        return name+ "("+cost+")";
    }
}
