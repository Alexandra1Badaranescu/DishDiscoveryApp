using AspNetCoreServicesApp.Repositories;
using DishDiscovery.Models;
using DishDiscovery.Repositories.Interfaces;
using Microsoft.CodeAnalysis;

namespace DishDiscovery.Repositories
{
    public class MenuItemRepository : RepositoryBase<MenuItem>, IMenuItemRepository
    {
        public MenuItemRepository(DishDiscoveryContext dishDiscoveryContext)
            : base(dishDiscoveryContext)
        {
        }
    }
}
