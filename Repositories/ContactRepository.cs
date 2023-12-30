using Job_Portal_Project.Models;

namespace Job_Portal_Project.Repositories
{
    public class ContactRepository : RepositoryBase<Message>, IContactRepository
    {
        public ContactRepository(JobportalDbContext context) : base(context)
        {
        }

        public void PostMessage(Message message)
        {
            Create(message);
        }
    }
}