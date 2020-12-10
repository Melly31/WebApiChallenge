using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        //GET:api/CustomerDetails
        [HttpGet]
        public ActionResult<IEnumerable<CustomerDetails>> GetCommands()
        {
            return _context.CustomerDetails;
        }

        //GET: api/CustomerDetails/IsActive
        [HttpGet("{IsActive}")]
        public ActionResult<CustomerDetails> GetCommandItem(bool IsActive)
        {
            var itm = _context.CustomerDetails.Find(IsActive);
            if (itm == null)
            {
                return NotFound();
            }
            return itm;
        }

        //POST: api/CustomerDetails
        [HttpPost]
        public ActionResult<CustomerDetails> PostCommandItem(CustomerDetails details)
        {
            _context.CustomerDetails.Add(details);
            _context.SaveChanges();

            return CreatedAtAction("GetCommandItem", new CustomerDetails { Id = details.Id }, details);
        }

        //PUT api/CustomerDetails/n
        [HttpPut("{IsActive}")]
        public ActionResult PutCommandItem(int IsActive, CustomerDetails details)
        {
            if (IsActive.Equals("True"))
            {
                _context.Entry(details).State = EntityState.Modified;
                _context.SaveChanges();             
            }
            return NoContent();
        }

        //DELETE api/CustomerDetails/n
        [HttpDelete("{CustomerDetails}")]
        public ActionResult<CustomerDetails> DeleteDetailsItem(int id, CustomerDetails details)
        {
            var itm = _context.CustomerDetails.Find(id);
            if (itm == null)
            {
                return NotFound();
            }
            _context.CustomerDetails.Remove(details);
            _context.SaveChanges();

            return details;
        }
    }
}
