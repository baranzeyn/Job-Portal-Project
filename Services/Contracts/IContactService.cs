using Job_Portal_Project.Models;

namespace Job_Portal_Project.Services
{
    public interface IContactService
    {
        void PostMessage(Message message);
    }

}