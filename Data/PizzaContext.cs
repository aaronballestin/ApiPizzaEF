using learnApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace learnApi.Data
{
    public class PizzaContext : DbContext
    {
        public PizzaContext(DbContextOptions<PizzaContext> options)
            : base(options)
        {
        }

        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<DetallePizza> DetallePizzas { get; set; }
        public DbSet<Order> Orders {get; set;}
        public DbSet<User> Users {get; set;}


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            //  modelBuilder.Entity<DetallePizza>()
            //     .HasKey(pi => new { pi.PizzaId, pi.IngredientId });

            // Datos iniciales
            modelBuilder.Entity<DetallePizza>().HasData(
                new DetallePizza { PizzaId = 1, IngredientId = 1 },
                new DetallePizza { PizzaId = 1, IngredientId = 2 },
                new DetallePizza { PizzaId = 1, IngredientId = 3 },
                new DetallePizza { PizzaId = 2, IngredientId = 1 },
                new DetallePizza { PizzaId = 2, IngredientId = 2 },
                new DetallePizza { PizzaId = 2, IngredientId = 4 },
                new DetallePizza { PizzaId = 2, IngredientId = 5 }
            );

            modelBuilder.Entity<Pizza>().HasData(
                new Pizza { PizzaId = 1, Name = "Classic Italian", IsGlutenFree = false, Price = 10.99m },
                new Pizza { PizzaId = 2, Name = "Veggie", IsGlutenFree = true, Price = 12.99m }
            );

            modelBuilder.Entity<Ingredient>().HasData(
                new Ingredient { IngredientId = 1, Name = "Tomato Sauce" },
                new Ingredient { IngredientId = 2, Name = "Cheese" },
                new Ingredient { IngredientId = 3, Name = "Pepperoni" },
                new Ingredient { IngredientId = 4, Name = "Mushrooms" },
                new Ingredient { IngredientId = 5, Name = "Bell Peppers" }
            );

            
        }
    }
}
