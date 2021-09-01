using System;

namespace DbConnection
{
    public class DBConnection
    {
        private readonly string _connectionString;
        public TimeSpan Timeout { get; set; }
        public DBConnection(string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString))
                throw new InvalidOperationException("HHHHHHHHH");
            this._connectionString = connectionString;
        }
        public virtual void Open()
        {
            var starttime = DateTime.Now;
            var end = DateTime.Now;
            CheckTimeout(starttime, end);

        }
        public virtual void Close()
        {

        }
        private  void CheckTimeout(DateTime starttime,DateTime end)
        {
            if (end - starttime >= this.Timeout)
                throw new TimeoutException("The connection is Timeout...");


        }
    }
}
