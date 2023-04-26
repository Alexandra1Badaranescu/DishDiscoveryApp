namespace DishDiscovery.Repositories.Interfaces
{
    public interface IRepositoryWrapper
    {
        ICustomerRepository CustomerRepository { get; }
        IEmployeeRepository EmployeeRepository { get; }
        IIngredientRepository IngredientRepository { get; }
        IMenuItemRepository MenuItemRepository { get; }
        IRecipeRepository RecipeRepository { get; }
        IReviewRepository ReviewRepository { get; }
        void Save();
    }
}
