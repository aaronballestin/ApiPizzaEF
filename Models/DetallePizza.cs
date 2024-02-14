using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace learnApi.Models
{
    public class DetallePizza
    {
        // Clave foránea para Pizza
        public int PizzaId { get; set; }

        // Clave foránea para Ingredient
        public int IngredientId { get; set; }

        // Propiedades de navegación para establecer las relaciones con Pizza e Ingredient
        [ForeignKey("PizzaId")]
        public Pizza Pizza { get; set; }

        [ForeignKey("IngredientId")]
        public Ingredient Ingredient { get; set; }
    }
}
