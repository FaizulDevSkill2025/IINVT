using IINVT.Data;
using Microsoft.EntityFrameworkCore;

namespace IINVT.StartupExtension
{
    public static class DatabaseExtensionsHelper
    {
        public static IServiceCollection AddDatabaseExtensionHelper(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(opt =>
            { 
                opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection"), sqlServerOptionsAction => sqlServerOptionsAction.EnableRetryOnFailure());
            
            });

            return services;
        }
        
    }
}
