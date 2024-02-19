using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace learnApi.Models;

public class Pizza : IPizza
{

    public Pizza (){

    }

    [Key]
    public int PizzaId { get; set; }

    [Required]
    public string? Name { get; set; }

    [Required]
    public bool IsGlutenFree { get; set; }

    [Column(TypeName = "decimal(18, 2)")]


    public decimal Price{get; set;}

    public List<DetallePizza> DetallePizzas {get; set;}


}