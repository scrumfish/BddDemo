using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BddDemo.Entities;

namespace BddDemo.Data
{
    public class DataBase
    {
        protected AdventureWorksEntities GetContext()
        {
            return new AdventureWorksEntities();
        }
    }
}
