using Microsoft.AspNetCore.Mvc;
using System.Net;
using Zippy.Cash.Repository.Abstract;
using Zippy.Model;

namespace Zippy.Cash.API.Controllers.CustomerController
{
    [ApiController]
    [Route("api/customers")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomerController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        #region Customer

        /// <summary>
        /// Get all customers
        /// </summary>
        /// <returns>List of customers</returns>
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [HttpGet]
        public ActionResult GetCustomers()
        {
            IEnumerable<Customer> result = _customerRepository.GetCustomers();
            return Ok(result);
        }

        /// <summary>
        /// Get customer by Id
        /// </summary>
        /// <param name="customerId">Customer Id</param>
        /// <returns>Single customer</returns>
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [HttpGet("{customerId}")]
        public ActionResult GetCustomer(int customerId)
        {
            if (customerId <= 0)
            {
                return BadRequest();
            }

            Customer? result = _customerRepository.GetCustomerById(customerId);
            return Ok(result);
        }

        /// <summary>
        /// Create a new cusomer
        /// </summary>
        /// <param name="customer">New cusomer details</param>
        /// <returns>Return true if success. Else return false</returns>
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [HttpPost()]
        public ActionResult CreateCustomer([FromBody] Customer customer)
        {
            if (customer == null)
            {
                return BadRequest();
            }

            bool result = _customerRepository.CreateCustomer(customer);
            return Ok(result);
        }

        /// <summary>
        /// Update existing customer
        /// </summary>
        /// <param name="customer">Customer details</param>
        /// <returns>Return true if success. Else return false</returns>
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [HttpPut()]
        public ActionResult UpdateCustomer([FromBody] Customer customer)
        {
            if (customer == null)
            {
                return BadRequest();
            }

            bool result = _customerRepository.UpdateCustomer(customer);
            return Ok(result);
        }

        /// <summary>
        /// Update existing customer
        /// </summary>
        /// <param name="customerId">CUstomer Id</param>
        /// <returns>Return true if success. Else return false</returns>
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [HttpDelete("{customerId}")]
        public ActionResult DeleteCustomer(int customerId)
        {
            if (customerId <= 0)
            {
                return BadRequest();
            }

            bool result = _customerRepository.DeleteCustomer(customerId);
            return Ok(result);
        }

        #endregion
    }
}
