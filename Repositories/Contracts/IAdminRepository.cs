using Job_Portal_Project.Models;

namespace Job_Portal_Project.Repositories
{
    public interface IAdminRepository : IRepositoryBase<Admin>
    {
        IQueryable<Admin> GetAllAdmins(bool trackChanges);
        Admin GetOneAdmin(int id, bool trackChanges);
    }
}