using System.Linq;
using HotChocolate;
using HotChocolate.Types;

namespace GraphQlApi.QueryTypes
{
    [ExtendObjectType(Name="northwind")]
    public class EmployeeGraphQlType
    {
          public IQueryable<northwinddb.Models.Employee> GetEmployees([Service]northwinddb.Context.NorthWindDBContext dBContext)
       {
           return dBContext.Employees.AsQueryable();
       }
    }
}