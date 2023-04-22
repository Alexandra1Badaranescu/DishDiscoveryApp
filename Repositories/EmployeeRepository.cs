using AspNetCoreServicesApp.Repositories;
using DishDiscovery.Models;
using DishDiscovery.Repositories.Interfaces;
using Microsoft.CodeAnalysis;

namespace DishDiscovery.Repositories
{
    public class EmployeeRepository : RepositoryBase<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(DishDiscoveryContext dishDiscoveryContext)
            : base(dishDiscoveryContext)
        {
        }
    }
}
