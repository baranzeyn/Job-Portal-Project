using System.Linq.Expressions;
using Job_Portal_Project.Models;

namespace Job_Portal_Project.Repositories
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(JobportalDbContext context) : base(context)
        {
        }

        public IQueryable<User> GetAllUsers(bool trackChanges)
        {
            return FindAll(trackChanges);
        }

        public User? GetOneUser(int id, bool trackChanges)
        {
            return FindByCondition(p => p.UserId.Equals(id), trackChanges);
        }
    }
}