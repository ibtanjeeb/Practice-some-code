
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SqlPratctice_class_16
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = "Server=.\\;Database=ADO.net;Trusted_Connection=True;";
            var productsQuery = "select * from products";
            var products = ExecuteQury(connectionString, productsQuery);
            Console.WriteLine("Product List");
            foreach (var product in products)
            {
                Console.WriteLine($"{product.Id} / title - {product.Title}, available - {product.IsAvailable}, created on - {product.CreatedOn} , quantity - {product.AvailableQuantity}");
            }

        }


        public static List<Product> ExecuteQury(string connectionString, string sql)
        {
            using SqlCommand command = new SqlCommand();
            command.Connection = GetCommand(connectionString);
            command.CommandText = sql;
            var reader = command.ExecuteReader();

            List<Product> products = new List<Product>();
            while (reader.Read())
            {
                var id = (int)reader[0];
                var title = (string)reader[1];
                var price = (decimal)reader[2];
                var isAvailable = (bool)reader[3];
                var createdOn = (DateTime)reader[4];
                var availableQuantity = (int)reader[5];

                products.Add(new Product
                {
                    Id = id,
                    Title = title,
                    IsAvailable = isAvailable,
                    CreatedOn = createdOn,
                    AvailableQuantity = availableQuantity
                });

            }
            return products;
        }

        private static SqlConnection GetCommand(string connectionString)
        {

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }

            return connection;

        }
        public class Product
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public decimal Price { get; set; }
            public bool IsAvailable { get; set; }
            public DateTime CreatedOn { get; set; }
            public int AvailableQuantity { get; set; }
        }

    }
}
