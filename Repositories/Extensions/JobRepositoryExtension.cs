using Job_Portal_Project.Models;

namespace Job_Portal_Project.Repositories.Extensions
{
    public static class JobRepositoryExtension
    {
        public static IQueryable<Job>FilteredBySearchTerm(this IQueryable<Job> jobs, String? SearchTerm) {

            if(string.IsNullOrWhiteSpace(SearchTerm))
                return jobs;
            else
                return jobs.Where(j => j.JobTitle.ToLower().Contains(SearchTerm.ToLower()) 
                || j.CompanyName.ToLower().Contains(SearchTerm.ToLower())
                || j.Location.ToLower().Contains(SearchTerm.ToLower()));
        }
    }
}