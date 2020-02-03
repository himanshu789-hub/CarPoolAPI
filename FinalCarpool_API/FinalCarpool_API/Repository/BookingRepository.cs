using FinalCarpool_API.Models;
using FinalCarpool_API.Interfaces;
using Microsoft.EntityFrameworkCore;
using FinalCarpool_API.Enums;
using FinalCarpool_API.ViewModel;

namespace FinalCarpool_API.Repository
{
    public class BookingRepository:IBookingRepository
    {
        private DbContext _context;

        public BookingRepository(DbContext context)
        {
            _context = context;
        }

        public void Accept(Offering offerer, Booking booking)
        {
            throw new System.NotImplementedException();
        }

        public void Book(Offering offerer, Address source, Address destination, string UserId)
        {
            throw new System.NotImplementedException();
        }

        public void DestroyAllPreviousBooking(Offering offerer, Address reachedTill, bool direction)
        {
            throw new System.NotImplementedException();
        }

        public DbSet<Book> GetAllRequestedBooking(Offering offerer)
        {
            throw new System.NotImplementedException();
        }

        public void Removed(Booking booking)
        {
            throw new System.NotImplementedException();
        }
    }
}
