using Job_Portal_Project.Models;

namespace Job_Portal_Project.Repositories
{
    public interface IApplicationRepository : IRepositoryBase<Application>
    {
        void createApplication(Application application);
    }
}