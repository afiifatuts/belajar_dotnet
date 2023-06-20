namespace FundamentalUpskilling;

public class Input 
{
    public void Main(string[] args)
    {
        //untuk melakukan input dari user di C# kita bisa menggunakan object Console.ReadLine()

        Console.Write("Masukkan kata-kata: ");
        var inputString = Console.ReadLine();

        var inputNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(inputString);
        Console.WriteLine(inputNumber.GetType());
    }
}