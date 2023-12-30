using Job_Portal_Project.Models;

namespace Job_Portal_Project.Services
{
    public interface IUserService
    {
        IEnumerable<User> GetAllUsers(bool trackChanges);
        User GetOneUser(int id, bool trackChanges);
    }
}