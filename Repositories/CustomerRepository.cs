using AspNetCoreServicesApp.Repositories;
using DishDiscovery.Models;
using DishDiscovery.Repositories.Interfaces;
using Microsoft.CodeAnalysis;

namespace DishDiscovery.Repositories
{
    public class CustomerRepository : RepositoryBase<Customer>, ICustomerRepository
    {
        public CustomerRepository(DishDiscoveryContext dishDiscoveryContext)
            : base(dishDiscoveryContext)
        {
        }
    }
}
