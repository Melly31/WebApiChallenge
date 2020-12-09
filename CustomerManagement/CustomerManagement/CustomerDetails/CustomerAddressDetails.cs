using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerManagement.CustomerDetails
{
    public class CustomerAddressDetails
    {
        public int Id { get; set; }
        public int AddressLine1 { get; set; }
        public int AddressLine2 { get; set; }
        public int Town { get; set; }
        public int County { get; set; }
        public int Postcode { get; set; }
        public int Country { get; set; }
    }
}
