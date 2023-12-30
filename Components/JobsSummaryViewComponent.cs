using Job_Portal_Project.Services;
using Microsoft.AspNetCore.Mvc;

namespace Job_Portal_Project.Components
{
    public class JobsSummaryViewComponent : ViewComponent
    {
        private readonly ServiceManager _manager;

        public JobsSummaryViewComponent(ServiceManager manager)
        {
            _manager = manager;
        }

        public string Invoke() {
            return _manager.JobsService.GetAllJobs(false).Count().ToString();
        }
    }
}