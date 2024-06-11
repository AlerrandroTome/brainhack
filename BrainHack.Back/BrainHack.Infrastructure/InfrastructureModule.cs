using BrainHack.Infrastructure.Persistence.Configuration;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;

namespace BrainHack.Infrastructure
{
    public static class InfrastructureModule
    {
        public static IServiceCollection AddMongoDBConfig(this IServiceCollection services, IConfiguration configuration)
        {
            return services.Configure<MongoDBSettings>(configuration.GetSection("MongoDBSettings"));
        }
    }
}