using Job_Portal_Project.Models;

namespace Job_Portal_Project.Repositories
{
    public interface IUserRepository : IRepositoryBase<User>
    {
        IQueryable<User> GetAllUsers(bool trackChanges);

        User GetOneUser(int id,bool trackChanges);
        
    }
}