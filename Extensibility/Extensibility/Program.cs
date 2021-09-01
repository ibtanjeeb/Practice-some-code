using System;

namespace Extensibility
{

    class Program
    {

        static void Main(string[] args)
        {
            var dbmigrator = new DbMigrator(new FileLogger("E:\\log.txt"));
            dbmigrator.Migrate();
        }
    }
}
