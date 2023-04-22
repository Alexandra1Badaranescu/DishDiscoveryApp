using AspNetCoreServicesApp.Repositories;
using DishDiscovery.Models;
using Microsoft.CodeAnalysis;

namespace DishDiscovery.Repositories.Interfaces
{
    public interface IMenuItemRepository : IRepositoryBase<MenuItem>
    {
    }
}
