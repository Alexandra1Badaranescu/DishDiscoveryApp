using AspNetCoreServicesApp.Repositories;
using DishDiscovery.Models;
using DishDiscovery.Repositories.Interfaces;
using Microsoft.CodeAnalysis;

namespace DishDiscovery.Repositories
{
    public class ReviewRepository : RepositoryBase<Review>, IReviewRepository
    {
        public ReviewRepository(DishDiscoveryContext dishDiscoveryContext)
            : base(dishDiscoveryContext)
        {
        }
    }
}
