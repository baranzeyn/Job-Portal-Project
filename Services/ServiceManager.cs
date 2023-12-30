

namespace Job_Portal_Project.Services
{
    public class ServiceManager : IServiceManager
    {
        private readonly IUserService _userService;
        private readonly IAdminService _adminService;
        private readonly IJobsService _JobsService;

        public ServiceManager(IUserService userService, IAdminService adminService, IJobsService jobsService)
        {
            _userService = userService;
            _adminService = adminService;
            _JobsService = jobsService;
        }

        public IUserService UserService => _userService;

        public IAdminService AdminService => _adminService;

        public IJobsService JobsService => _JobsService;


    }
}