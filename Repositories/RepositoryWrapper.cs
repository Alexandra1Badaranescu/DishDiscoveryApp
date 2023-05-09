using DishDiscovery.Models;
using DishDiscovery.Repositories.Interfaces;

namespace DishDiscovery.Repositories
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private DishDiscoveryContext _dishDiscoveryContext;
        private ICustomerRepository? _customerRepository;
        private IEmployeeRepository? _employeeRepository;
        private IIngredientRepository? _ingredientRepository;
        private IMenuItemRepository? _menuItemRepository;
        private IRecipeRepository? _recipeRepository;
        private IReviewRepository? _reviewRepository;

        public ICustomerRepository CustomerRepository
        {
            get
            {
                if (_customerRepository == null)
                {
                    _customerRepository = new CustomerRepository(_dishDiscoveryContext);
                }

                return _customerRepository;
            }
        }
        public IEmployeeRepository EmployeeRepository
        {
            get
            {
                if (_employeeRepository == null)
                {
                    _employeeRepository = new EmployeeRepository(_dishDiscoveryContext);
                }

                return _employeeRepository;
            }
        }
        public IIngredientRepository IngredientRepository
        {
            get
            {
                if (_ingredientRepository == null)
                {
                    _ingredientRepository = new IngredientRepository(_dishDiscoveryContext);
                }

                return _ingredientRepository;
            }
        }
        public IMenuItemRepository MenuItemRepository
        {
            get
            {
                if (_menuItemRepository == null)
                {
                    _ingredientRepository = new IngredientRepository(_dishDiscoveryContext);
                }

                return _menuItemRepository;
            }
        }
        public IRecipeRepository RecipeRepository
        {
            get
            {
                if (_recipeRepository == null)
                {
                    _recipeRepository = new RecipeRepository(_dishDiscoveryContext);
                }

                return _recipeRepository;
            }
        }
        public IReviewRepository ReviewRepository
        {
            get
            {
                if (_reviewRepository == null)
                {
                    _reviewRepository = new ReviewRepository(_dishDiscoveryContext);
                }

                return _reviewRepository;
            }
        }
        public RepositoryWrapper(DishDiscoveryContext dishDiscoveryContext)
        {
            _dishDiscoveryContext = dishDiscoveryContext;
        }

        public void Save()
        {
            _dishDiscoveryContext.SaveChanges();
        }
    }
}
