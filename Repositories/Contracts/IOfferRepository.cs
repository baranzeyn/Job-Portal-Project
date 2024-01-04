using Job_Portal_Project.Models;

namespace Job_Portal_Project.Repositories
{
    public interface IOfferRepository : IRepositoryBase<Offer>
    {
        void CreateOffer(Offer offer);
    }
}