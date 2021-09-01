using System;

namespace DbConnection
{
    public class SqlConnection : DBConnection
    {
        public SqlConnection(string connectionString)
            :base (connectionString)
        {
            base.Timeout = TimeSpan.FromSeconds(60);
        }
        public override void Close()
        {
            Console.WriteLine("Closing the connection to Sql server");

        }
        public override void Open()
        {
            base.Open();
            Console.WriteLine("opening conection to sqk server");
            Console.WriteLine($"opening conection to sqk server{base.Timeout}");
        }
    }
}
