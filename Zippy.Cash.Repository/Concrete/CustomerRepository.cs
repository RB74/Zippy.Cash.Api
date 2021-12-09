using Zippy.Cash.Repository.Abstract;
using Zippy.Model;

namespace Zippy.Cash.Repository.Concrete
{
    public class CustomerRepository : ICustomerRepository
    {
        private List<Customer> _customers = new();

        public CustomerRepository()
        {
            GenerateMockCustomers();
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return _customers.AsEnumerable();
        }

        public Customer? GetCustomerById(int customerId)
        {
            return _customers.FirstOrDefault(c => c.Id == customerId);
        }

        public bool CreateCustomer(Customer customer)
        {
            _customers.Add(customer);
            return true;
        }

        public bool UpdateCustomer(Customer customer)
        {
            Customer? c = _customers.FirstOrDefault(c => c.Id == customer.Id);
            if (c == null)
            {
                // Need return error code with 404. But ATM return just false
                return false;
            }

            c.Name = customer.Name;
            return true;
        }

        public bool DeleteCustomer(int customerId)
        {
            Customer? customer = _customers.FirstOrDefault(c => c.Id == customerId);
            if (customer == null)
            {
                // Need return error code with 404. But ATM return just false
                return false;
            }
            return _customers.Remove(customer);
        }

        #region Private Methods

        private void GenerateMockCustomers()
        {
            _customers = new List<Customer>
            {
                new Customer()
                {
                    Id = 1,
                    Name = "John"

                },
                new Customer()
                {
                    Id = 2,
                    Name = "Steve"

                },
                new Customer()
                {
                    Id = 3,
                    Name = "Adam"

                },
                new Customer()
                {
                    Id = 4,
                    Name = "Smith"
                },
                new Customer()
                {
                    Id = 5,
                    Name = "Peter"
                }
            };
        }

        #endregion
    }
}
