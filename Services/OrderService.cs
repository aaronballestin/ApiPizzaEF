using System.Collections.Generic;
using learnApi.Models;
using learnApi.Data;

namespace learnApi.Services
{
    public class OrderService
    {
        private readonly IOrderRepository _orderRepository;

        // Constructor
        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        // Métodos de la clase
        public List<Order> GetAll() => _orderRepository.GetAll();

        public Order? Get(int id) => _orderRepository.Get(id);

        public void Add(Order order) => _orderRepository.Add(order);

        public void Update(Order order) => _orderRepository.Update(order);

        public void Delete(int id) => _orderRepository.Delete(id);
    }
}
