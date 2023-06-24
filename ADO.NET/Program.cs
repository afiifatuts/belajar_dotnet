using Npgsql;
using FundamentalUpskilling.ADO.NET.Repository;
using FundamentalUpskilling.ADO.NET.Models;


namespace FundamentalUpskilling.ADO.NET;

public class Program
{
    public static void Main(string[] args)
    {
        /*
          Connection- digunakan untuk mengkoneksikan database dengan spesifik driver
          Command - digunakan untuk mengeksekusi operasi query
          Data Reader - digunakan untuk read data yang ada di database
        */

        var connString = "Host=localhost;Username=postgres;Password=blimbeng38;Database=tokonyadia;";
        // NpgsqlConnection? connect = null;
        // connect = new NpgsqlConnection(connString);
        //CreateTableCustomer(connect);
        //SaveCustomer(connect);
        //FindCustomerById(connect);

        ICustomerRepository customerRepo = new CustomerRepository(connString);
        // customerRepo.Save(new Customer
        // {
        //     Id = 2,
        //     Name = "Udin",
        //     PhoneNumber = "081726545452",
        // });

        Customer foundCustomer = customerRepo.FindById(1);
        if (foundCustomer != null)
        {
            Console.WriteLine("Customer found:");
            Console.WriteLine($"ID: {foundCustomer.Id}");
            Console.WriteLine($"Name: {foundCustomer.Name}");
            Console.WriteLine($"Phone Number: {foundCustomer.PhoneNumber}");
            Console.WriteLine($"Is Active: {foundCustomer.IsActive}");
        }
        else
        {
            Console.WriteLine("Customer not found");
        }
        //customerRepo.FindAll().ForEach(System.Console.WriteLine);
    }
    private static void CreateTableCustomer(NpgsqlConnection connect)
    {
        try
        {
            //cara pertama

            connect.Open();
            System.Console.WriteLine("Database connected successfully");
            //connect.Close();

            //cara kedua
            //try with resource -- di java || using statement
            // using (var connect = new NpgsqlConnection(connString))
            // {
            //     connect.Open();
            // }
            string createTable = (@"CREATE TABLE m_customer(
                id INT PRIMARY KEY,
                name VARCHAR(48),
                phone_number VARCHAR(14),
                is_active boolean
            );");
            using (NpgsqlCommand command = new NpgsqlCommand(createTable, connect))
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
            connect?.Close();
        }
    }

    private static void SaveCustomer(NpgsqlConnection connect)
    {
        try
        {
            connect.Open();
            string sql = @"INSERT INTO m_customer(id, name, phone_number, is_active)
                            VALUES (1,'Rifqi','0812345676',true);";
            using (NpgsqlCommand command = new NpgsqlCommand(sql, connect))
            {
                var execute = command.ExecuteNonQuery();
                System.Console.WriteLine(execute > 0 ? "Customer created successfully" : "Failed insert table");
            }
        }
        catch (Exception e)
        {

            System.Console.WriteLine(e);
        }
        finally
        {
            connect?.Close();
        }
    }

    private static void FindCustomerById(NpgsqlConnection connect)
    {
        try
        {
            connect.Open();
            string sql = "SELECT * FROM m_customer WHERE id = @id;";
            using (NpgsqlCommand command = new NpgsqlCommand(sql, connect))
            {
                command.Parameters.AddWithValue("@id", 1);
                var dataReader = command.ExecuteReader();

                if (dataReader.Read())
                {
                    System.Console.WriteLine($"id: {dataReader.GetInt32(0)}, name: {dataReader.GetString(1)}" +
                    $" phoneNumber: {dataReader.GetString(2)}, isActive: {dataReader.GetBoolean(3)} ");
                }
                else
                {
                    System.Console.WriteLine("Customer not found");
                }


            }
        }
        catch (Exception e)
        {

            System.Console.WriteLine(e);
        }
        finally
        {
            connect?.Close();
        }
    }
}