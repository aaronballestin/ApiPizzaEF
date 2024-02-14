namespace learnApi.Models;

public interface IUser
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string Phone { get; set; }

    public List<Order> Orders { get; set; }
}