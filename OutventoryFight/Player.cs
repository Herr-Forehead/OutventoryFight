namespace OutventoryFight;

public class Player : Character
{
    public int Hitroll = Random.Shared.Next(101);
    public void HitChance(Player player)
    {
        int HitChance = player.Hitroll+player.luck;
    }
    // method for hitchance
}