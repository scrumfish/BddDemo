using BddDemo.Entities;
using Employee = BddDemo.Web.Models.Employee;

namespace BddDemo.Web.Extensions
{
    public static class EmployeeMapper
    {
        public static Employee AsEmployeePoco(this vEmployee source)
        {
            if (source == null) return null;
            return new Employee
            {
                LastName = source.LastName,
                FirstName = source.FirstName,
                Id = source.BusinessEntityID
            };
        }
    }
}