using learnApi.Models;

namespace learnApi.Data;
public interface IIngredientRepository
{
    List<Ingredient> GetAll();
    Ingredient? Get(int id);
    void Add(Ingredient ingredient);
    void Delete(int id);
    void Update(Ingredient ingredient);
}   

