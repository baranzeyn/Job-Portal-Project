using System.Linq.Expressions;
using Job_Portal_Project.Models;
using Job_Portal_Project.RequestParameters;

namespace Job_Portal_Project.Services
{
    public interface IJobsService
    {
        IEnumerable<Job> GetAllJobs(bool trackChanges);
        Job? GetOneJob(int id, bool trackChanges);
        void CreateJob(Job job);
        IEnumerable<Job> GetAllJobsWithDetails(JobRequestParameters p);

    }
}