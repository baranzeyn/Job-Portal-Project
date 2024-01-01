using System.Linq.Expressions;

namespace Job_Portal_Project.Repositories
{
    public interface IRepositoryBase<T>
    {
        IQueryable<T> FindAll(bool trackChanges);

        T? FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges);
        IQueryable<T> GetByCondition(Expression<Func<T, bool>> expression);
        void Create(T t);

    }
}