using Job_Portal_Project.Models;

namespace Job_Portal_Project.Services
{
    public interface IApplicationService
    {
        void createApplication(Application application,int jobid, string userid);
        IEnumerable<Application> GetApplicationsByUserID(string id, bool trackChanges);
    }
}