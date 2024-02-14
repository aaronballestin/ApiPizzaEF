using System.Collections.Generic;
using learnApi.Models;
using learnApi.Data;

namespace learnApi.Services
{
    public class UserService
    {
        private readonly IUserRepository _userRepository;

        // Constructor
        public UserService(IUserRepository pizzaRepository)
        {
            _userRepository = pizzaRepository;
        }

        // Métodos de la clase
        public List<User> GetAll() => _userRepository.GetAll();

        public User? Get(int id) => _userRepository.Get(id);

        public void Add(User user) => _userRepository.Add(user);

        public void Update(User user) => _userRepository.Update(user);

        public void Delete(int id) => _userRepository.Delete(id);
    }
}
