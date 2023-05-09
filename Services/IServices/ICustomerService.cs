using DishDiscovery.Models;

namespace DishDiscovery.Services.Interfaces
{
    public interface ICustomerService
    {
        void AddCustomer(Customer customer);
        Customer GetCustomerById(int customerId);
        void UpdateCustomer(Customer customer);
        void DeleteCustomer(Customer customer);
    }
}