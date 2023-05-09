using DishDiscovery.Models;
using Microsoft.CodeAnalysis;

namespace DishDiscovery.Repositories.Interfaces
{
    public interface ICustomerRepository : IRepositoryBase<Customer>
    {
        object SingleOrDefault(Func<object, bool> value);
    }
}
