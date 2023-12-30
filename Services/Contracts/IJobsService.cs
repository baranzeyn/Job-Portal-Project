using Job_Portal_Project.Models;

namespace Job_Portal_Project.Services
{
    public interface IJobsService
    {
        IEnumerable<Job> GetAllJobs(bool trackChanges);
        Job? GetOneJob(int id, bool trackChanges);
        void CreateJob(Job job);
    }
}