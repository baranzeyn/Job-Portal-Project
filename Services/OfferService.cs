using System.Net.Http.Headers;
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

        public void DeleteOneOffer(int id)
        {
            var offer = GetOneOfferByID(id, false);
            if (offer is not null)
            {
                _manager.Offer.DeleteOneOffer(offer);
                _manager.Save();
            }
        }

        public IEnumerable<Offer> GetAllOffers(bool trackChanges)
        {
            return _manager.Offer.GetAllOffers(trackChanges);
        }

        public Offer? GetOneOfferByID(int id, bool trackChanges)
        {
            return _manager.Offer.GetOneOffer(id, trackChanges);
        }

        public void UpdateOneOffer(Offer offer)
        {
            var entity = _manager.Offer.GetOneOffer(offer.OfferId, true);
            entity.OfferDate = offer.OfferDate;
            entity.OfferDuration = offer.OfferDuration;
            entity.OfferAmount = offer.OfferAmount;
            entity.ApplicantId = offer.ApplicantId;
            entity.Status = offer.Status;
            entity.JobId = offer.JobId;
            _manager.Save();
        }
    }
}