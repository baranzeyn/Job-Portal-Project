using System.Linq.Expressions;
using Job_Portal_Project.Models;
using Job_Portal_Project.Repositories;
using Job_Portal_Project.RequestParameters;

namespace Job_Portal_Project.Services
{
    public class JobsService : IJobsService
    {
        private readonly IRepositoryManager _manager;

        public JobsService(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public void CreateJob(Job job)
        {
            _manager.Jobs.CreateJob(job);
            _manager.Save();
        }

        public IEnumerable<Job> GetAllJobs(bool trackChanges)
        {
            return _manager.Jobs.GetAllJobs(trackChanges);
        }

        public IEnumerable<Job> GetAllJobsWithDetails(JobRequestParameters p)
        {
            return _manager.Jobs.GetAllJobsWithDetails(p);
        }
        
        public Job? GetOneJob(int id, bool trackChanges)
        {
            return _manager.Jobs.GetOneJob(id, trackChanges);

        }
    }
}