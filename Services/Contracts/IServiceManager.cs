
using Job_Portal_Project.Repositories;

namespace Job_Portal_Project.Services
{
    public interface IServiceManager
    {
        IUserService UserService { get; }
        IJobsService JobsService { get; }
        IContactService ContactService { get; }

    }
}