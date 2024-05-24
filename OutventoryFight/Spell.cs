namespace OutventoryFight;

public class Spell : Item
{
    public int baseDmg;
    public static void damage(Spell firebolt, Character p)
    {
        int spellAttackDmg = Spell.baseDmg + Character.Int;
    }
}
