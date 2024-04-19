namespace OutventoryFight;

public class Player : Character
{
    public int Hitroll = Random.Shared.Next(101);
    public static void HitChance(Player player)
    {
        int HitChance = player.Hitroll+player.luck;
    }
}