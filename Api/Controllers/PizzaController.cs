using System.Collections.Generic;
using learnApi.Models;
using learnApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace learnApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PizzaController : ControllerBase
    {
        private readonly PizzaService _pizzaService;

        public PizzaController(PizzaService pizzaService)
        {
            _pizzaService = pizzaService;
        }

        [HttpGet]
        public ActionResult<List<Pizza>> GetAll()
        {
            var pizzas = _pizzaService.GetAll();
            return Ok(pizzas);
        }

        [HttpGet("{id}")]
        public ActionResult<Pizza?> Get(int id)
        {
            var pizza = _pizzaService.Get(id);

            if (pizza == null)
            {
                return NotFound();
            }

            return Ok(pizza);
        }

        [HttpPost]
        public IActionResult Add(Pizza pizza)
        {
            _pizzaService.Add(pizza);
            return CreatedAtAction(nameof(Get), new { id = pizza.PizzaId }, pizza);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Pizza pizza)
        {
            var existingPizza = _pizzaService.Get(id);

            if (existingPizza == null)
            {
                return NotFound();
            }

            _pizzaService.Update(pizza);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var existingPizza = _pizzaService.Get(id);

            if (existingPizza == null)
            {
                return NotFound();
            }

            _pizzaService.Delete(id);
            return NoContent();
        }
    }
    
}


    // private readonly ILogger<WeatherForecastController> _logger;

    // public WeatherForecastController(ILogger<WeatherForecastController> logger)
    // {
    //     _logger = logger;
    // }
