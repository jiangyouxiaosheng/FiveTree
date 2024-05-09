using Fight;

public class BuffFactory
{
    public static BuffBase CreateBuff(string name, CombatEntity c, BuffManager manager)
    {
        BuffBase buff = null;
        if (name == "poisoned")
            buff = CreatePoisoned(c, manager);
        return buff;
    }
    private static BuffBase CreatePoisoned(CombatEntity c, BuffManager manager)
    {
        BuffBase poisoned = new PoisonedBuff(manager, c);
        return poisoned;
    }
}
