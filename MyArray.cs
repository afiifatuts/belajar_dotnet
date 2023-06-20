namespace FundamentalUpskilling;

public class MyArray
{
    public void Main(string[] args)
    {
        /*
        Array adalah tipe data untuk menyimpan lebih dari satu value
        array index 0 dan elemennya mulai 1
        */

        //explicit declaration array
        int[] numbers = new int[5];
        numbers[0] = 1;
        numbers[1] = 2;
        numbers[2] = 3;
        numbers[3] = 4;
        numbers[4] = 5;
        //  numbers[5] =6; //error index out of bounds
        Console.WriteLine(numbers[0]);

        string[] cities = { "Jakarta", "Bandung", "Surabaya" };
        // cities[3]="Lampung";

        //    for (int i = 0; i < cities.Length; i++)
        //    {
        //     Console.WriteLine($"Kota: {cities[i]}");
        //    }

        // foreach (string city in cities)
        // {
        //   Console.WriteLine($"Kota: {city}");  
        // }

        var anotherNumbers = new int[3];
        anotherNumbers[0] = 3;
        anotherNumbers[1] = 2;
        anotherNumbers[2] = 1;

        var anotherCities = new[] { "Denpasar", "Malang" };

        /*
        Array Multidimensi
        */

        /*
       {
         {1, 2},{3, 4}
       }
       */
        int[,] matrix = new int[2, 2];
        matrix[0, 0] = 1;
        matrix[0, 1] = 2;
        matrix[1, 0] = 3;
        matrix[1, 1] = 4;
        //Console.WriteLine(matrix[0, 0]);

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                int v = matrix[i, j];
                Console.WriteLine(v);
            }
        }

    }
}