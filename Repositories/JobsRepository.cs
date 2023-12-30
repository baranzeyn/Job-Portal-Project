using Job_Portal_Project.Models;

namespace Job_Portal_Project.Repositories
{
    public class JobsRepository : RepositoryBase<Job>, IJobsRepository
    {
        public JobsRepository(JobportalDbContext context) : base(context)
        {
        }

        public void CreateJob(Job job)
        {
            Create(job);
        }

        public IQueryable<Job> GetAllJobs(bool trackChanges)
        {
            return FindAll(trackChanges);
        }

        public Job? GetOneJob(int id, bool trackChanges)
        {
            return FindByCondition(j => j.JobId.Equals(id), trackChanges);
        }
    }
}