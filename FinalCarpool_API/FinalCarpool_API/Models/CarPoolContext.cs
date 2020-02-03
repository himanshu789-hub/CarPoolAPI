using Microsoft.EntityFrameworkCore;

namespace FinalCarpool_API.Models
{
    public class CarPoolContext : DbContext
    {
        public CarPoolContext(DbContextOptions options) : base(options) {
        
        }

        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Offering> Offerings { get; set; }
        public DbSet<User> Users { get; set; }

        public DbQuery<FinalCarpool_API.ViewModel.Book> BookingView { get; set; }
    }
}
