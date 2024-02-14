using learnApi.Services;
using learnApi.Data;
using learnApi.Models;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddScoped<PizzaService>(); 
builder.Services.AddScoped<OrderService>(); 
builder.Services.AddScoped<IngredientService>(); 
builder.Services.AddScoped<UserService>(); 

var connectionString = builder.Configuration.GetConnectionString("ServerDB");

builder.Services.AddDbContext<PizzaContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddScoped<IPizzaRepository, PizzaEFRepository>(); 
builder.Services.AddScoped<IOrderRepository, OrderEFRepository>(); 
builder.Services.AddScoped<IIngredientRepository, IngredientEFRepository>(); 
builder.Services.AddScoped<IUserRepository, UserEFRepository>(); 


  
// builder.Services.AddScoped<IPizzaRepository, PizzaEFRepository>(serviceProvider => 
//     new PizzaEFRepository(connectionString));
//     new OrderEFRepository(connectionString);
//     new IngredientEFRepository(connectionString);
//     new UserEFRepository(connectionString);


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger(options =>
    {
        options.RouteTemplate = "/swagger/{documentName}/swagger.json";
    });

    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "Your API Name");
        options.RoutePrefix = "swagger";
    });
}

// app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

