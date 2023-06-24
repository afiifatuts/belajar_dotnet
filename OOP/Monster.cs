namespace FundamentalUpskilling;

public class Monster : IHitAble
{
    public string Name { get; set; }
    public int Hp { get; set; }
    public int BaseDamage { get; set; }

    public void Attack(IHitAble hitAble)
    {
        hitAble.GetHit(BaseDamage);
    }


    public void GetHit(int demage)
    {
        Console.WriteLine($"{Name} get hit: {demage}");
        Hp -= demage;
    }
}