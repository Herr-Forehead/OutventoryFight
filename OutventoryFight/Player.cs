namespace OutventoryFight;

public class Player : Character
{
    public int Hitroll = generator.Next(101);
    public static void HitChance()
    {
        int HitChance = Hitroll+Character.luck;
    }
}