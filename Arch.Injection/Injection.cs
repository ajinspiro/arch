using Arch.DataAccess;
using Arch.DataAccess.Repository;
using Arch.Domain.Absract.ILogic;
using Arch.Domain.Absract.Repositories.Abstract;
using Arch.Domain.Implementations.Logic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Arch.Injection
{
    public static class Injection
    {
        public static void AddArchDatabase(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<ArchDB>((options) =>
            {
                options.UseSqlServer(connectionString);
            });
        }

        public static void AddAllTypesToDependancyInjectionContainer(this IServiceCollection services)
        {
            services.AddScoped<IContactLogic, ContactLogic>();
            services.AddScoped<IContactRepository, ContactRepository>();
            services.AddScoped<IGroupRepository, GroupRepository>();
        }
    }
}
