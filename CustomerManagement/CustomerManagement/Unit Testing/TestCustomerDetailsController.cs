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
        public void GetAllProducts_ShouldReturnAllProducts()
        {
            var testProducts = GetTestProducts();
            var controller = new Mock<CustomerDetailsController>(testProducts);

            var result = controller.GetTestProducts() as List<CustomerDetails>;
            Assert.AreEqual(testProducts.Count, result.Count);
        }

        [TestMethod]
        public void GetProduct_ShouldNotFindProduct()
        {
            var controller = new Mock<CustomerDetailsController>(GetTestProducts());

            var result = controller.GetProduct(999);
            Assert.IsInstanceOfType(result, typeof(NotFoundResult));
        }

        private List<CustomerDetails> GetTestProducts()
        {
            var testProducts = new List<CustomerDetails>();
            testProducts.Add(new CustomerDetails { Id = 1, Forename = "Melissa", Surname = "Holmes" });
            testProducts.Add(new CustomerDetails { Id = 2, Forename = "Paul", Surname = "John" });
            testProducts.Add(new CustomerDetails { Id = 3, Forename = "Joe", Surname = "Black" });
            testProducts.Add(new CustomerDetails { Id = 4, Forename = "Gemma", Surname = "Wilson" });

            return testProducts;
        }
    }
}
