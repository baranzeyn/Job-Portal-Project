using Microsoft.AspNetCore.Identity;

namespace Job_Portal_Project.Models
{
    public class OfferWithUserAndJobViewModel
    {
        public List<Job> Job { get; set; }
        public List<Offer> Offer { get; set; }
        public List<IdentityUser> User { get; set; }
    }
}