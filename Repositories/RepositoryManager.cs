using Job_Portal_Project.Models;

namespace Job_Portal_Project.Repositories
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly IAdminRepository _adminRepository;
        private readonly IUserRepository _userRepository;
        private readonly IJobsRepository _jobsRepository;
        private readonly IContactRepository _contactRepository;
        private readonly JobportalDbContext _context;
        public IAdminRepository Admin => _adminRepository;
        public IUserRepository User => _userRepository;
        public IJobsRepository Jobs => _jobsRepository;

        public IContactRepository Contact => _contactRepository;


        public RepositoryManager(IAdminRepository adminRepository, JobportalDbContext context, IUserRepository userRepository, IJobsRepository jobsRepository, IContactRepository contactRepository)
        {
            _context = context;
            _adminRepository = adminRepository;
            _userRepository = userRepository;
            _jobsRepository = jobsRepository;
            _contactRepository = contactRepository;
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}