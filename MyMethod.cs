namespace FundamentalUpskilling;

public class MyMethod
{
    public void Main(string[] args)
    {
        //Method bisa dibilang sebuah fungsi
        // SayHello();
        // SayHello2(name: "AFii");
        //Console.WriteLine(Sum(a:1, b:2)); ->Langsung print

        int resultSum = Sum(3, 4);
        var implicitResultSum = Sum(10, 40);

        Console.WriteLine(resultSum);
        Console.WriteLine(implicitResultSum);

        //anonymous function(local) - cara pertama
        var print = delegate (string any)
        {
            Console.WriteLine($"Ini adalah anonymous method {any}");
        };

        //anonymous function(local) - cara kedua menggunakan lambda
        var print2 = () =>
        {
            // ()->
            Console.WriteLine("Ini adalah anonymous method menggunakan lambda");
        };

        print("apapun");
        print2();

    }
    /*
    struktur pembuatan method c#
    //access modifier
    //static/non-static
    //returnType(void/tipe data apapun), void tidak mengembalikan data apapun
    //NamaMethod(parameter)
    //{}

    access modifier static/non-static returnType(void/tipe data apapun) NamaMethod(parameter)
    {
        //body method
    }

    note: static method hanya bisa dipanggil sesama static method, jika tidak ada maka bisa diakses dengan membuat objectnya
    terlebih dahulu
    */

    static void SayHello()
    {
        Console.WriteLine("Hello world");
    }

    static void SayHello2(string name)
    {
        Console.WriteLine($"Hello, {name}");
    }
    static int Sum(int a, int b)
    {
        //return a+b;
        var result = a + b;
        return result;
    }
}