using System;

namespace DbConnection
{
    public class DBCommand
    {
        private readonly DBConnection _dBConnection;
        private readonly string _sql;
        public DBCommand (DBConnection dBConnection,string sql)
        {
            _dBConnection = dBConnection ?? throw new InvalidOperationException("ddd");
            this._sql = sql ?? throw new InvalidOperationException(">>>");

        }
        public void Execute ()
        {
            _dBConnection.Open();
            Console.WriteLine("JJJJJJ");
            _dBConnection.Close();
        }
    }
}
