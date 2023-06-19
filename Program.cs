using System;

public class Program
{
    public  void Main()
    {
       int number =10;//eksplisit
       var number2 =10;//inplisit
       
       /*
       Number data type 
       tipe data number dibagi menjadi 2: 
       *Integer Types :
       -byte 8bit 
       -short 16bit 
       -long 64bit
       *floating point type:
       -float32 bit 
       -double 64bit decimal 128bit 
       */

     /*
       Unsigned type number(hanya menerima angka positif)
        -Integer types
        - ushort
        - uint
        - ulong
       */

        ushort unsignShortNumber =10;
        uint unsignedInteger =101212;
        ulong unsignedLong =1043434134434212L;



       
       //integer types
       byte byteNumber = 128;
       short shortNumber = 10000;
       int intNumber=1800000;
       long longNumber =100000000l;
       
       //floating point types :
       float floatNumber = 12345.6f;
       double doubleNumber = 123456789.6d;

//     /*
//     String data types
//     */
    
//     char myChar = 'a';
//     string fullName = 'afiifatuts tsaaniyah abdullah';

   // //Escape character
   // string text = "This is \" string \" ";
   // //Verbatim strings
    // string path = @"\\mypc\shared\project";
    // Console.WriteLine(path);
    // Console.WriteLine(@"1. Belajar
    // 2. Makan
    // 3.Tidur");
    
    //Concatenation
    string nama = "afiifatuts" +" tsaaniyah";

    //string interpolation
    string firstName = "afiifatuts";
    string lastName ="tsaaniyah";
    string fullName2 = $"{firstName} {lastName}";
    Console.WriteLine(nama);
    Console.WriteLine(fullName2);

}
}
