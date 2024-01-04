

using Job_Portal_Project.Repositories;

namespace Job_Portal_Project.Services
{
    public class ServiceManager : IServiceManager
    {
        private readonly IUserService _userService;
        private readonly IJobsService _JobsService;
        private readonly IContactService _contactService;
        private readonly IApplicationService _ApplicationService;

        public ServiceManager(IUserService userService, IJobsService jobsService, IContactService contactService, IApplicationService applicationService)
        {
            _userService = userService;
            _JobsService = jobsService;
            _contactService = contactService;
            _ApplicationService = applicationService;
        }

        public IUserService UserService => _userService;

        public IJobsService JobsService => _JobsService;

        public IContactService ContactService => _contactService;

        public IApplicationService ApplicationService => _ApplicationService;
    }
}