using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Newtonsoft.Json.Linq;

namespace Arch.DataAccess
{
    public class ArchDBFactory : IDesignTimeDbContextFactory<ArchDB>
    {
        private const string ConnectionString = "Server=(localdb)\\mssqllocaldb;Database=arch-db;Integrated Security = true";

        public ArchDBFactory()
        {
        }

        public ArchDB CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ArchDB>();

            builder.UseSqlServer(ConnectionString);

            return new ArchDB(builder.Options);
        }
    }
}
