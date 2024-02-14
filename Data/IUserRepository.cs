using learnApi.Models;

namespace learnApi.Data;
public interface IUserRepository
{
    List<User> GetAll();
    User? Get(int id);
    void Add(User user);
    void Delete(int id);
    void Update(User user);
}   

