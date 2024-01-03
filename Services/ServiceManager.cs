

using Job_Portal_Project.Repositories;

namespace Job_Portal_Project.Services
{
    public class ServiceManager : IServiceManager
    {
        private readonly IUserService _userService;
        private readonly IAdminService _adminService;
        private readonly IJobsService _JobsService;
        private readonly IContactService _contactService;

        public ServiceManager(IUserService userService, IAdminService adminService, IJobsService jobsService, IContactService contactService)
        {
            _userService = userService;
            _adminService = adminService;
            _JobsService = jobsService;
            _contactService = contactService;
        }

        public IUserService UserService => _userService;

        public IAdminService AdminService => _adminService;

        public IJobsService JobsService => _JobsService;

        public IContactService ContactService => _contactService;


    }
}