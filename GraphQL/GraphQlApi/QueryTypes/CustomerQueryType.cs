using System.Linq;
using HotChocolate;
using HotChocolate.Types;

namespace GraphQlApi.QueryTypes
{

     [ExtendObjectType(Name="northwind")]
    public class CustomerQueryType
    {
        
        public IQueryable<northwinddb.Models.Customer> GetCustomers([Service]northwinddb.Context.NorthWindDBContext dBContext)
       {
           return dBContext.Customers.AsQueryable();
       }
    }
}