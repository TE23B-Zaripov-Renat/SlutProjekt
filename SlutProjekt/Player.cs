public class Player : Character
{
    public int Money;
    public int ZombiesKilled;
    public string Weapon;

    public Player(string name) : base(name, 100, 5)
    {
        Money = 0;
        ZombiesKilled = 0;
        Weapon = "Fist";
    }

    public void UpgradeDamage()
    {
        Damage += ZombiesKilled;
    }
}