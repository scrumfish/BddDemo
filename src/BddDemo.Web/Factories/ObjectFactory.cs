using System;
using BddDemo.Data;
using BddDemo.Objects;

namespace BddDemo.Web.Factories
{
    internal static class ObjectFactory
    {
        public static EmployeeData CreateObject<T>()
        {

                return new EmployeeData();  // do IoC here!
           
        }
    }
}