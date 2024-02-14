using System.Collections.Generic;
using learnApi.Models;
using learnApi.Data;

namespace learnApi.Services
{
    public class IngredientService
    {
        private readonly IIngredientRepository _ingredientRepository;

        // Constructor
        public IngredientService(IIngredientRepository pizzaRepository)
        {
            _ingredientRepository = pizzaRepository;
        }

        // Métodos de la clase
        public List<Ingredient> GetAll() => _ingredientRepository.GetAll();

        public Ingredient? Get(int id) => _ingredientRepository.Get(id);

        public void Add(Ingredient ingredient) => _ingredientRepository.Add(ingredient);

        public void Update(Ingredient ingredient) => _ingredientRepository.Update(ingredient);

        public void Delete(int id) => _ingredientRepository.Delete(id);
    }
}
