namespace FundamentalUpskilling;

public class Conditional 
{
    public void Main(string[] args)
    {
        /*
        if (condition - bool)
        {
            statement
        }
        */

        // int i =10;
        // int j =20;
        // if (i <j )
        // {
        //     Console.WriteLine("i is less than j");
        // } else if (i > j)
        // {
        //     Console.WriteLine();
        // }
        // else
        // {
        //     Console.WriteLine();
        // }
    
    var grade = 'A';

    //penyederhanaan if else statement
    switch (grade)
    {
        case 'A':
        Console.WriteLine("Excelent");
        break;
        case 'B':
        Console.WriteLine("Good");
        break;
        case 'C':
        Console.WriteLine("Not Bad");
        break;
        case 'D':
        Console.WriteLine("Failed");
        break;
        default:
        Console.WriteLine("Invalid Grade");
        break;
    }
    }
}