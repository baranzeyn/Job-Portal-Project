
namespace Job_Portal_Project.Services
{
    public interface IServiceManager
    {
        IUserService UserService {get; }
        IAdminService AdminService {get; }

        IJobsService JobsService {get; }

    }
}