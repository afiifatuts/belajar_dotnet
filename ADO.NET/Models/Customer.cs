namespace FundamentalUpskilling.ADO.NET.Models;

public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string PhoneNumber { get; set; }
    public bool IsActive { get; set; }

    public override string ToString()
    {
        return $"Customer ID: {Id}\nName: {Name}\nPhone Number: {PhoneNumber}\nIs Active: {IsActive}";
    }
}