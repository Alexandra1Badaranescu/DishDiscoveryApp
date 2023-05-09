using DishDiscovery.Models;
using System.Collections.Generic;

namespace DishDiscovery.Services.Interfaces
{
    public interface IReviewService
    {
        IEnumerable<Review> GetAllReviews();
        Review GetReviewById(int id);
        void CreateReview(Review review);
        void UpdateReview(Review review);
        void DeleteReview(Review review);
    }
}
