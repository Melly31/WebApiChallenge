using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerManagement.Models
{
    public class CustomerDetailsDbConnection : DbContext
    {
        public CustomerDetailsDbConnection(DbContextOptions<CustomerDetailsDbConnection> options) : base(options)
        {

        }
        public DbSet<CustomerDetails> CustomerDetails { get; set; }
    }
}
