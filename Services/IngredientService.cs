using DishDiscovery.Models;
using DishDiscovery.Repositories.Interfaces;
using DishDiscovery.Services.Interfaces;
using System.Collections.Generic;

namespace DishDiscovery.Services
{
    public class IngredientService : IIngredientService
    {
        private readonly IRepositoryWrapper _repositoryWrapper;

        public IngredientService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        public IEnumerable<Ingredient> GetAllIngredients()
        {
            return _repositoryWrapper.IngredientRepository.FindAll();
        }

        public Ingredient GetIngredientById(int id)
        {
            return _repositoryWrapper.IngredientRepository.GetById(id);
        }

        public void CreateIngredient(Ingredient ingredient)
        {
            _repositoryWrapper.IngredientRepository.Create(ingredient);
            _repositoryWrapper.Save();
        }

        public void UpdateIngredient(Ingredient ingredient)
        {
            _repositoryWrapper.IngredientRepository.Update(ingredient);
            _repositoryWrapper.Save();
        }

        public void DeleteIngredient(Ingredient ingredient)
        {
            _repositoryWrapper.IngredientRepository.Delete(ingredient);
            _repositoryWrapper.Save();
        }
    }
}
