

using Job_Portal_Project.Repositories;

namespace Job_Portal_Project.Services
{
    public class ServiceManager : IServiceManager
    {
        private readonly IUserService _userService;
        private readonly IJobsService _JobsService;
        private readonly IContactService _contactService;

        public ServiceManager(IUserService userService, IJobsService jobsService, IContactService contactService)
        {
            _userService = userService;
            _JobsService = jobsService;
            _contactService = contactService;
        }

        public IUserService UserService => _userService;

        public IJobsService JobsService => _JobsService;

        public IContactService ContactService => _contactService;


    }
}