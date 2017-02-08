using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure.Interception;
using System.Linq;
using BddDemo.Web.Controllers.api;
using BddDemo.Web.Models;
using TechTalk.SpecFlow;
using Xunit;

namespace BddDemo.Specs
{
    [Binding]
    public class EmployeeFeatureStepDefs : Steps
    {
        private EmployeeSpecValues _values;

        public EmployeeFeatureStepDefs(EmployeeSpecValues values)
        {
            _values = values;
        }

         [Before]
        public void Before()
        {
            _values.Controller = new EmployeeController();
        }

        [Given(@"I select employee (.*) from the website")]
        public void GivenISelectEmployeeFromTheWebsite(int id)
        {
            _values.Id = id;
        }
        
        [When(@"I get")]
        public void WhenIGet()
        {
            _values.Employee = _values.Controller.Get(_values.Id);
        }
        
        [Then(@"the resulting first name will be (.*)")]
        public void ThenTheResultingFirstNameWillBeKim(string firstName)
        {
            Assert.Equal(firstName,_values.Employee.FirstName);
        }
        
        [Then(@"the last name will be (.*)")]
        public void ThenTheLastNameWillBeAbercrombie(string lastName)
        {
            Assert.Equal(lastName,_values.Employee.LastName);
        }

        [Then(@"the id is (.*)")]
        public void ThenTheIdIs(int id)
        {
            Assert.Equal(id, _values.Employee.Id);
        }

        [Given(@"I search on employee")]
        public void GivenISearchOnEmployee()
        {
        }

        [When(@"I get (.*)")]
        public void WhenIGet(string lastName)
        {
            _values.Employees = _values.Controller.SearchByLastName(lastName);
        }

        [Then(@"the resulting collection will contain last name (.*)")]
        public void ThenTheResultingCollectionWillContainLastName(string lastName)
        {
            Assert.True(_values.Employees.Any(e => e.LastName == lastName));
        }

        [Then(@"the resulting collection will contain first name (.*)")]
        public void ThenTheResultingCollectionWillContainFirstName(string firstName)
        {
            Assert.True(_values.Employees.Any(e => e.FirstName == firstName));
        }

        [Then(@"the resulting collection will contain exactly (.*) of (.*)")]
        public void ThenTheResultingCollectionWillContainExactlyOf(int count, int id)
        {
            Assert.Equal(count, _values.Employees.Count(e => e.Id == id));
        }

        [Then(@"the resulting collection will have exactly (.*) items for Last name of (.*)")]
        public void ThenTheResultingCollectionWillHaveExactlyItemsForLastNameOfBaker(int count, string lastName)
        {
            Assert.Equal(count, _values.Employees.Count(e => e.LastName == lastName));
        }

        [Then(@"the resulting collection contains no items that are not (.*)")]
        public void ThenTheResultingCollectionContainsItemsThatAreNotBaker(string lastName)
        {
            Assert.False(_values.Employees.All(e => e.LastName != lastName));
        }


    }
}
