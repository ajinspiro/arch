using Arch.Domain.Implementations.Entity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Arch.DataAccess
{
    public class ArchDB : DbContext
    {
        public ArchDB(DbContextOptions<ArchDB> options) : base(options) { }

        public DbSet<Contact> Contacts { get; set; }
    }
}
