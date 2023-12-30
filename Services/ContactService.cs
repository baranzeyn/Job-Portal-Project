using Job_Portal_Project.Models;
using Job_Portal_Project.Repositories;

namespace Job_Portal_Project.Services
{
    public class ContactService : IContactService
    {
        private readonly IRepositoryManager _manager;

        public ContactService(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public void PostMessage(Message message)
        {
            _manager.Contact.PostMessage(message);
            _manager.Save();
        }

    }
}