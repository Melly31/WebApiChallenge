using CustomerManagement.Controllers;
using CustomerManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerManagement.Unit_Testing
{
    [TestClass]
    public class TestCustomerDetailsController
    {
        [TestMethod]
        public void GetAllCustomerDetails_ShouldReturnAllCustomerDetails()
        {
            var testDetails = GetTestDetails();
            var controller = new Mock<CustomerDetailsController>(testDetails);

            var result = controller.GetTestDetails() as List<CustomerDetails>;
            Assert.AreEqual(testDetails.Count, result.Count);
        }

        [TestMethod]
        public void GetCustomerDetails_ShouldNotFindCustomerDetails()
        {
            var controller = new Mock<CustomerDetailsController>(GetTestDetails());

            var result = controller.GetDetails(999);
            Assert.IsInstanceOfType(result, typeof(NotFoundResult));
        }

        private List<CustomerDetails> GetTestDetails()
        {
            var testDetails = new List<CustomerDetails>();
            testDetails.Add(new CustomerDetails { Id = 1, Forename = "Melissa", Surname = "Holmes" });
            testDetails.Add(new CustomerDetails { Id = 2, Forename = "Paul", Surname = "John" });
            testDetails.Add(new CustomerDetails { Id = 3, Forename = "Joe", Surname = "Black" });
            testDetails.Add(new CustomerDetails { Id = 4, Forename = "Gemma", Surname = "Wilson" });

            return testDetails;
        }
    }
}
