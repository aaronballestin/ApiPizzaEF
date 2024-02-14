namespace learnApi.Models;

public class Order{
    public int Id {get; set;}

    public decimal Price {get; set;}

    public DateTime date {get; set;}

    public Order(){

    }

    public Order(int Id){
        this.Id = Id;
    }

}