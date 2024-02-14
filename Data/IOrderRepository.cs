using learnApi.Models;

namespace learnApi.Data;
public interface IOrderRepository
{
    List<Order> GetAll();
    Order? Get(int id);
    void Add(Order order);
    void Delete(int id);
    void Update(Order order);
}   

