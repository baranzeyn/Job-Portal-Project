using System.Linq.Expressions;
using Job_Portal_Project.Models;
using Job_Portal_Project.RequestParameters;

namespace Job_Portal_Project.Repositories
{
    public interface IJobsRepository : IRepositoryBase<Job>
    {
        IQueryable<Job> GetAllJobs(bool trackChanges);
        Job GetOneJob(int id, bool trackChanges);
        void CreateJob(Job job);
        IQueryable<Job> GetAllJobsWithDetails(JobRequestParameters p);

    }
}