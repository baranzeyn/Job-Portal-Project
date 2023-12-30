using Job_Portal_Project.Models;
using Job_Portal_Project.Repositories;

namespace Job_Portal_Project.Services
 {
    public class UserService : IUserService
    {
        private readonly IRepositoryManager _manager;
        public IEnumerable<User> GetAllUsers(bool trackChanges)
        {   
            return _manager.User.FindAll(trackChanges);
        }

        public User GetOneUser(int id, bool trackChanges)
        {
            return _manager.User.GetOneUser(id,trackChanges);

        }
    }
}