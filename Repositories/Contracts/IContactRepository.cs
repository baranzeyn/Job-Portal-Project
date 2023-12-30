using Job_Portal_Project.Controllers;
using Job_Portal_Project.Models;

namespace Job_Portal_Project.Repositories
{   
    public interface IContactRepository : IRepositoryBase<Message>
    {
        void PostMessage(Message message);
    }    
}