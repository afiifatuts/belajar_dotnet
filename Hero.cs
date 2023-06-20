namespace FundamentalUpskilling;

/*
Polymorphism -> poly morphism : banyak bentuk, method overload itu juga termasuk banyak bentuk
Kita bisa membuat method dengan nama yang sama namun parameternya yg berbeda

Syarat Method Overload :
- Membuat nama method yang sama parameter berbeda
- Tidak untuk parameter sama nama return type berbeda
- Bisa membuat jumlah parameter yang sama namun tipe data berbeda

apakah constructor termasuk polymorphism? iya
karena dia method constructor, class dan parameternya berubah berubah

overloading -> termasuk polymorphism menuliskan method dengan nama yg sama namun parameter berbeda

overwriting -> menuliskan method ulang yang sama dengan parennya (kita overwrite)

*/

public class Hero
{
    public string Name { get; set; }
    public int Hp { get; set; }
    public int BaseDamage { get; set; }

    //Method overload
    public void Attack(Hero hero)
    {
        Console.WriteLine($"{Name} attacked {hero.Name}");
        hero.GetHit(BaseDamage);
    }

    public void Attack(Monster monster)
    {
        Console.WriteLine($"{Name} attacked {monster.Name}");
        monster.GetHit(BaseDamage);
    }


    public void GetHit(int demage)
    {
        Console.WriteLine($"{Name} get hit: {demage}");
        Hp -= demage;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        var layla = new Hero
        {
            Name = "Layla",
            Hp = 1000,
            BaseDamage = 200
        };

        var hayabusa = new Hero
        {
            Name = "Hayabusa",
            Hp = 1000,
            BaseDamage = 250
        };

        var minion = new Monster
        {
            Name = "Minion",
            Hp = 600,
            BaseDamage = 100
        };
        layla.Attack(minion);
        Console.WriteLine($"now the score is {minion.Hp}");

        //object interaction
        // layla.Attack(hayabusa);
        // Console.WriteLine($"now the score is {hayabusa.Hp}");

    }
}

// //ternary operator
// var number = 10;
// var result = number > 5 ? true : false;
// Console.WriteLine(result);