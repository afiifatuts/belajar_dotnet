namespace FundamentalUpskilling.ADO.NET.Repository;
using FundamentalUpskilling.ADO.NET.Models;

public interface ICustomerRepository
{
    void GenerateTable();
    void Save(Customer customer);
    Customer? FindById(int id);
    void Update(Customer customer);
    void DeleteById(int id);
    List<Customer> FindAll();
}