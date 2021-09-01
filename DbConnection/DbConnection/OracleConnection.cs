using System;

namespace DbConnection
{
    public class OracleConnection : DBConnection
    {
        public OracleConnection(string connectionString)
            : base(connectionString)
        {
            
        }
        public override void Close()
        {
            Console.WriteLine("Closing the connection to Oracle");

        }
        public override void Open()
        {
            base.Open();
            Console.WriteLine("opening conection to Oracler");
            Console.WriteLine($"Oracle has no Timeout");

        }
    }
}
