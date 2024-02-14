namespace learnApi.Models;

public class User{
    public int Id {get; set;}

    public string? Name {get; set;}

    public string Phone {get; set;}

    public List<Order> Orders {get; set;}

    public User(){

    }

    public User(int Id, string Name, string Phone, List<Order> Orders){
        this.Id = Id;
        this.Name = Name;
        this.Phone = Phone;
        this.Orders = Orders;
    }
}