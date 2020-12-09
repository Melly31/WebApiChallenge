using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerManagement.Models
{
    public class CustomerDetails
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Forename { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public int AddressLine1 { get; set; }
        public int AddressLine2 { get; set; }
        public int Town { get; set; }
        public int County { get; set; }
        public int Postcode { get; set; }
        public int Country { get; set; }
        public bool IsActive { get; set; }
    }
}
