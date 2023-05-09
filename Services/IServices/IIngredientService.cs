using DishDiscovery.Models;
using System.Collections.Generic;

namespace DishDiscovery.Services.Interfaces
{
    public interface IIngredientService
    {
        IEnumerable<Ingredient> GetAllIngredients();
        Ingredient GetIngredientById(int id);
        void CreateIngredient(Ingredient ingredient);
        void UpdateIngredient(Ingredient ingredient);
        void DeleteIngredient(Ingredient ingredient);
    }
}
