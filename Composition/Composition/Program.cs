using System;

namespace Composition
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbmigrater = new DbMigrator(new Logger());
            var logger = new Logger();
            var install = new Installer(new Logger());


            dbmigrater.Migrate();
            install.Install();

        }
    }
}
