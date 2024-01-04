using Job_Portal_Project.Models;

namespace Job_Portal_Project.Services
{
    public interface IOfferService
    {
        void CreateOffer(Offer offer);
        IEnumerable<Offer> GetAllOffers(bool trackChanges);
        Offer? GetOneOfferByID(int id, bool trackChanges);
        void UpdateOneOffer(Offer offer);
        void DeleteOneOffer(int id);
    
    }
}