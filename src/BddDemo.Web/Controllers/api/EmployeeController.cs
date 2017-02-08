using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using BddDemo.Objects;
using BddDemo.Web.Extensions;
using BddDemo.Web.Models;

namespace BddDemo.Web.Controllers.api
{
    public class EmployeeController : ApiController
    {
        private IEmployeeData _employeeData;

        private IEmployeeData EmployeeData
        {
            get { return _employeeData ?? (_employeeData = Factories.ObjectFactory.CreateObject<IEmployeeData>()); }
            set { _employeeData = value; }
        }

        [HttpGet]
        public Employee Get([FromUri] int id)
        {
            return EmployeeData.GetById(id)
                .AsEmployeePoco();
        }

        public IList<Employee> SearchByLastName(string lastName)
        {
            return EmployeeData.SearchByLastName(lastName)
                .Select(e => e.AsEmployeePoco())
                .ToList();
        }
    }
}
