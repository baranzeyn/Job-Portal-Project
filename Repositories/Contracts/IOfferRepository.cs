using Job_Portal_Project.Models;

namespace Job_Portal_Project.Repositories
{
    public interface IOfferRepository : IRepositoryBase<Offer>
    {

        IQueryable<Offer> GetAllOffers(bool trackChanges);
        void CreateOffer(Offer offer);
    }
}