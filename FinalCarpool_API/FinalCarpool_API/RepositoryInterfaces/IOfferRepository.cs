using FinalCarpool_API.Enums;
using FinalCarpool_API.Models;

namespace FinalCarpool_API.Interfaces
{
  public interface IOfferRepository
    {
         Offering Create(string offererId);
         void Apply(Booking booking, Discount offer);
    }
}
