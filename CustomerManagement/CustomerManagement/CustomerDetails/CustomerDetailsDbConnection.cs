using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerManagement.CustomerDetails
{
    public class CustomerDetailsDbConnection : DbContext
    {
        public CustomerDetailsDbConnection(DbContextOptions<CustomerDetailsDbConnection> options) : base(options)
        {

        }
        public DbSet<CustomerContactDetails> CustomerContactDetails { get; set; }
        public DbSet<CustomerAddressDetails> CustomerAddressDetails { get; set; }

    }
}
