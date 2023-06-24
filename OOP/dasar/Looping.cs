namespace FundamentalUpskilling;

public class Looping 
{
    public void Main(string[] args)
    {
        /*
        C# itu ada 3 (for loop, while, do while)
        for -> counted loop
        while, do-while -> uncounted loop
        */

        for (var i=0; i < 10 ; i++)
        {
            Console.WriteLine($"Loopingan ke-{i}");
        }

        var j =0;
        while (j>10)
        {
            Console.WriteLine($"Loopingan ke -{j}");
            j++;
        }

        var k =0;
        do 
        {
            Console.WriteLine($"Loopingan ke -{k}");
            k++;
        }while (k<10);


    }
}