using learnApi.Models;
using Microsoft.EntityFrameworkCore;

namespace learnApi.Data
{
    public class IngredientEFRepository : IIngredientRepository
    {
        private readonly PizzaContext _context;

        public IngredientEFRepository(PizzaContext context)
        {
            _context = context;
        }

        public List<Ingredient> GetAll()
        {
            return _context.Ingredients.ToList();
        }

        public Ingredient? Get(int id)
        {
            return _context.Ingredients.FirstOrDefault(i => i.IngredientId == id);
        }

        public void Add(Ingredient ingredient)
        {
            _context.Ingredients.Add(ingredient);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var ingredient = _context.Ingredients.Find(id);
            if (ingredient != null)
            {
                _context.Ingredients.Remove(ingredient);
                _context.SaveChanges();
            }
        }

        public void Update(Ingredient ingredient)
        {
            _context.Entry(ingredient).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
