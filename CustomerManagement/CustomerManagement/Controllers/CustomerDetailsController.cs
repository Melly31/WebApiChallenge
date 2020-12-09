using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerManagement.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CustomerManagement.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerDetailsController : ControllerBase
    {
        private readonly CustomerDetailsDbConnection _context;

        public CustomerDetailsController(CustomerDetailsDbConnection context)
        {
            _context = context;
        }
    }
}
