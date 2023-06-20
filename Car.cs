namespace FundamentalUpskilling;

/*
 class -> blueprint
 object -> respresentasi dari class/blueprint yang kita buat
 dengan oop kita bisa membuat kode menjadi reusable

 attribute/propery -car : kaca, ban, warna, bahan bakar, mesin
 method -car: berjalan, mengisi bensin

jika membuat atribut di C# tidak menggunakan access modifier dia tidak bisa diakses

ada 4 pilar oop:
- Encapsulation (bungkus)
- Polymprphism (banyak bentuk)
- Abstraction
- Inheritance (pewarisan)

access modifier 4
- public -> Bisa diakses dimanapun class apapun file apapun
- privat -> private hanya bisa diaksess oleh dirinya sendiri
- protected -> bisa diakses di devide/child/turunan atau dirinya sendiri (berhubungan dengan inheritance)
- internal -> hanya bisa diakses di project yang sama

*/

public class Car
{
    //kalau setter divalidasi
    public string Color { get; set; }
    public string Brand { get; set; }
    public int Fuel { get; set; }

    //penulisan atribut dgn pascal case
    // private string _color;
    // private string _brand;
    // private int _fuel;

    // //cara ke 2
    // public string Color
    // {
    //     get { return _color; }
    //     set
    //     {
    //         if (value is not "") _color = value;
    //     }
    // }




    //constructor = pembangun saat object dibuat 
    // ->method yang namanya itu sama dengan nama class, dan method
    //constructor itu akan dipanggil atau dijalankan saat kita instance object

    //parameter constructor
    // public Car(string color, string brand, int fuel)
    // {
    //     //  this.Color = color; //jarang dipakai
    //     Color = color;
    //     Brand = brand;
    //     Fuel = fuel;
    // }
    // //default constructor -> constructor tanpa parameter

    // public Car()
    // {
    // }

    //cara pertama
    // public string GetColor()
    // {
    //     return _color;
    // }

    // public void SetColor(string color)
    // {
    //     _color = color;
    // }

}

// public class Program
// {
//     public  void Main(string[] args)
//     {
//         //object - instance object - membuat object
//         //Car ayla = new Car("red", "toyota", 20);
//         //ayla.Fuel = 20;
//         //Console.WriteLine(ayla.GetColor());
//         // Console.WriteLine(ayla.Brand);
//         // Console.WriteLine(ayla.Fuel);

//         //implisit
//         //var supra = new Car("black", "toyota", 25);
//         //supra.Fuel = 25;
//         //Console.WriteLine(supra.GetColor());
//         // Console.WriteLine(supra.Brand);
//         // Console.WriteLine(supra.Fuel);

//         //direct access - kurang bagus
//         var rush = new Car
//         {
//             Color = "Wite",
//             Brand = "Toyota",
//             Fuel = 30
//         };
//         rush.Color = "White";
//         Console.WriteLine(rush.Color);
//         Console.WriteLine(rush.Brand);
//         Console.WriteLine(rush.Fuel);
//         // rush.Brand = "Toyota";
//         // rush.Fuel = 30;

//     }


// }