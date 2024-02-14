using System.Collections.Generic;
using learnApi.Models;
using learnApi.Data;

namespace learnApi.Services
{
    public class PizzaService
    {
        private readonly IPizzaRepository _pizzaRepository;

        // Constructor
        public PizzaService(IPizzaRepository pizzaRepository)
        {
            _pizzaRepository = pizzaRepository;
        }

        // Métodos de la clase
        public List<Pizza> GetAll() => _pizzaRepository.GetAll();

        public Pizza? Get(int id) => _pizzaRepository.Get(id);

        public void Add(Pizza pizza) => _pizzaRepository.Add(pizza);

        public void Update(Pizza pizza) => _pizzaRepository.Update(pizza);

        public void Delete(int id) => _pizzaRepository.Delete(id);
    }
}
