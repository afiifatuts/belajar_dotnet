namespace FundamentalUpskilling;

public class ExceptionHandling
{
    public static void Main(string[] args)
    {
        /*root class error di C# itu adalah Exception
        error dibagi menjadi 3
        - Runtime Error -> di text ediornya
        - Syntax Error ->type
        - Compile Error -> pas di running


        - DividedByZeroException
        - NullReferenceException

        keyword yang digunakan untuk handle exception
        try, catch, finaly, throw
        */

        try
        {
            try
            {
                var name = FindName();
                System.Console.WriteLine(name);
            }
            catch (System.Exception e)
            {

                System.Console.WriteLine(e.Message); ;
            }
            var name2 = FindName();
            System.Console.WriteLine(name2);

        }
        catch (System.Exception e)
        {

            System.Console.WriteLine(e.Message);
        }
        finally
        {
            System.Console.WriteLine("Ini setelah error");
        }

    }

    private void TryCath()
    {
        try
        {
            var a = 10;
            var b = 0;
            System.Console.WriteLine(a / b);

        }
        catch (System.Exception e)
        {

            // System.Console.WriteLine(e);
            System.Console.WriteLine(e);
            // throw;
        }
        finally
        {
            //block statement finally akan dijalankan ketika error & catch sudah selesai
            System.Console.WriteLine("Ini setelah error");
        }

    }

    public static string FindName()
    {
        List<string> names = new List<string>
        {
            "Jution",
            "Stevano",
            "Doni",
            "Sulton"
        };

        string? tempName = null;
        System.Console.Write("Masukkan nama: ");
        var input = Console.ReadLine();

        foreach (var name in names)
        {
            if (!name.Equals(input)) continue;
            tempName = name;
        }

        if (tempName is null) throw new Exception("name not found");
        return tempName;
    }
}