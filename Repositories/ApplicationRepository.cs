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
    }
}