namespace FundamentalUpskilling;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    // public static void GetInfo()
    // {
    //     System.Console.WriteLine($"{Name}, {Age}");
    // }

    // public override string ToString()
    // {
    //     return $"{nameof(Age)}:{Age}";
    // }
}

public class Util
{
    public static string Input(string info)
    {
        while (true)
        {
            Console.Write($"{info} :");
            var input = Console.ReadLine();
            if (input is null or "") continue;
            return input;
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        var budi = new Person
        {
            Name = Util.Input("Masukkan Nama Anda")
        };

        Console.WriteLine(budi.Name);

        // Person.Name = "Budi";
        // var budi = new Person();

        // Person.Name = "Andi"; //dibuat satu kali di alamat memori
        // var andi = new Person();
        // budi.Age = 15;
        // andi.Age = 20;

        // Console.WriteLine(Person.Name);
        // Console.WriteLine(budi.ToString());
        // Console.WriteLine(andi.ToString());


        
    }

    
}