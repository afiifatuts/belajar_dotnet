namespace FundamentalUpskilling;


/*
Sebagai gambaran saja karena belum ada bentuknya
Perbedaan antara virtual dan abstract : virtual itu pewarisan sebuah method/attribut namun tidak wajib di override,
kalau abstract karena bodynya kosong itu wajib di override
*/
public abstract class Shape
{
    public abstract double GetSurface();
}

public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Length { get; set; }

    public override double GetSurface()
    {
        return Width * Length;
    }

    public double GetArea()
    {
        return 0.1;
    }
}

public class Triangle : Shape
{
    private double Base { set; get; }
    private double Height { set; get; }
    public override double GetSurface()

    {
        return 0.5 * Base * Height;
    }

}

public class Program
{
    public static void Main(string[] args)
    {
        //Abstract class tidak bisa kita instance,namun kita bisa buat sebagai tipe data
        //Shape shape = new Shape(); -> ini error

        Shape rectangle = new Rectangle();
        rectangle.GetSurface();
        // rectangle.GetArea()-> error
        Rectangle rectangle2 = new Rectangle();
        rectangle2.GetSurface();
        rectangle2.GetArea();
    }
}