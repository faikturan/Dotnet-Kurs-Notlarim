using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace AdoNetDemo
{
    public class ProductDal
    {
        SqlConnection _connection =
            new SqlConnection("Data Source=localhost;Initial Catalog=ETrade;User ID=sa;Password=Onur-1234");

        public List<Product> GetAll()
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("select * from Products", _connection);
            SqlDataReader reader = command.ExecuteReader();

            List<Product> products = new List<Product>();

            while (reader.Read())
            {
                Product product = new Product
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    StockAmount = Convert.ToInt32(reader["StockAmount"]),
                    UnitPrice = Convert.ToDecimal(reader["UnitPrice"])
                };
                products.Add(product);
            }

            reader.Close();
            _connection.Close();
            return products;
        }

        public void Add(Product product)
        {
            ConnectionControl();
            SqlCommand cmd = new SqlCommand("insert into Products values(@name, @unitPrice, @stockAmount)",
                _connection);

            cmd.Parameters.AddWithValue("@name", product.Name);
            cmd.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            cmd.Parameters.AddWithValue("@stockAmount", product.StockAmount);
            cmd.ExecuteNonQuery();
            Console.WriteLine("Product " + product.Name + " added!");
            _connection.Close();
        }

        public void Update(Product product)
        {
            ConnectionControl();
            SqlCommand cmd =
                new SqlCommand(
                    "Update Products set Name=@name, UnitPrice=@unitPrice, StockAmount=@stockAmount where ID=@id",
                    _connection);
            cmd.Parameters.AddWithValue("@name", product.Name);
            cmd.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            cmd.Parameters.AddWithValue("@stockAmount", product.StockAmount);
            cmd.Parameters.AddWithValue("@id", product.Id);
            cmd.ExecuteNonQuery();
            Console.WriteLine("Product " + product.Name + " updated!");
            _connection.Close();
        }

        public void Delete(int id)
        {
            ConnectionControl();
            SqlCommand cmd =
                new SqlCommand(
                    "Delete from Products where Id=@id", _connection);
            cmd.Parameters.AddWithValue("@id", id);
            _connection.Close();
        }

        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }
    }
}