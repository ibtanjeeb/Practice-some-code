using TrackerLibrary.DataAccess;
using TrackerLibrary.Models;

namespace System.Data
{
    internal class SqlClient
    {
        internal class SqlConnection : IDataConnection
        {
            private string v;

            public SqlConnection(string v)
            {
                this.v = v;
            }

            public PrizeModel CreatePrize(PrizeModel model)
            {
                throw new NotImplementedException();
            }
        }
    }
}