using Zippy.Model;

namespace Zippy.Cash.Repository.Abstract
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetCustomers();
        Customer? GetCustomerById(int customerId);
        bool CreateCustomer(Customer customer);
        bool UpdateCustomer(Customer customer);
        bool DeleteCustomer(int customerId);
    }
}
