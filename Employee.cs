namespace FundamentalUpskilling;

public class Employee
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Division { get; set; }

    public virtual void SayHi(Employee employee)
    {
        Console.WriteLine($"Hi{employee.Name}");
    }
}

/*
Inheritance: pewarisan yang menurunkan attribute ataupun method di OOP
keyword untuk inheritance di C# itu menggunakan titik dua(:)

base keyword itu adalah cara kita untuk mengakses parent class yang sudah diinherit 

overload : membuat method dengan nama yang sama namun parameternya beda
override : overwrite, menuliskan ulang kode method dari pareng dan dituliskan ulang di child classnya
*/

public class Manager : Employee
{
    public override void SayHi(Employee employee)
    {
        Console.WriteLine($"Hi, {employee.Name} , ini manager {Name}");
        // base.SayHi(employee);
    }
}

//public class Supervisor : Employee, Manager -> error karena parent tdk boleh lebih dari 1
public class Supervisor : Employee
{
    //atribut juga bisa di override
    // public override string Name { get; set; }
    public override void SayHi(Employee employee)
    {
        // base.SayHi(employee);
        Console.WriteLine($"Hi, {employee.Name} , ini supervisor {Name}");
    }

    public void SayHello()
    {

    }
}

// public class Program : Object
// {

//     public static void Main(string[] args)
//     {
//         var manager = new Manager();
//         var budi = new Employee
//         {
//             Name = "Budi"
//         };

//         // manager.SayHi(budi);

//         //ini termasuk polymorphism karena banyak bentuk
//         Supervisor andi = new Supervisor();
//         andi.Name = "Andi";
//         andi.SayHello(); //tidak error

//         Employee andi2 = new Supervisor(); // parent ke child
//         andi2.Name = "Andi 2";
//         //andi2.SayHello() -> ini error karena diambil dari Employee

//         object andi3 = new Supervisor();
//         // Supervisor andi3 = new Employee(); -> tidak bisa child ke parent


//         andi.SayHi(budi);


//     }
// }
