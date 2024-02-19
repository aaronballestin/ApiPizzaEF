using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using learnApi.Models;
using learnApi.Services;



namespace learnApi.Controllers
{
    [ApiController]
    [Route("[controller]/")]
    public class IngredientController : ControllerBase
    {
        private readonly IngredientService _ingredientService;

        public IngredientController(IngredientService ingredientService)
        {
            _ingredientService = ingredientService;
        }

        [HttpGet]
        public ActionResult<List<Ingredient>> GetAll()
        {
            var ingredients = _ingredientService.GetAll();
            return Ok(ingredients);
        }

        [HttpGet("{id}")]
        public ActionResult<Ingredient> Get(int id)
        {
            var ingredient = _ingredientService.Get(id);
            if (ingredient == null)
            {
                return NotFound();
            }
            return Ok(ingredient);
        }

        [HttpPost]
        public IActionResult Add(Ingredient ingredient)
        {
            _ingredientService.Add(ingredient);
            return CreatedAtAction(nameof(Get), new { id = ingredient.IngredientId }, ingredient);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Ingredient ingredient)
        {
            if (id != ingredient.IngredientId)
            {
                return BadRequest();
            }

            _ingredientService.Update(ingredient);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _ingredientService.Delete(id);
            return NoContent();
        }
    }
}
