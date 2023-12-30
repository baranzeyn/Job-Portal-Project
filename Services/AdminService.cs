using Job_Portal_Project.Models;
using Job_Portal_Project.Repositories;

namespace Job_Portal_Project.Services
{
    public class AdminService : IAdminService
    {
        private readonly IRepositoryManager _manager;

        public AdminService(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public IEnumerable<Admin> GetAllAdmins(bool trackChanges)
        {
            return _manager.Admin.GetAllAdmins(trackChanges);
        }

        public Admin? GetOneAdmin(int id, bool trackChanges)
        {
            var admin = _manager.Admin.GetOneAdmin(id,trackChanges);
            if(admin == null) {
                throw new Exception("admin not found");
            }
            return admin;
        }
    }
}