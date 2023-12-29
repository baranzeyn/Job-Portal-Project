using Job_Portal_Project.Models;
using Microsoft.AspNetCore.Server.IIS.Core;

namespace Job_Portal_Project.Repositories
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T>
    where T : class, new()
    {
        protected readonly JobportalDbContext _context;

        protected RepositoryBase(JobportalDbContext context)
        {
            _context = context;
        }

        public IQueryable<T> FindAll(bool trackChanges){
            throw new NotImplementedException();
        }
    }
}