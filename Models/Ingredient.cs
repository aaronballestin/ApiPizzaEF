namespace learnApi.Models;

public class Ingredient : IIngredient
{
    public int IngredientId { get; set; }

    public string? Name { get; set; }

    public bool IsVeganFree { get; set; }

    public decimal BonusPrice { get; set; }

    public ICollection<DetallePizza> DetallePizzas { get; set; }

    public Ingredient()
    {

    }

    public Ingredient(int Id, string Name, bool IsVegetarian, decimal BonusPrice)
    {
        this.IngredientId = Id;
        this.Name = Name;
        this.IsVeganFree = IsVegetarian;
        this.BonusPrice = BonusPrice;
    }
}