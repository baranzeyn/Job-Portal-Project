namespace Job_Portal_Project.Repositories
{
    public interface IRepositoryManager
    {
        IUserRepository User { get; }
        IJobsRepository Jobs { get; }
        IContactRepository Contact { get; }
        void Save();
    }
}