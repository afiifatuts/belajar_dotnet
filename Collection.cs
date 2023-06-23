namespace FundamentalUpskilling;
using System;
using System.Collections;

public class Collection
{
    public static void Main(string[] args)
    {
        /*


        Collection mirip array dan banyak macamnya
        keunggulan dari collection
        - menambah data terus menerus
        - flexible
        - kita bisa mengoperasikan CRUD(menimpan data, update, delete, retrieve, sort)
        
        Collection ada 3 tipe
        1) Generic -> biasa dipakai
        2) Tipe Class -> satu contoh HashTable -> contohnya dictionary
        3) List -> ArrayList -> Jarang dipakai

        System.Collections.Generic
        - List x
        - Stack
        - Queue
        - LinkedList
        - HashSet x
        - SortedSet x
        - DIctionary x 
        - SortedDictionary x
        - SortedList x
        */

        /*
        List : ini mirip sama array bedanya dia flexible dan lebih mudah kita operasikan crud
        HashSet : untuk menyimpan data, hanya menyimpan unique value
        Hashtable: yang menyimpan datanya berupa key dan valu
        Dictionary: menyimpan data berupa key dan value - bedanya generic
        */





    }

    private static void Sort()
    {
        var sortedList = new SortedList(){
            {1,"jakarta"},
            {2,false},
            {3,1}
        };

        var sortedDictionary = new SortedDictionary<string, string>();

        var sortedHash = new SortedSet<string>();

        sortedHash.Add("Jution");
        sortedHash.Add("Jution");
        sortedHash.Add("Doni");

        foreach (DictionaryEntry o in sortedList)
        {
            System.Console.WriteLine($"Key: {o.Key} - Value: {o.Value} ");
        }

        foreach (var o in sortedHash)
        {
            System.Console.WriteLine($"Value: {o} ");
        }


    }

    private static void Dictionary()
    {
        //contoh Dictionary generic yang mirip hashtable
        var cities = new Dictionary<string, string>();
        cities.Add("Indonesia", "Jakarta");
        cities.Add("Thailand", "Bangkok");
        cities.Add("Malaysia", "Kuala Lumpur");

        foreach (var pair in cities)
        {
            System.Console.WriteLine($"Key: {pair.Key} - Value: {pair.Value}");
        }
        System.Console.WriteLine("After");
        //cities[true] =1 ->salah
        cities["Indonesia"] = "Surabaya";
        foreach (var pair in cities)
        {
            System.Console.WriteLine($"Key: {pair.Key} - Value: {pair.Value}");
        }

    }
    public static void Hashtable()
    {
        System.Console.WriteLine("Add");

        var hashtable = new Hashtable();
        hashtable.Add(1, "Jakarta");
        hashtable.Add("2", 1);
        hashtable.Add(true, false);

        foreach (DictionaryEntry entry in hashtable)
        {
            System.Console.WriteLine($"Key: {entry.Key} - Value: {entry.Value}");
        }

        //update hashtable
        System.Console.WriteLine("Update");

        hashtable[1] = "Bandung";
        hashtable["2"] = 5;
        hashtable[true] = "true";

        foreach (DictionaryEntry entry in hashtable)
        {
            System.Console.WriteLine($"Key: {entry.Key} - Value: {entry.Value}");
        }


        //delete hashtable
        System.Console.WriteLine("Delete");

        hashtable.Remove(true);

        foreach (DictionaryEntry entry in hashtable)
        {
            System.Console.WriteLine($"Key: {entry.Key} - Value: {entry.Value}");
        }


    }
    public static void HashSet()
    {

        var names = new HashSet<string>();
        names.Add("Jution");
        names.Add("Stefano");
        names.Add("Fadli");
        names.Add("Fadli");

        //update hashset 
        //step 1 - hapus datanya
        //step 2 - tambahkan ulang

        //cara pertama
        names.Remove("Jution");

        //cara kedua
        names.RemoveWhere(s => s.Equals("Stefano"));

        names.Add("Doni");
        foreach (var name in names)
        {
            System.Console.WriteLine(name);
        }

        foreach (var name in names)
        {
            if (name.Equals("Doni"))
            {
                System.Console.WriteLine($"Cari satuan: {name}");
            }
        }

    }
    private void List()
    {
        //cara pertama
        List<int> numbers = new List<int>();
        numbers.Add(1);
        numbers.Add(2);
        numbers.Add(3);

        foreach (var number in numbers)
        {
            System.Console.WriteLine($"angka{number}");
        }

        // cara kedua - mengisi langsung
        var cities = new List<string>
        {
            "jakarta",
            "bandung",
            "depok"
        };
        // //update element list di c#
        // cities[2] = "medan";
        // cities.RemoveAt(0); //menghapus by index
        // cities.Remove("medan");

        // for (int i = 0; i < cities.Count; i++)
        // {
        //     //cities.Get(i)->salah
        //     System.Console.WriteLine(cities[i]); //benar
        // }
        // System.Console.WriteLine(cities);
    }
    private static void UpdateCity(List<string> cities)
    {
        for (int index = 0; index < cities.Count; index++)
        {
            var city = cities[index];
            System.Console.WriteLine($"Start {index + 1} city : {city}");
        }

        System.Console.Write("inputkan kata yang dihapus");

        var input = int.Parse(Console.ReadLine());

        for (int i = 0; i < cities.Count; i++)
        {
            if (i != input - 1) continue;
            var inputUpdate = Console.ReadLine();
            cities[i] = inputUpdate;
        }

        foreach (var city in cities)
        {
            System.Console.WriteLine($"Final city : {city}");
        }
    }




}