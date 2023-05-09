using System.Collections.Generic;
using System.Linq;
using DishDiscovery.Models;
using DishDiscovery.Repositories.Interfaces;
using DishDiscovery.Services.Interfaces;

namespace DishDiscovery.Services
{
    public class ReviewService : IReviewService
    {
        private IRepositoryWrapper _repositoryWrapper;

        public ReviewService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        public IEnumerable<Review> GetAllReviews()
        {
            return _repositoryWrapper.ReviewRepository.FindAll();
        }

        public Review GetReviewById(int reviewId)
        {
            return _repositoryWrapper.ReviewRepository.GetById(reviewId);
        }


        public void CreateReview(Review review)
        {
            _repositoryWrapper.ReviewRepository.Create(review);
            _repositoryWrapper.Save();
        }

        public void UpdateReview(Review review)
        {
            _repositoryWrapper.ReviewRepository.Update(review);
            _repositoryWrapper.Save();
        }

        public void DeleteReview(Review review)
        {
            _repositoryWrapper.ReviewRepository.Delete(review);
            _repositoryWrapper.Save();
        }
    }
}

