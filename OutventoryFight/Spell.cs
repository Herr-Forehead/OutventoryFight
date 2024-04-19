namespace OutventoryFight;

public class Spell : Item
{
    public int baseDmg;
    public static void damage()
    {
        int spellAttackDmg = Spell.baseDmg + Character.Int;
        Enemy.currentHp -= spellAttackDmg;
    }
}
