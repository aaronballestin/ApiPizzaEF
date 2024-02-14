using learnApi.Models;

namespace learnApi.Data;
public interface IPizzaRepository
{
    List<Pizza> GetAll();
    Pizza? Get(int id);
    void Add(Pizza pizza);
    void Delete(int id);
    void Update(Pizza pizza);
}   

