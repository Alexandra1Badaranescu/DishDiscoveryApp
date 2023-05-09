using System.Collections.Generic;
using System.Linq;
using DishDiscovery.Models;
using DishDiscovery.Repositories.Interfaces;
using DishDiscovery.Services.Interfaces;

namespace DishDiscovery.Services
{
    public class RecipeService : IRecipeService
    {
        private IRepositoryWrapper _repositoryWrapper;

        public RecipeService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        public IEnumerable<Recipe> GetAllRecipes()
        {
            return _repositoryWrapper.RecipeRepository.FindAll();
        }

        public Recipe GetRecipeById(int recipeId)
        {
            return _repositoryWrapper.RecipeRepository.GetById(recipeId);
        }


        public void CreateRecipe(Recipe recipe)
        {
            _repositoryWrapper.RecipeRepository.Create(recipe);
            _repositoryWrapper.Save();
        }

        public void UpdateRecipe(Recipe recipe)
        {
            _repositoryWrapper.RecipeRepository.Update(recipe);
            _repositoryWrapper.Save();
        }

        public void DeleteRecipe(Recipe recipe)
        {
            _repositoryWrapper.RecipeRepository.Delete(recipe);
            _repositoryWrapper.Save();
        }
    }
}

