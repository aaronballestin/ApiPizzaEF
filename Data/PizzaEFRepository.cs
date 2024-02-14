using learnApi.Models;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;

namespace learnApi.Data
{
    public class PizzaEFRepository : IPizzaRepository
    {
        private readonly PizzaContext _context;

        public PizzaEFRepository(PizzaContext context)
        {
            _context = context;
        }

        public List<Pizza> GetAll()
        {
            return _context.Pizzas.ToList();

        }

        public Pizza? Get(int id)
        {
            return _context.Pizzas.FirstOrDefault(i => i.PizzaId == id);
        
        }

        public void Add(Pizza pizza)
        {
            _context.Pizzas.Add(pizza);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var pizza = _context.Pizzas.Find(id);
            if (pizza != null)
            {
                _context.Pizzas.Remove(pizza);
                _context.SaveChanges();
            }
        }

        public void Update(Pizza pizza)
        {
            _context.Entry(pizza).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
