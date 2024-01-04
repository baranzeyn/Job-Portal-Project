using Job_Portal_Project.Models;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

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

        public void DeleteOneOffer(Offer offer)
        {
            Remove(offer);
        }

        public IQueryable<Offer> GetAllOffers(bool trackChanges)
        {
            return FindAll(trackChanges);
        }

        public Offer? GetOneOffer(int id, bool trackChanges)
        {
            return FindByCondition(o => o.OfferId.Equals(id), trackChanges);

        }
    
    }
}