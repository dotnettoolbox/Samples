using Microsoft.Extensions.DependencyInjection;
using HotChocolate;

namespace GraphQlApi.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddMyGraphQlServer(this IServiceCollection services)
        {
             services.AddGraphQLServer()
             .AddQueryType(q=>q.Name("northwind"))
             .AddTypeExtension<QueryTypes.EmployeeGraphQlType>()
             .AddTypeExtension<QueryTypes.CustomerQueryType>()
             .AddProjections()
             .AddFiltering();
            
             
        }
        
    }
}