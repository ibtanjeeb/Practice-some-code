using System;

namespace DbConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            var sqlconnection = new SqlConnection("My sql....");
            var sqlcommad = new DBCommand(sqlconnection, "Drop the mmhghdjj");
            sqlcommad.Execute();

            var oraconnection = new OracleConnection("My sql....");
            var oraclecommad = new DBCommand(oraconnection, "Drop the mmhghdjj");
            oraclecommad.Execute();
            try
            {
                var fakesqlconnection = new SqlConnection("JJksja");
                var fakesqlcommad = new DBCommand(fakesqlconnection, null);
                fakesqlcommad.Execute();


            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);

            }


        }


        
        

        
    }
}
