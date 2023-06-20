namespace FundamentalUpskilling;

public enum Direction
{
    North,
    East,
    South,
    West
}

public enum Days
{
    Monday, //member monday value adalah 0
    Tuesday, //1
    Wednesday,//2
    Thurshday,//3
    Friday,//4
    Saturday,//5
    Sunday//6
}

public enum Role
{
    Manager,
    Admin,
    Customer
}

public class Types
{
    //accessModifier enum Gender

    public enum Gender
    {
        //untuk penulisan data enum itu PascalCase
        Male,
        Female
    }
    public void Main(string[] args)
    {

        /*
        Enum itu adalah kumpulan data constant
        Gender: Male, Female
        MataAngin:Utara , Timur, Selatan , Barat

        untuk pembuatan enum itu bisa dibuat didalam class ataupun diluar class

        */
        Console.WriteLine(Gender.Female);
        Console.WriteLine(Gender.Male);
        Console.WriteLine(Direction.East);
        Console.WriteLine(Days.Friday);
        Console.WriteLine(GetMale());

        //ini disebutnya casting -> teknik untuk merubah satu tipe data ke tipe data lain
        int maleValue = (int)Gender.Male;
        Console.WriteLine(maleValue);
    
    }

    public static Gender GetMale()
    {
        return Gender.Male;
    }

}