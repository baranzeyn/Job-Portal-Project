using Job_Portal_Project.Models;

namespace Job_Portal_Project.Repositories
{
    public class AdminRepository : RepositoryBase<Admin>, IAdminRepository
    {
        public AdminRepository(JobportalDbContext context) : base(context)
        {
        }

        public IQueryable<Admin> GetAllAdmins(bool trackChanges) => FindAll(trackChanges);

        public Admin? GetOneAdmin(int id, bool trackChanges)
        {
            return FindByCondition(p => p.AdminId.Equals(id), trackChanges);
        }
    }
}