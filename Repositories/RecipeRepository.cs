using AspNetCoreServicesApp.Repositories;
using DishDiscovery.Models;
using DishDiscovery.Repositories.Interfaces;
using Microsoft.CodeAnalysis;

namespace DishDiscovery.Repositories
{
    public class RecipeRepository : RepositoryBase<Recipe>, IRecipeRepository
    {
        public RecipeRepository(DishDiscoveryContext dishDiscoveryContext)
            : base(dishDiscoveryContext)
        {
        }
    }
}
