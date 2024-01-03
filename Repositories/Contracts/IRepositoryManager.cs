namespace Job_Portal_Project.Repositories
{
    public interface IRepositoryManager
    {
        IAdminRepository Admin { get; }
        IUserRepository User { get; }
        IJobsRepository Jobs { get; }
        IContactRepository Contact { get; }
        void Save();
    }
}