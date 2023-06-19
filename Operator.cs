namespace FundamentalUpskilling;

public class Operator
{
    public void Main(string[] arg)
    {
        /*
        Aritmatic Operator 
        (+) (-) (*) (/) (%)
        */
        //tipe data yang aman untuk int dan double
        int a = 10 +20;
        Console.WriteLine(a);
        double b = 10.4 +20;
        Console.WriteLine(b);

        /*
        Assignment Operator
        (=)
        */

        int c =10;
        Console.WriteLine(c);

         /*
        Assignment Comprasion
        <,>,<=,>=, == , !=
        */

        bool d = 10>0;
        Console.WriteLine(d);

        //increment, decrement (x++, x--, ++x, --x)

        Console.WriteLine(++c);

         /*
        Logical Operator
        && ||
        */

        bool e = 10 > 0 && 0 <10;
        Console.WriteLine(e);


    }
}