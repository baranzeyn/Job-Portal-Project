using Job_Portal_Project.Models;

namespace Job_Portal_Project.Repositories
{
    public interface IApplicationRepository : IRepositoryBase<Application>
    {
        void createApplication(Application application);
        IQueryable<Application> GetApplications(string id,bool trackChanges);

        void DeleteOneApplication(Application application);
        Application GetOneApplication(int id,bool trackChanges);
        Application GetOneApplicationByApplicantID(string id,bool trackChanges);
    }
}