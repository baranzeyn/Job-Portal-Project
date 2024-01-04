using Job_Portal_Project.Models;

namespace Job_Portal_Project.Repositories
{
    public class OfferRepository : RepositoryBase<Offer>, IOfferRepository
    {
        public OfferRepository(JobportalDbContext context) : base(context)
        {
        }

        public void CreateOffer(Offer offer)
        {
            Create(offer);
        }
    }
}