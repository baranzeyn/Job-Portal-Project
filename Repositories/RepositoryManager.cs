using Job_Portal_Project.Models;

namespace Job_Portal_Project.Repositories
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly IUserRepository _userRepository;
        private readonly IJobsRepository _jobsRepository;
        private readonly IContactRepository _contactRepository;
        private readonly IApplicationRepository _applicationRepository;
        private readonly JobportalDbContext _context;
        public IUserRepository User => _userRepository;
        public IJobsRepository Jobs => _jobsRepository;
        public IContactRepository Contact => _contactRepository;
        public IApplicationRepository Application => _applicationRepository;

        public RepositoryManager(JobportalDbContext context, IUserRepository userRepository, IJobsRepository jobsRepository, IContactRepository contactRepository, IApplicationRepository applicationRepository)
        {
            _context = context;
            _userRepository = userRepository;
            _jobsRepository = jobsRepository;
            _contactRepository = contactRepository;
            _applicationRepository = applicationRepository;
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}