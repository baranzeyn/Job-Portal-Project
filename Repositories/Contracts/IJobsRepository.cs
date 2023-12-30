using Job_Portal_Project.Models;

namespace Job_Portal_Project.Repositories
{
    public interface IJobsRepository : IRepositoryBase<Job>
    {
        IQueryable<Job> GetAllJobs(bool trackChanges);
        Job GetOneJob(int id, bool trackChanges);
        void CreateJob(Job job);
    }
}