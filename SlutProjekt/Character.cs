public class Character
{
    public string Name;
    public int HitPoints;
    public int Damage;

    public Character(string name, int hitPoints, int damage)
    {
        Name = name;
        HitPoints = hitPoints;
        Damage = damage;
    }

    public void Attack(Character target)
    {
        target.HitPoints -= Damage;

        if (target.HitPoints < 0)
        {
            target.HitPoints = 0;
        }
    }
}