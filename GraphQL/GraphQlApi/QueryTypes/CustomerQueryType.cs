using System.Linq;
using HotChocolate;
using HotChocolate.Types;
using HotChocolate.Data;

namespace GraphQlApi.QueryTypes
{
    [ExtendObjectType(Name="northwind")]
    public class CustomerQueryType
    {
        [UseProjection]
        [UseFiltering]
        public IQueryable<northwinddb.Models.Customer> GetCustomers
        ([Service]northwinddb.Context.NorthWindDBContext dBContext,string customerId)
        {
            return dBContext.Customers.Where(customer=>customer.CustomerId.Equals(customerId)).AsQueryable();
        }
        
    }
}