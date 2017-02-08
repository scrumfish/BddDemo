using System.Collections.Generic;
using BddDemo.Web.Controllers.api;
using BddDemo.Web.Models;

namespace BddDemo.Specs
{
    public class EmployeeSpecValues
    {
        public EmployeeController Controller { get; set; }
        public int Id { get; set; }
        public Employee Employee { get; set; }
        public IList<Employee> Employees { get; set; }
    }
}
