using Job_Portal_Project.Models;

namespace Job_Portal_Project.Repositories
{
    public class ApplicationRepository : RepositoryBase<Application>, IApplicationRepository
    {
        public ApplicationRepository(JobportalDbContext context) : base(context)
        {
        }

        public void createApplication(Application application)
        {
            Create(application);
        }

        public void DeleteOneApplication(Application application)
        {
            Remove(application);
        }

        public IQueryable<Application> GetApplications(string id, bool trackChanges)
        {
            return GetByCondition(a => a.ApplicantId.Equals(id));
        }

        public Application? GetOneApplication(int id, bool trackChanges)
        {
            return FindByCondition(a => a.ApplicationId.Equals(id), trackChanges);
        }
        public Application? GetOneApplicationByApplicantID(string id, bool trackChanges)
        {
            return FindByCondition(a => a.ApplicantId.Equals(id), trackChanges);
        }
    }
}