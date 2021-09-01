using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> connections { get; private set; } = new List<IDataConnection> ();
        public static void InitializeConnections(bool database, bool textfiles)
        {
            if(database)
            {
                SqlConnector sql = new SqlConnector();
                connections.Add(sql);


            }
            if(textfiles)
            {
                TextConnector text = new TextConnector();
                connections.Add(text);

            }
        }

        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

    }
}
