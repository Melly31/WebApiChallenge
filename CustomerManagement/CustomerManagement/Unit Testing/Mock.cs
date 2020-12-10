using System;
using System.Collections.Generic;
using CustomerManagement.Models;

namespace CustomerManagement.Unit_Testing
{
    internal class Mock<T>
    {
        private List<CustomerDetails> list;

        public Mock(List<CustomerDetails> list)
        {
            this.list = list;
        }

        public object GetDetails(int v)
        {
            throw new NotImplementedException();
        }

        internal List<CustomerDetails> GetTestDetails()
        {
            throw new NotImplementedException();
        }
    }
}