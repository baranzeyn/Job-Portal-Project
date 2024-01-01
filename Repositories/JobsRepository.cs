using System.Linq.Expressions;
using Job_Portal_Project.Models;
using Job_Portal_Project.Repositories.Extensions;
using Job_Portal_Project.RequestParameters;

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
        
        public IQueryable<Job> GetAllJobsWithDetails(JobRequestParameters p)
        {
            return _context.Jobs.FilteredBySearchTerm(p.SearchTerm);
        }
    }
}