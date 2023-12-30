using Job_Portal_Project.Models;

namespace Job_Portal_Project.Repositories
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly IAdminRepository _adminRepository;
        private readonly IUserRepository _userRepository;
        private readonly IJobsRepository _jobsRepository;
        private readonly JobportalDbContext _context;
        public IAdminRepository Admin => _adminRepository;
        public IUserRepository User => _userRepository;
        public IJobsRepository Jobs => _jobsRepository;

        public RepositoryManager(IAdminRepository adminRepository, JobportalDbContext context, IUserRepository userRepository, IJobsRepository jobsRepository)
        {
            _context = context;
            _adminRepository = adminRepository;
            _userRepository = userRepository;
            _jobsRepository = jobsRepository;
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}