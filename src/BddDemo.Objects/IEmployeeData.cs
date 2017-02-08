using System.Collections.Generic;
using BddDemo.Entities;

namespace BddDemo.Objects
{
    public interface IEmployeeData
    {
        vEmployee GetById(int id);
        IList<vEmployee> SearchByLastName(string lastName);
    }
}
