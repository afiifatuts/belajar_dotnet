namespace FundamentalUpskilling;

public class MyNullable
{
    public  void Main(string[] args)
    {
        //int number = null;
        //struct punyanya microsoft yaitu Nullable<T> -> Generic
        // cara pertama membuat varable/parameter null
        Nullable<int> number = null;

        // cara singkat/shorthand kita menggunakan operator optional(?)
        int? anotherNumber = null;

        //string itu null intu berbeda dengan string kosong ("")

        Console.WriteLine(number);
        Console.WriteLine(anotherNumber);

        //C# ini mendukung null safety

        if (anotherNumber.HasValue)
        {
            Console.WriteLine(anotherNumber.Value);
        }
        else
        {
            Console.WriteLine("error: data kosng");
        }

        SayHello(null);
        SayHello("Tsaani");
    }

    public  void SayHello(string? name)
    {
        //is, not, or, and
        if (name is not null)
        {
            Console.WriteLine($"Hello, {name}");
        }
    }
}