namespace FundamentalUpskilling;

public class ReferenceAndValue
{
    public static void Main(string[] args)
    {
        int a = 10;
        int b = a;
        b = 15;
        Show(a);
        Console.WriteLine(a);
        ShowReference(ref a);
        Console.WriteLine(a);
        Console.WriteLine(b);

        //array itu by reference

        var numbers = new int[] { 1, 2, 3 };
        var anotherNumber = numbers; // alamat memory yang dicopy - copy by reference

        var anotherNumber2 = new int[numbers.Length];
        Array.Copy(numbers, anotherNumber2, numbers.Length);

        anotherNumber[0] = 10;
        anotherNumber2[0] = 20;
        Console.WriteLine(numbers.GetHashCode());
        Console.WriteLine(anotherNumber.GetHashCode());
        Console.WriteLine(anotherNumber2.GetHashCode());

        foreach (var number in numbers)
        {
            Console.Write(number + ",");
        }

        Console.WriteLine();

        foreach (var number in anotherNumber)
        {
            Console.Write(number + ",");
        }

        Console.WriteLine();

        foreach (var number in anotherNumber2)
        {
            Console.Write(number + ",");
        }

        Car ayla = new Car();
        ayla.Brand = "Toyota";

        Car brio = ayla;
        brio.Brand = "Honda";

        System.Console.WriteLine();
        Console.WriteLine(ayla.Brand);
        Console.WriteLine(brio.Brand);
        Console.WriteLine(ayla.GetHashCode());
        Console.WriteLine(brio.GetHashCode());


    }
    //passing by value
    public static void Show(int a)
    {
        a += a;
        System.Console.WriteLine($"variable a didalam method:{a}");
    }

    //passing by Reference
    public static void ShowReference(ref int a)
    {
        a *= a;
        System.Console.WriteLine($"variable a didalam method:{a}");
    }


}

