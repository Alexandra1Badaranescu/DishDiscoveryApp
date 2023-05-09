using DishDiscovery.Models;
using System.Collections.Generic;

namespace DishDiscovery.Services.Interfaces
{
    public interface IRecipeService
    {
        IEnumerable<Recipe> GetAllRecipes();
        Recipe GetRecipeById(int id);
        void CreateRecipe(Recipe recipe);
        void UpdateRecipe(Recipe recipe);
        void DeleteRecipe(Recipe recipe);
    }
}
