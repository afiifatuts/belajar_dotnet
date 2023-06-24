using FundamentalUpskilling.ADO.NET.Models;
using Npgsql;

namespace FundamentalUpskilling.ADO.NET.Repository;

public class CustomerRepository : ICustomerRepository
{
    private readonly NpgsqlConnection? _pgsqlConnection;

    public CustomerRepository(string connectionString)
    {
        _pgsqlConnection = new NpgsqlConnection(connectionString);
    }

    public void GenerateTable()
    {
        try
        {
            _pgsqlConnection.Open();
            System.Console.WriteLine("Database connected successfully");
            string createTable = (@"CREATE TABLE m_customer(
                id INT PRIMARY KEY,
                name VARCHAR(48),
                phone_number VARCHAR(14),
                is_active boolean
            );");
            using (NpgsqlCommand command = new NpgsqlCommand(createTable, _pgsqlConnection))
            {

                //Execute Non Query : digunakan untuk query (DDL, DML)
                command.ExecuteNonQuery();
                System.Console.WriteLine("Table m_customer created successfully");
            }
        }

        catch (Exception e)
        {

            System.Console.WriteLine(e);
        }
        finally
        {
            _pgsqlConnection?.Close();
        }
    }
    public void Save(Customer customer)
    {
        try
        {
            _pgsqlConnection.Open();
            string sql = @"INSERT INTO m_customer(id, name, phone_number, is_active)
                            VALUES (@id,@name,@phone_number,true);";
            var id = int.Parse(Console.ReadLine());
            var name = Console.ReadLine();
            var phone_number = Console.ReadLine();
            using (NpgsqlCommand command = new NpgsqlCommand(sql, _pgsqlConnection))
            {
                // command.Parameters.AddWithValue("@id", customer.Id);
                // command.Parameters.AddWithValue("@name", customer.Name);
                // command.Parameters.AddWithValue("@phone_number", customer.PhoneNumber);

                var execute = command.ExecuteNonQuery(); //ddl & dml
                System.Console.WriteLine(execute > 0 ? "Customer created successfully" : "Failed insert table");
            }
        }
        catch (Exception e)
        {

            System.Console.WriteLine(e);
        }
        finally
        {
            _pgsqlConnection?.Close();
        }
    }

    public Customer? FindById(int id)
    {
        Customer customer = null;
        try
        {
            _pgsqlConnection.Open();
            string sql = "SELECT * FROM m_customer WHERE id = @id;";
            NpgsqlCommand command = new NpgsqlCommand(sql, _pgsqlConnection);

            command.Parameters.AddWithValue("@id", id);
            var dataReader = command.ExecuteReader();

            if (dataReader.Read())
            {
                customer = new Customer
                {
                    Id = dataReader.GetInt32(0),
                    Name = dataReader.GetString(1),
                    PhoneNumber = dataReader.GetString(2),
                    IsActive = dataReader.GetBoolean(3),
                };
            }
            else
            {
                System.Console.WriteLine("Customer not found");
            }



        }
        catch (Exception e)
        {

            System.Console.WriteLine(e);
        }
        finally
        {
            _pgsqlConnection?.Close();
        }
        return customer;
        // throw new NotImplementedException();
    }



    public List<Customer> FindAll()
    {
        var customers = new List<Customer>();
        try
        {
            _pgsqlConnection.Open();
            const string sql = "SELECT * FROM m_customer";

            NpgsqlCommand command = new NpgsqlCommand(sql, _pgsqlConnection);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                customers.Add(new Customer
                {
                    Id = Convert.ToInt32(reader["id"]),
                    Name = reader["name"].ToString(),
                    PhoneNumber = reader["phone_number"].ToString(),
                    IsActive = Convert.ToBoolean(reader["is_active"]),

                });
            }
        }
        catch (System.Exception)
        {

            throw;
        }
        return customers;
    }
    public void Update(Customer customer)
    {
        throw new NotImplementedException();
    }
    public void DeleteById(int id)
    {
        throw new NotImplementedException();
    }
}
