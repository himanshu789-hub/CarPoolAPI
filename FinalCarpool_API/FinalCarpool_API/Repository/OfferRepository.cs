using FinalCarpool_API.Enums;
using FinalCarpool_API.Interfaces;
using FinalCarpool_API.Models;
using Microsoft.EntityFrameworkCore;

namespace FinalCarpool_API.Repository
{
    public class OfferRepository:IOfferRepository
    {
        private DbContext _context;

        public OfferRepository(DbContext context) => _context = context;

        public void Apply(Booking booking, Discount offer)
        {
            throw new System.NotImplementedException();
        }

        public Offering Create(string offererId)
        {
            throw new System.NotImplementedException();
        }
    }
}
