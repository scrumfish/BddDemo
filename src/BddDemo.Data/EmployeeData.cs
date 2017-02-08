using System.Collections.Generic;
using System.Linq;
using BddDemo.Entities;
using BddDemo.Objects;

namespace BddDemo.Data
{
    public class EmployeeData : DataBase, IEmployeeData
    {
        public vEmployee GetById(int id)
        {
            using (var context = GetContext())
            {
                return context.vEmployees.FirstOrDefault(e => e.BusinessEntityID == id);
            }
        }

        public IList<vEmployee> SearchByLastName(string lastName)
        {
            using (var context = GetContext())
            {
                return context.vEmployees.Where(e => e.LastName == lastName).ToList();
            }
        }
    }
}
