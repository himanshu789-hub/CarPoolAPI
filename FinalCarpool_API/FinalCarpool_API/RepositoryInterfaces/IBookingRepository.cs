using FinalCarpool_API.Models;
using FinalCarpool_API.Enums;
using Microsoft.EntityFrameworkCore;
using FinalCarpool_API.ViewModel;

namespace FinalCarpool_API.Interfaces
{
   public interface IBookingRepository
    {    
         void Book(Offering offerer, Address source, Address destination, string UserId);
         void Accept(Offering offerer, Booking booking);
         DbSet<Book> GetAllRequestedBooking(Offering offerer);
         void DestroyAllPreviousBooking(Offering offerer, Address reachedTill,bool direction);
         void Removed(Booking booking);
    }
}
