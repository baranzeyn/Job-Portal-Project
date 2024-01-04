using Job_Portal_Project.Models;
using Job_Portal_Project.Repositories;

namespace Job_Portal_Project.Services
{
    public class OfferService : IOfferService
    {
            private readonly IRepositoryManager _manager;

        public OfferService(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public void CreateOffer(Offer offer)
        {
            _manager.Offer.Create(offer);
            _manager.Save();
        }

        public IEnumerable<Offer> GetAllOffers(bool trackChanges)
        {
            return _manager.Offer.GetAllOffers(trackChanges);
        }
    }
}