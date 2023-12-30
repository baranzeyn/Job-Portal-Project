namespace Job_Portal_Project.Repositories
{
    public interface IRepositoryManager
    {
        IAdminRepository Admin { get; }
        IUserRepository User { get; }
        IJobsRepository Jobs { get; }
        void Save();
    }
}