using GraphQlApi.QueryTypes;
using Microsoft.Extensions.DependencyInjection;

namespace GraphQlApi.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddMyGraphQlServer(this IServiceCollection services)
        {
            services.AddGraphQLServer()
            .AddQueryType(queryType=>queryType.Name("northwind"))
            .AddTypeExtension<CustomerQueryType>();
            
        }
        
    }
}