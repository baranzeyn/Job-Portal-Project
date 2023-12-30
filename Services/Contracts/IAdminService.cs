using Job_Portal_Project.Models;

namespace Job_Portal_Project.Services
{
    public interface IAdminService
    {
        IEnumerable<Admin> GetAllAdmins(bool trackChanges);
        Admin? GetOneAdmin(int id, bool trackChanges);
    }
}